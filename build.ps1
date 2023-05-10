# Remember current directory
$current = Get-Location;

# Search for all package configrations to restore nuget packages
$solutions = get-childitem -Filter *.sln -Recurse
$solutions | ForEach-Object -Process {
    Write-Output $_.Directory.FullName
    Set-Location -Path $_.Directory.FullName
	# start the restore
    &'C:\Program Files (x86)\Ranorex\Studio\Bin\Addins\Misc\PackageManagement\nuget' restore $_.Name
}
# restore start-directory
Set-Location $current

# Search for all project files
$solutions | ForEach-Object -Process {
    Write-Output $_.FullName
    Set-Location -Path $_.Directory.FullName
	# ...and compile them
    &'C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild' /fileloggerparameters:LogFile=$current+"\Log\"+$_.Name+".log" /p:configuration=Debug $_.Name
}

# restore start-directory
Set-Location $current
