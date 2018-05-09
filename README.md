# Sharptile

C# representation of the [Tiled](https://www.mapeditor.org) map editor's
[JSON format](http://doc.mapeditor.org/en/stable/reference/json-map-format/).
Nothing more, nothing less. This is useful for importing an exported Tiled map
into a C#-based game engine like Unity.

There are multiple versions of Tiled's JSON map format. Currently Sharptile
targets version 1.2.


## Current Limitations

- Only supports maps with the *Tile Layer Format* property set to **CSV**
- Only supports one JSON map format (currently v1.2)


## Using in Unity

While Sharptile is intentionally minimal and uses no Unity APIs, usage in Unity
was the reason for its creation. After adding the *.cs* files to your project,
use an editor script like the following to import a map.

```csharp
using Sharptile;
using System.IO;
using UnityEditor;
using UnityEngine;

class TiledTest
{
    [MenuItem("Tiled/Import Map")]
    static void ImportTiledMap()
    {
        var path = Path.Combine(Application.dataPath, "map.json");
        var json = File.ReadAllText(path);
        var map = JsonUtility.FromJson<Map>(json);
        // Do something with the map...
    }
}
```

Creating the necessary game objects and components to actually *show* the map is
left up to you. For more comprehensive Tiled support in Unity look no further
than [Tiled2Unity](http://www.seanba.com/Tiled2Unity).
