Param(
	[string]$ReadyRollProjectRoot
)

$vhdLocation = join-path $ReadyRollProjectRoot "Database\disk.vhd"
$vhdExists = Test-Path $vhdLocation

if($vhdExists)
{
	Dismount-VHD –Path $vhdLocation
	Remove-Item -Path $vhdLocation -Force
	cmd /c rmdir $ReadyRollProjectRoot\Database\Database
}