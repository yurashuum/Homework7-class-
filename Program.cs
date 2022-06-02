using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework7_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите определённую цифру, чтобы выолнить действие");
            Thread.Sleep(1000);
            Console.WriteLine("Чтобы открыть файл -- 1 \nЧтобы внести новых пользователей -- 2 \nЧтобы удалить пользователей -- 3");


            Repository repository = new Repository();

            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("ещё не готово:(");
            }
            else if (num == 2)
            {
                repository.Addworkers();
            }
            else if (num == 3)
            {
                Console.WriteLine("ещё не готово:(");
            }


           

         
        }


    }
}
