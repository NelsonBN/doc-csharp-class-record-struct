# Class vs. Record vs. Struct

### Technologies implemented:
- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)


### Tools
- [Visual Studio Code](https://code.visualstudio.com/download)


## Documentation

### Specs

|            | Class                                | Record                     | Struct          |
| :---       | :---                                 | :---                       | :---            |
| Type       | Reference type                       | Reference type<sup>1</sup> | Value type      |
| Store      | Memory address of the allocated data | Data value                 | Data value      |
| Allocation | Heap                                 | Heap                       | Stack           |
| Comparison | Memory address                       | Values                     | Unsupported     |
| HashCode   | Based in instance reference          | Based in values            | Based in values |

* **1**: The record is _Reference type_ but the comparison works as _Value type_

### Support

|                     | Class   | Record  | Struct  |
| :---                | :---:   | :---:   | :---:   |
| Inheritance         | &check; | &check; | &cross; |
| Constructs          | &check; | &check; | &check; |
| Distructors         | &check; | &check; | &cross; |
| With expression     | &cross; | &check; | &cross; |
| Comparison "=="     | &check; | &check; | &cross; |
| Comparison "Equals" | &check; | &check; | &check; |


### How can I use it?

#### Declaration
##### Class
```csharp
public class CDriver
{
    public string Name { get; set; } 
    public string Team { get; set; }
    public uint BirthYear { get; set; }
}
```

##### Record
```csharp
public record RDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }
}
```
Or

```csharp
public record RDriver(string Name, string Team, uint BirthYear);
```

##### Struct
```csharp
public struct SDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }
}
```

### Notes
- Record is only available in **.net5 (c# 9)**
- The stack has a fixed memory size:
  - OS x86 (32-bit): 1MB
  - OS x64 (64-bit): 4MB
- The **StackOverflowException** is thrown when the execution stack overflows

## Reference links
* [Stack vs. Heap](https://www.c-sharpcorner.com/article/stack-vs-heap-memory-c-sharp/)
* [Records C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record)


## Contribution

*Help me to help others*

## LICENSE

[MIT](https://github.com/NelsonBN/doc-csharp-class-record-struct/blob/main/LICENSE)