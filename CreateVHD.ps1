Param(
[string]$SQLCloneImagePath,
[string]$ReadyRollProjectRoot
)

$vhdLocation = Join-Path $ReadyRollProjectRoot "Database\"

$doesVHDExist = Test-Path -Path $vhdLocation\disk.vhd

if (!$doesVHDExist)
{
  New-VHD –Path $vhdLocation\disk.vhd –ParentPath $SQLCloneImagePath –Differencing
}

$isVhdMounted = Get-VHD -Path "$vhdLocation\disk.vhd" | Select-String Attached

if(!$isVhdMounted)
{
    Mount-VHD –Path $vhdLocation\disk.vhd -NoDriveLetter
    $Volume = GET-DISKIMAGE $vhdLocation\disk.vhd | GET-DISK | GET-PARTITION
    cmd /c mklink /d $vhdLocation\Database $Volume.AccessPaths[0]
}