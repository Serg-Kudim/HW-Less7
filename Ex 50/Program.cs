// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 50);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
string SerchNumber(int[,] arr, int number)
{
    string mesSerch = "Number exists";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (number == arr[i, j])
            {
                return mesSerch;
            }
        }
    }
    return mesSerch = "number does not exist";
}
Console.Write("Enter number M: ");
int row = InputNumber();
Console.Write("Enter number N: ");
int colums = InputNumber();

int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);

Console.Write("Enter a number to search for: ");
int numberSearch = InputNumber();
System.Console.WriteLine(SerchNumber(array, numberSearch));