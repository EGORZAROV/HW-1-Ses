// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма.

void PrintArray(string[] arr) // Метод печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrPrimary = new string[size]; // иницилизируем массив с размерами строк
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine()?? "0");
     arrPrimary[i] = element; // вводим элемент в массив
}

string[] arrResult = new string[size]; // иницилизируем итоговый масив
int length = 3; // длиной до 3 символов
int count = 0;  

for (int j = 0; j < size; j++)
{
    if (arrPrimary[j].Length <= length)
    {
        arrResult[count] = arrPrimary[j]; // вводим результат в итоговый массив
        count++;
    }
}

Console.WriteLine();

PrintArray(arrResult);
