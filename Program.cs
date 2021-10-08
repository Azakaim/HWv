using System;

namespace ConsoleApp1
    {
        class Program
        {
        static void Main(string[] args)
        {

            //Вызвал метод вывода данных в выходной поток компилятора со значением
            //"Введите Ф.И.О.:"

            Console.WriteLine("Введите Ф.И.О.:");

            //присвоил переменной Fullname типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            
            string Fullname = Console.ReadLine();

            //определил переменные
            string Age;

            int ValueWariable;

            Console.WriteLine("Введите возраст:");

            //присвоил переменной Age типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            Age = Console.ReadLine();

            //присвоил переменной ValueWariable типа string значение из перемеенной Age с помощью
            //метода конвертации типов string в тип int 

            ValueWariable = Convert.ToInt32(Age);

           
            Console.WriteLine("Введите Email:");

            //присвоил переменной Email типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            string Email = Console.ReadLine();

            //определил переменные
            string Prog_points;

            double ValueWariable1;

            Console.WriteLine("Введите набранные баллы по информатике:");

            //присвоил переменной Prog_points типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            Prog_points = Console.ReadLine();

            //присвоил переменной ValueWariable1 типа string значение из перемеенной Prog_points с помощью
            //метода конвертации типов string в тип doble 
            ValueWariable1 = Convert.ToDouble(Prog_points);

            //определил переменные
            string Math_points;

            double ValueWariable2;

            Console.WriteLine("Введите набранные баллы по математике:");

            //присвоил переменной Math_points типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            Math_points = Console.ReadLine();

            //присвоил переменной ValueWariable2 типа string значение из перемеенной Math_points с помощью
            //метода конвертации типов string в тип doble
            ValueWariable2 = Convert.ToDouble(Math_points);

            //определил переменные
            string Physics_scores;

            double ValueWariable3;

                  Console.WriteLine("Введите набранные баллы по физике:");

            //присвоил переменной Physics_scores типа string значение с помощью оператора =
            //методом обработки ввода информации пользователем
            Physics_scores = Console.ReadLine();

            //присвоил переменной ValueWariable3 типа string значение из перемеенной Physics_scores с помощью
            //метода конвертации типов string в тип doble
            ValueWariable3 = Convert.ToDouble(Physics_scores);

            //Обьявил переменную под сумму баллов по всем предметам
            //Обьявил переменную под средний балл
            

            double ValueWariableAll, ValueWariableAll2, Sum_points;

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

            Console.ReadKey(); 


        } 
        }
    }
