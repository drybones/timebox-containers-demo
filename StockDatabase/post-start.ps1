$DatabaseServer = $env:COMPUTERNAME
$DatabaseName = $env:database_name
. (Resolve-Path $PSScriptRoot\*_DeployPackage.ps1)
