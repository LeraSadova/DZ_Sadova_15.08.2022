// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Привет, друг! Давай с тобой выведем таблицу кубов для диапазона от 1 до N?");
Console.WriteLine("Введи ЦЕЛОЕ число, большее 1: ");
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());

void Cube(int[] kub)
{
    int index=0; //присваиваем 0
    int lenght=kub.Length; //длина массива
    while (index<lenght) //пока счетчик меньше длины
    {
        kub[index]=Convert.ToInt32(Math.Pow(index,3)); //функция для поиска куба числа
        index++;
    }
}
void PrintMassiv(int[] massiv)
{
    int count =massiv.Length; //длина массива
    int ind=1; //чтоб не выводил 0
    
    while (ind<count)
    {
        
        Console.Write(massiv[ind]+ " ");
        ind++; //+1
    }
}

int[] arry = new int[n+1];
Cube(arry);
Console.WriteLine();
Console.Write($"Таблица кубов заданного числа {n}: ");
PrintMassiv(arry);
