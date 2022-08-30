// Example 1
int var1 = 0xFFFF;
int var2 = 0b1111111111111111;

Console.Write("Example 1.1: ");
Console.WriteLine(var1 - var2);

Console.Write("Exapmle 1.2: ");
Console.WriteLine(Convert.ToBoolean(var1 - var2));

Console.Write("Exapmle 1.3: ");
Console.WriteLine(Convert.ToBoolean(var1 / var2));

// Example 2
int var3 = 0b1111111111111111;

Console.Write("Exapmle 2.1: ");
Console.WriteLine(Convert.ToString(var3, 16));
Console.Write("Exapmle 2.2: ");
Console.WriteLine(Convert.ToInt32(var3));

// Example 3
string var4 = "beef";

Console.Write("Exapmle 3.1: ");
Console.WriteLine(Convert.ToInt32(var4, 16));
Console.Write("Exapmle 3.2: ");
Console.WriteLine(Convert.ToString(Convert.ToInt32(var4, 16), 2));
