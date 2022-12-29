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
string[] ArrDelete3(string[] Arr)
{
    int i = 0;
    int count = 0;
    while(i < Arr.Length)
    {
        if(Arr[i].Length <= 3)
        {
            count++;
        }
        i++;
    }
    string[] Arr2 = new string[count]; 
    i=0;
    count=0;
    while(i < Arr.Length)
    {
        if(Arr[i].Length <= 3) 
        {
            Arr2[count]=Arr[i];
            count++;
        }
        i++;
    }
    return Arr2;
}
Console.WriteLine("Введите длину массива:");
int Len;
Len = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string[Len];
CreatArr(Arr);
Console.WriteLine("Введённый массив:");
PrintArr(Arr);
Arr = ArrDelete3(Arr);
Console.WriteLine("Массив только со словами меньше 3:");
PrintArr(Arr);
