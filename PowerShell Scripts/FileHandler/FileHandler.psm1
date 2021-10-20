function DownloadEVEFiles {
    [CmdletBinding()]
    param (
        [Parameter()]
        [Switch]
        $IncludeGraphics
    )

    $URL = "https://eve-static-data-export.s3-eu-west-1.amazonaws.com/tranquility/sde.zip"
    $SDEPath = ".\EVEData\SDE"
    $SDEFile = "$SDEPath\sde.zip"
    if (-not (Test-Path $SDEPath)) {
        New-Item -ItemType Directory -Name $SDEPath -Path ".\" -Force
    }
    
    # Always download the latest version
    if ((Test-Path $SDEFile)){
        Remove-Item -Path $SDEFile -Force
    }
    Invoke-WebRequest -Uri $URL -OutFile $SDEFile
}