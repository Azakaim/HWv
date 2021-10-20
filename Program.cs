using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {

            //Вызвал метод вывода данных в выходной поток компилятора со значением
            //"Введите Ф.И.О.:"

            Console.WriteLine("\r\nВведите Ф.И.О.:");

            //присвоил переменной Fullname типа var значение с помощью оператора =
            //методом обработки ввода информации пользователем

            var Fullname = Console.ReadLine();


            Console.WriteLine("\r\nВведите возраст:");

            //присвоил переменной Age типа var значение с помощью оператора =
            //методом обработки ввода информации пользователем

            var Age = Console.ReadLine();

            //назначил переменную ValueWariable

            double ValueWariable;


            //присвоил значение true переменной flag

            bool flag = true;

             //использовал метод конвертации TryParse и присвоил переменной
            //flag типа double значение из перемеенной Age или ValueWariable
            //при не правлильно введенном значении с помощью
            //метода конвертации типов 

            flag = double.TryParse(Age, out ValueWariable);

            // изучил 3.4 матерал урока и применил условную конструкцию if

            if (flag)
            {

                Console.WriteLine("\r\nВведите Email:");

            }

            else
            {
                Console.WriteLine("\r\nНеверный формат ввода\nВведите данные еще раз :");

                double j;

                var Age2 = Console.ReadLine();

                bool flag2 = double.TryParse(Age2, out j);

                if (flag2)

                {
                    Console.WriteLine("\r\nВведите Email:");

                }

                else
                {
                    Console.WriteLine("\r\nI'm tired\r\nGAME OVER");

                }


                if (flag2 != true)
                {
                    Console.WriteLine("\r\nВведите Email:");
                }

            }

            var Email = Console.ReadLine();

            //присвоил переменной Email типа var значение с помощью оператора =
            //методом обработки ввода информации пользователем

            //назначил переменную ValueWariable1 

            double ValueWariable1;

            Console.WriteLine("\r\nВведите набранные баллы по информатике:");

            //присвоил переменной Prog_points типа var значение с помощью оператора =
            //методом обработки ввода информации пользователем

            var Prog_points = Console.ReadLine();

            

            //использовал метод конвертации TryParse и присвоил переменной
            //flag3 типа double значение из перемеенной Prog_points или ValueWariable1
            //(при не правлильно введенном значениис помощью
            //метода конвертации типов 
            bool flag3 = true;

            flag3 = double.TryParse(Prog_points, out ValueWariable1);

            //определил переменные


            double ValueWariable2;

            Console.WriteLine("\r\nВведите набранные баллы по математике:");

            //присвоил переменной Math_points типа var значение с помощью оператора =
            //методом обработки ввода информации пользователем

            var Math_points = Console.ReadLine();

            //использовал метод конвертации TryParse и присвоил переменной
            //flag4 типа double значение из перемеенной Math_points или ValueWariable2
            //(при не правлильно введенном значениис помощью
            //метода конвертации типов 

            bool flag4 = true;

            flag4 = double.TryParse(Math_points, out ValueWariable2);

            //назначил переменную

            double ValueWariable3;

            Console.WriteLine("\r\nВведите набранные баллы по физике:");

            //присвоил переменной Physics_scores типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем

            var Physics_scores = Console.ReadLine();

            //использовал метод конвертации TryParse и присвоил переменной
            //flag5 типа double значение из перемеенной Physics_scores или ValueWariable3
            //(при не правлильно введенном значениис помощью
            //метода конвертации типов 

            bool flag5 = true;

            flag5 = double.TryParse(Physics_scores, out ValueWariable3);


            //Обьявил переменную под сумму баллов по всем предметам
            //Обьявил переменную под средний балл

            double ValueWariableAll, ValueWariableAll2;

            // Посчитал сумму баллов
            ValueWariableAll = ValueWariable1 + ValueWariable2 + ValueWariable3;

            //Рассчитал среднее арифметическое баллов
            ValueWariableAll2 = ValueWariableAll / 2;

            //Объявил перменную стринг в котрой обозначил паттерн вывода
            //на экран информации с помощю интерполяции строк

            string pattern = $"\r\n \nФ.И.О.:{Fullname,25} " +
               $"\nВозраст:{Age,19}" +
               $" \nПочта:{Email,23} " +
               $"\nБаллы по програмированию:{Prog_points,2} " +
               $"\nБаллы по математике:{Math_points,7} " +
               $"\nБаллы по физике:{Physics_scores,11}" +
               $"\r\n\nРезултат суммы баллов:{ValueWariableAll,4}" +
               $"\nСреднее арифметическое \nбаллов:{ValueWariableAll2,20}";

            ////Вызвал метод вывода данных в выходной поток компилятора 
            Console.WriteLine(pattern,
                             Fullname,
                             Age,
                             Email,
                             Prog_points,
                             Math_points,
                             Physics_scores);

            /* Console.ReadKey();

             string topLeft = ".1";
             string topRight = ".2";
             string centerText = "Среднее арифметическое баллов:" +(ValueWariableAll2);
             string bottomLeft = ",1";
             string bottomRight = ",2";


             /* Console.Clear();

             Console.Write(topLeft);

             int topRightx = Console.WindowWidth - topRight.Length;

             Console.SetCursorPosition(topRightx,0);

             Console.Write(topRightx);

             int bottomY = Console.WindowWidth - 1;

             Console.SetCursorPosition(0,bottomY);

             Console.Write(bottomLeft);

             int bottomRightX = Console.WindowWidth - bottomRight.Length;

             Console.SetCursorPosition(bottomY,bottomRightX);

             Console.Write(bottomRight);

             int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);

             int centerY = (Console.WindowWidth/2)- 1 ;

             Console.SetCursorPosition(centerX,centerY);

             Console.Write(centerText);

               -сформировать итоговую строку, которую вы хотите центрировать
               -найти ее длину вот так str.Length
               -определить ширину буфера экрана Console.BufferWidth
               -рассчитать X-координату, для вывода посередине: X =  (Console.BufferWidth - str.Length) / 2 (тут возможно придется округлять)
               -перевести курсор в место, где будете печатать Console.SetCursorPosition
               -напечатать Console.WriteLine() 
             */
            //сформировал итоговую строку для  центрирования
            string z = "Среднее арифметическое баллов: " + ValueWariableAll2;

            int str1 = z.Length;

            //рассчитаk X-координату, для вывода посередине
            var x = (Console.BufferWidth - str1)/2;

            var q = Console.BufferHeight / 2;

            //перевести курсор в место, где будете печатать Console.SetCursorPosition
            Console.SetCursorPosition(x,q);

            Console.WriteLine(z);




        }
    }
}
