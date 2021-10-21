function SplitYamlEntries($yaml) {
    $lineNumbers = ($yaml | Select-String -Pattern '^\d*:').LineNumber
    $EOF = $yaml.Length
    $returnObject = New-Object string[] $lineNumbers.Count

    for ($i = 0; $i -lt $($lineNumbers.Count); $i++) {
        $yamlObject = ""
        $currentIndex = $lineNumbers[$i] - 1
        $endIndex = $lineNumbers[$i + 1] - 1
        if ($endIndex -eq -1) {
            $endIndex = $EOF
        }
        while ($currentIndex -lt $endIndex) {
            $yamlObject += "$($yaml[$currentIndex])`r`n"
            $currentIndex++
        }
        $returnObject[$i] = $yamlObject
    }
    return $returnObject
}

function RemoveTraitsFromYamlObj([hashtable]$YamlObj) {
    $toRemove = @(
        "traits", 
        "description",
        "radius",
        "sofFactionName",
        "soundID",
        "published",
        "basePrice",
        "raceID",
        "masteries",
        "capacity",
        "variationParentTypeID",
        "portionSize",
        "factionID",
        "mass",
        "marketGroupID",
        "metaGroupID")
    foreach ($trait in $toRemove) {
        $YamlObj.Remove($trait)
    }
    return $YamlObj
}

function PrepYamlForDB($yaml) {
    $splitYaml = SplitYamlEntries($yaml)
    $formattedYaml = New-Object string[] $splitYaml.Count
    for ($i = 0; $i -lt $splitYaml.Count; $i++) {
        # '620:`n' -> '    typeID: 620`n'
        $formattedYaml[$i] = $splitYaml[$i] -replace '^(\d+):','    typeID: $1'
    }
    $validYaml = ConvertFrom-Yaml $formattedYaml[1]
    return $validYaml
    # foreach ($key in $validYaml.Keys) {
    #     Write-Host "$key " -NoNewline
    #     Write-Host $validYaml[$key]
    # }
}