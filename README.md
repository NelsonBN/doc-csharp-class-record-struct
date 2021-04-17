## DEMO Classs vs. Record vs. Struct

#### Technologies implemented:

- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)


#### Tools
- [Visual Studio Code](https://code.visualstudio.com/download)

---

### Documentation

##### Specs

|            | Class                                | Record     | Struct      |
| :---       | :---                                 | :---       | :---        |
| Type       | Reference type                       | Value type | Value type  |
| Store      | Memory address of the allocated data | Data value | Data value  |
| Allocation | Heap                                 | Stack      | Stack       |
| Comparison | Memory address                       | Values     | Unsupported |


##### Support

|                 | Class   | Record  | Struct  |
| :---            | :---:   | :---:   | :---:   |
| Inheritance     | &check; | &check; | &cross; |
| Constructs      | &check; | &check; | &check; |
| Distructors     | &check; | &check; | &cross; |
| With expression | &cross; | &check; | &cross; |
| Comparison      | &check; | &check; | &cross; |


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

#### Reference links
* [Stack vs. Heap](https://www.c-sharpcorner.com/article/stack-vs-heap-memory-c-sharp/)

---

#### Contribution

*Help me to help others*

#### LICENSE

[MIT](https://github.com/NelsonBN/Demo-Class-vs-Record-vs-Struct/blob/main/LICENSE)
