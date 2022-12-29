// See https://aka.ms/new-console-template for more information

void CreatArr(string[] Ar1)
{
    int i = 0;
    while(i < Ar1.Length)
    {
        Console.WriteLine($"Введите {i+1} строку:");
        Ar1[i] = Console.ReadLine();
        i++;
    }
}
void PrintArr(string[] Arr)
{
    int i = 0;
    while(i < Arr.Length)
    {
        Console.WriteLine($" {Arr[i]} ");
        i++;
    }
}
Console.WriteLine("Введите длину массива:");
int Len;
Len = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string[Len];
CreatArr(Arr);
PrintArr(Arr);
