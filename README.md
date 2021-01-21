# NOTE: THIS PROJECT IS IN NO WAY ENDORSED BY MICROSOFT (the source code however is from microsofts repo), NOR IS THE PROJECT CREATER.
# PowerShell debugging tool
This is a simple tool that simply prints out whatever a powershell command is truely doing, this is useful sometimes to de-obfuscate powershell commands.

### Current commands that give output:
Get-Content
Out-File
Invoke-Expression
Invoke-WebRequest

### Commands not yet done (but planned to):



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
