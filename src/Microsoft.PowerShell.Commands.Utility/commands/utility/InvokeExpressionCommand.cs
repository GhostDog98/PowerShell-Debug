// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// Class implementing Invoke-Expression.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Invoke, "Expression", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2097030")]
    public sealed
    class
    InvokeExpressionCommand : PSCmdlet
    {
        #region parameters

        /// <summary>
        /// Command to execute.
        /// </summary>
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
        [ValidateTrustedData]
        public string Command { get; set; }
        
        private static string DeskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PowerShell-Debug-Info.txt"; // Get the desktop folder

        #endregion parameters

        /// <summary>
        /// For each record, execute it, and push the results into the success stream.
        /// </summary>
        protected override void ProcessRecord()
        {
            Diagnostics.Assert(Command != null, "Command is null");
            Console.WriteLine("Something called Invoke-Expression with the command of: \"" + Command + "\""); // 7kzlu

            long CurTime = DateTime.Now.Ticks; // Get the time in ticks, to show some command happen after another.
            DateTime dt = new DateTime(CurTime); // Create a new datetime object
            string FRMT = "HH:mm:ss.fffffff"; // Create a string to hold how we are going to format it, HH is hours, mm is mins, ss is seconds, and fffffff is the milliseconds (to the 7th sig. digit)
            string timecur = dt.ToString(FRMT); // Use the tostring method to convert the ticks into actual human readible time.
            using (StreamWriter sw = File.AppendText(DeskPath))
            {
            sw.WriteLine(timecur + "| (Invoke-Expression) | Invoked: " + Command);
            }         
            // Event logging
             EventLog eventLogNew = new EventLog();
            eventLogNew.Source = "PowerShell-Debug-Logging";
            eventLogNew.WriteEntry(timecur + " | (Invoke-Expression) | Invoked: " + Command, EventLogEntryType.Information, 0003);

            ScriptBlock myScriptBlock = InvokeCommand.NewScriptBlock(Command);

            // If the runspace has ever been in ConstrainedLanguage, lock down this
            // invocation as well - it is too easy for the command to be negatively influenced
            // by malicious input (such as ReadOnly + Constant variables)
            if (Context.HasRunspaceEverUsedConstrainedLanguageMode)
            {
                myScriptBlock.LanguageMode = PSLanguageMode.ConstrainedLanguage;
            }

            var emptyArray = Array.Empty<object>();
            myScriptBlock.InvokeUsingCmdlet(
                contextCmdlet: this,
                useLocalScope: false,
                errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe,
                dollarUnder: AutomationNull.Value,
                input: emptyArray,
                scriptThis: AutomationNull.Value,
                args: emptyArray);
        }
    }
}