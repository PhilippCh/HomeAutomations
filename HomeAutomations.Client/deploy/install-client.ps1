$sourceDirectory = "${PSScriptRoot}\.."
$destinationDirectory = "$Env:Programfiles\HomeAutomations.Client"
Copy-item -Force -Recurse $sourceDirectory -Destination $destinationDirectory

sc.exe stop "HomeAutomations.Client"
sc.exe delete "HomeAutomations.Client"
sc.exe create "HomeAutomations.Client" binpath="$destinationDirectory\HomeAutomations.Client.exe" start=auto
sc.exe start "HomeAutomations.Client"
