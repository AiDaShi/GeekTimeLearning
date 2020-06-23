># 自制二叉树库

支持多种类型的排序方式类型如下：
char,double,float,int,long,short,string
可以通过Obj对象进行存储数据

>### 示例代码

```csharp
Tree<int> TI = new Tree<int>();
TI.AddNode(new Node_Int() { Value=5 });
TI.AddNode(new Node_Int() { Value=3 });
TI.AddNode(new Node_Int() { Value=7 });
TI.AddNode(new Node_Int() { Value=9 });


Tree<char> CharTI = new Tree<char>();

CharTI.AddNode(new Node_Char() { Value = 'a' });
CharTI.AddNode(new Node_Char() { Value = 'm' });
CharTI.AddNode(new Node_Char() { Value = 'p' });
CharTI.AddNode(new Node_Char() { Value = 'b' });
CharTI.AddNode(new Node_Char() { Value = 'q' });

Tree<string> StringTI = new Tree<string>();
StringTI.AddNode(new Node_String() { Value = "Bob" });
StringTI.AddNode(new Node_String() { Value = "Venzent" });
StringTI.AddNode(new Node_String() { Value = "Alan" });
StringTI.AddNode(new Node_String() { Value = "Riccardo" });
StringTI.AddNode(new Node_String() { Value = "Oliver" });

Console.WriteLine($"Char :{ string.Join(',', CharTI.GetAllValue(true).ToArray())}");
//Console.WriteLine("Char :" +JsonConvert.SerializeObject(CharTI.GetAllNode(true)));

foreach (var item in StringTI.GetAllNode())
{
    Console.WriteLine($"String Value:{item.Value}");
}
Console.WriteLine("Left Begin");
foreach (var item in TI.GetAllNode())
{
    Console.WriteLine($"Value:{item.Value}");
}

Console.WriteLine("Right Begin");
foreach (var item in TI.GetAllNode(false))
{
    Console.WriteLine($"Value:{item.Value}");
}
var searchone = TI.Search(7);
Console.WriteLine($"Search Value: {searchone.Value}"); 

Console.ReadKey();
```