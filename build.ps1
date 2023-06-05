Write-Output ::System::.DateTime.Now
# store current directory
$current = Get-Location;
md Log

# Search for all package configrations to restore nuget packages
$solutions = get-childitem -Filter *.sln -Recurse

# Search for all project files
$solutions | ForEach-Object -Process {
    Write-Output $_.FullName
    Set-Location -Path $_.Directory.FullName
	# start the restore
	Write-Output 'C:\Program Files (x86)\Ranorex\Studio\Bin\Addins\Misc\PackageManagement\nuget restore '$_.Name
    &'C:\Program Files (x86)\Ranorex\Studio\Bin\Addins\Misc\PackageManagement\nuget' restore $_.Name
	# ...and compile them
	Write-Output 'C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild /fileloggerparameters:LogFile='$current'\Log\'$_'.log /p:configuration=Debug '$_
    &'C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild' /fileloggerparameters:LogFile=$current"\Log\"$_".log" /p:configuration=Debug $_
}

# restore start-directory
Set-Location $current
