// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;

namespace exs52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве: ");
            int rows=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns=int.Parse(Console.ReadLine());
            double [,] array =GetDoubleArray(rows,columns,0,20);
            PrintArray(GetDoubleArray(rows,columns,0,20));
           
            double[,] GetDoubleArray(int rows, int columns, double min, double max)
           {
            double[,]result=new double[rows,columns];
            Random random = new Random();
            for (int i=0;i<rows;i++)
                {
                    for( int j=0; j<columns; j++)
                    {
                       result[i,j]= random.NextDouble() * 100;
                    }
                }
                return result;
            }
   
            void PrintArray(double[,]array)
            {     
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                        Console.Write("{0,6:F2}",array[i,j]);
                    }
                    Console.WriteLine();
                }
            }    
       
        }
    }
}

            
            