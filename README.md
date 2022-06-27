# VeryBasicParser
A Basic Parser for C# with both the source code and a .dll binary in releases section.

# Usage

```csharp

VeryBasicParser parser = new VeryBasicParser(path,seperatorchar);
```
## Example text file (config.cfg)

```
bitrate=192000
samplerate=48000
```
## In your project:
```csharp

VeryBasicParser parser = new VeryBasicParser("config.cfg",'=');

string bitrate = parser.keyValues["bitrate"];

Console.WriteLine(bitrate); //Output would be 192000

```
