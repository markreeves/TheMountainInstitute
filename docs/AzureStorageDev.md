# Setting up Azure Storage emulator for local dev

## Azure storage VSCode Extension

This is included in the recommended vscode workspace extensions.

## Connection Strings

See <https://docs.microsoft.com/en-us/azure/storage/common/storage-configure-connection-string>

## Azure Storage Explorer

We are currently using the legacy storage explorer due to a need for table storage support.
See <https://docs.microsoft.com/en-us/azure/storage/common/storage-use-emulator?toc=/azure/storage/blobs/toc.json>

This is available for direct download here:
<https://go.microsoft.com/fwlink/?linkid=717179&clcid=0x409>

## Azurite VSCode extension

This doesn't currently support Azure Table Storage so we will need to wait to switch to this later.
Currently using the Legacy NPM Package:
See <https://github.com/Azure/Azurite/tree/legacy-master> and <https://www.npmjs.com/package/azurite>

### C# API Usage tutorial

<https://www.c-sharpcorner.com/article/azure-storage-tables/>

### Table Schemas

#### Genus

``` misc
GenusID     string (GUID)    RowKey
Name        string 
Intro       string
ImageUrl    string
```

#### Kingdom

``` misc
KingdomID     string (GUID)    RowKey
GenusID       string (GUID)    PartitionKey
Name          string
Intro         string
ImageUrl      string
ImageCredit   string
```

#### Species

``` misc
SpeciesID     string (GUID)    RowKey
KingdomID     string (GUID)    PartitionKey
GenusID       string (GUID)
Name          string
LocalName     string
LatinName     string
Intro         string
Info          string
ImageUrl      string
ImageCredit   string
Habitat       string
Regions       string (json)
Identifiers   string (json)
```
