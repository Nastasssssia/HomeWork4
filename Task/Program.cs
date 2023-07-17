
int task = Input("Введите номер задачи:");
if(task == 25) Task25();
else if(task == 27) Task27();
else if(task == 29) Task29();






int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



void Task25()
{
    //Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    int a = Input("Введите число-основание степени:");
    int b = Input ("Ведите число- показатель степени:");
    int degree = 1;
    int count = 1;
    if(b == 0)
    {
        Console.WriteLine($"Число {a} в степени {b} = 1");
    }
    else
    {
        while( count <= b)
    {
        degree *= a;
        count++;
    }
    
    Console.WriteLine($"Число {a} в степени {b} = {degree}");
    }
    // Можно было с помощью функции Math.Pow(a,b)
}

void Task27()
{
    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.Write("Введите число:");
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    int tempNumber = number; // для временного хранения числа
    while(tempNumber != 0)
    {
        int digit = tempNumber % 10; // находим последнюю цифру
        sum += digit;
        tempNumber /= 10; // переходим к слудующей цифре
    }
    Console.WriteLine($"Сумму цифр числа {number} = {sum}");


}



void Task29()

{
    //  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
    int size = 8;
    Random rnd = new Random();
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1,100);
    }
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    SelectionSort(array);
    Console.WriteLine();
    Console.WriteLine("Отсортированный по модулю массив:");
    PrintArray(array);

    void PrintArray(int[]array)
    {
        int count = array.Length;
        for(int i = 0; i < count; i++ )
        {
            Console.Write($"{array[i]} ");
        }
    }

    void SelectionSort(int []array)
    {
        for(int i = 0; i < array.Length; i++ )
        {
            int minPosition = i;
            for(int g = i+1; g < array.Length; g++)
            {
                if(Math.Abs(array[g]) < Math.Abs(array[minPosition])) minPosition = g;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;

        }
    }
}
            

        










       
    


