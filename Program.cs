using System;

namespace Максимальное_из_3_чисел
{
    public class Answer
    {
        static int FindMax(int a, int b, int c)
        {
            int[ ] numbers = { };   //Из заданных чисел сформируем массив
            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;

            Array.Sort(numbers);    //Отсортируем массив по возрастанию
            return numbers[2];      //И элемент с максимальным индексом будет наибольшим числом
                                    //из заданных
        }
        static public void Main(string[] args)
        {
            int a, b, c;
            if(args.Length >= 3)
            {
                a = int.Parse(args[0]);
                b = int.Parse(args[1]);
                c = int.Parse(args[2]);
            }
            else
            {
                a = 5;
                b = 6;
                c = 7;
            }
            int result = FindMax(a, b, c);
            System.Console.WriteLine($"{result}");
        }
    }
}

