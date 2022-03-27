using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод эл массива
            Console.Write("Введите кол-во элементов в массиве:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            //Создание масива   
            int[] myArray = new int[num];

            //Добавление в массив чисел
            for (int i = 0; i <= num - 1; i++)
            {
                Console.Write("Введите значение масива под {0}: ",i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());

                //если в массиве есть 0(закрытие)
                if (myArray[i] == 0) 
                {
                    Console.WriteLine();
                    //i - позиция последнего элемента в массиве
                    Console.WriteLine("Длинна массива = {0}",i);
                    break;
                }

            }

            //Вывод массива
            Console.Write("\nМассив:\t");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
