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
    $key = $YamlObj.Keys
    foreach ($trait in $toRemove) {
        $YamlObj[$key].Remove($trait)
    }
    return $YamlObj
}