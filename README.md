# NOTE: THIS PROJECT IS IN NO WAY ENDORSED BY MICROSOFT (the source code however is from microsofts repo), NOR IS THE PROJECT CREATER.
# PowerShell debugging tool
PowerShell-Debug is a tool that reveals what an obfuscated command is actually doing, no matter how much it is concealed (at least that is the aim).<br>
So far, it logs this using the following methods, neither of which have any known methods of interception (at least to my knowledge): <br>
Prints to the terminal itself using Console.WriteLine <br>
Writes all commands executed to a .txt on the desktop, alongside timestamps. <br> 

### Current commands that give output:
Get-Content <br>
Out-File <br>
Invoke-Expression <br>
Invoke-WebRequest <br>

### Commands not yet done (but planned to):
New-ItemProperty (writes registry)<br>
Test-Path (tests if a path exists)<br>
Get-ItemProperty (Read registry)<br>


### Suggestions:
To suggest features, simply put up an issue or pull request, and i'll probably impliment it.

### ToDo:
Change a bunch of the .md files to actually represent the new repo.
Report registry functions (if anyone wants to figure this out, good luck, as the file for registry stuff is ~4000 lines long...)
Change/Add to the current way of reporting commands to setting an eventViewer event, as this is more permanent and also catchable if the program is not run in a visable window.


## Downloading the Source Code

You can just clone the repository:

```sh
git clone https://github.com/PowerShell/PowerShell.git
```

See [working with the PowerShell repository](https://github.com/GhostDog98/PowerShell-Debug/tree/master/docs/git) for more information.

## Legal and Licensing

PowerShell is licensed under the [MIT license][].

[MIT license]: https://github.com/PowerShell/PowerShell/tree/master/LICENSE.txt

## [Code of Conduct][conduct-md]

This project has adopted the [Microsoft Open Source Code of Conduct][conduct-code].
For more information see the [Code of Conduct FAQ][conduct-FAQ] or contact [opencode@microsoft.com][conduct-email] with any additional questions or comments.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[conduct-md]: https://github.com/PowerShell/PowerShell/tree/master/CODE_OF_CONDUCT.md
