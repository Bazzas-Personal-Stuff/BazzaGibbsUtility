# BazzaGibbs Utility

Common utility classes for Unity.

Full documentation is WIP.

## Installation

1. Copy URL from GitHub's `<> Code` button
2. Package Manager -> Add package from git URL

## Features

- [Vector Extensions](#vector-extensions)
- [HelpBox Decorator Attribute](#helpbox-decorator-attribute)

### Vector Extensions

- `Vector2.ToTopDown() -> Vector3`
- `Vector3.FromTopDown() -> Vector2`

### HelpBox Decorator Attribute

Add help text boxes without a PropertyDrawer or custom editor.

```csharp
public class UtilityDemo : MonoBehaviour {
    [HelpBox("This is a help message!", HelpBoxMessageType.Warning)]
    public int myInt;
}
```
![helpbox.png](Documentation~/images/helpbox.png)

Credit: Tony Li

