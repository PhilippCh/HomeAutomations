$serviceName = "HomeAutomations.Client.Watchdog"
$path = Join-Path (Get-Item .).FullName "HomeAutomations.Client.Watchdog.exe"

sc.exe delete "HomeAutomations.Client.Watchdog"

Write-Output "sc.exe create `"$serviceName`" binpath=`"$path`""
sc.exe create $serviceName binpath="$path" start=auto
sc.exe start $serviceName
