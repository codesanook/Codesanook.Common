param(
    [Parameter(Mandatory = $true)]
    [string]
    $TargetDir
)

$destination = "./../../../bin/x86"
New-Item -ItemType Directory $destination -Force -ErrorAction SilentlyContinue

"okay"
Get-ChildItem -Path $TargetDir -Recurse `
| Where-Object { $_.FullName -match 'x86.*v8' } `
| Copy-Item -Destination $destination -Verbose
