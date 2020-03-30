# make my cmdlet available to current PowerShell instance
Import-Module C:\Users\ratcl\source\repos\CJRCmdlets\CJRCmdlets\bin\Release\CJRCmdlets.dll
# show cmdlets available in script
Get-Command -module CJRCmdlets
# gets number of days in the past creation date for all files in the Documents directory 
$x = Get-ChildItem C:\Users\ratcl\Documents
ForEach ($y in $x) {$y.CreationTime.ToString('MM/dd/yyyy') | Get-DaysBeforeNowOfDate}  
# end of example