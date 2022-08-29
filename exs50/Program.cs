//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет
using System;

namespace exs50
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите количество строк в массиве: ");
            int rows=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns=int.Parse(Console.ReadLine());
             Console.WriteLine("Введите номер строки нужного элемента: ");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер столбца нужного элемента: ");
            int n=int.Parse(Console.ReadLine());
            
            int [,] array =GetArray(rows,columns,0,20);
            Console.WriteLine();
            PrintArray(array); 
            SearchElement(array); 
            int[,] GetArray(int rows, int columns, int min, int max)
            {
            int[,]result=new int[rows,columns];
            Random random = new Random();
            for (int i=0;i<rows;i++)
                {
                    for( int j=0; j<columns; j++)
                    {
                       result[i,j]= new Random().Next(min,max);
                    }
                }
                return result;
            }
   
            void PrintArray(int[,]array)
            {     
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                        Console.Write($" {array[i,j]}");
                    }
                    Console.WriteLine();
                }
            } 
             void SearchElement(int[,]array)
            {   
                
                if (m<=array.GetLength(0) && n<=array.GetLength(1))
              
                    {
                    Console.WriteLine ($"Число {array[m,n]} в массиве есть ");
                    }
                    
                    else
                    {
                         Console.WriteLine ("Числа  в массиве нет ");
                    }
                     
      
            } 
        }
    }
}
