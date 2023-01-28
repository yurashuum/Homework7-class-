using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Homework7_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите определённую цифру, чтобы выолнить действие");
                Thread.Sleep(1000);
                Console.WriteLine("Чтобы открыть файл -- 1 " +
                    "\nЧтобы внести новых пользователей -- 2 " +
                    "\nЧтобы удалить пользователей -- 3" +
                    "\nЧтобы выйти из программы -- 0");


                int num = int.Parse(Console.ReadLine());
                Repository repository = new Repository();

                if (num == 1)
                {

                    repository.ReadWorker();
                    repository.PrintWorker();

                }

                else if (num == 2)
                {

                    Worker worker = new Worker();

                    worker.Id = Repository.GetMaxiD(repository.workers);

                    worker.Addtime = DateTime.Now;

                    Console.WriteLine("Введите Ваше ФИО");
                    worker.Fullname = Console.ReadLine();

                    Console.WriteLine("Введите возраст");
                    string ageInput = Console.ReadLine();
                    int age = 0;
                    while (!int.TryParse(ageInput, out age))
                    {
                        Console.WriteLine("Возраст это число!");
                        ageInput = Console.ReadLine();
                    }
                    worker.Age = age;

                    Console.WriteLine("Введите Рост");
                    string heighInput = Console.ReadLine();
                    int heigh = 0;
                    while (!int.TryParse(heighInput, out heigh))
                    {
                        Console.WriteLine("Рост это число!");
                        heighInput = Console.ReadLine();
                    }
                    worker.Height = heigh;

                    Console.WriteLine("Введите дату рождения");
                    worker.WasBorn = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите место рождения");
                    worker.City = Console.ReadLine();

                    repository.Addworkers(worker);
                    repository.Writeworkers();


                }
                else if (num == 3)
                {

                    
                    repository.ReadWorker();
                    repository.SortBirthday();

                    Console.WriteLine("не Готово");
                }

                else if (num == 0)
                    break;

            }
           

         
        }


    }
}
