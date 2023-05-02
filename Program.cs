Start();
void Start()
{
    Console.Clear();
    int size = SetNumber("размер массива");
    Console.WriteLine();
    string[] array = GetStringArray(size);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    string[] changearray = GetNewArray(array);
    PrintArray(changearray);
    Console.WriteLine(); 
}

int SetNumber(string text = "")
{
    Console.Write($"Введите {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
string[] GetStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        string element = Convert.ToString(Console.ReadLine());
        array[i] = element;

    }
    return array;
}
void PrintArray(string[] array)
{
   
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}   ");
        }
        Console.WriteLine();
   
}

 string[] GetNewArray(string[] array)
{

   string[] newarray = new string[array.Length];
   int len = 3;
   int j = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= len)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}
 