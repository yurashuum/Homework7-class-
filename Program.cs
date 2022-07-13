﻿using System;
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
            Console.WriteLine("Нажмите определённую цифру, чтобы выолнить действие");
            Thread.Sleep(1000);
            Console.WriteLine("Чтобы открыть файл -- 1 " +
                "\nЧтобы внести новых пользователей -- 2 " +
                "\nЧтобы удалить пользователей -- 3" +
                "\nЧтобы выйти из программы -- 0");

            while (true)
            {
                Repository repository = new Repository();

                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    string path = @"C:\Users\yura_\Desktop\Проекты(образование)\Homework7(class)\bin\Debug\Справочник.txt";
                    FileInfo fileInfo = new FileInfo(path);
                    if (!fileInfo.Exists)
                    {
                        Console.WriteLine("Файл ещё не создан!");
                    }
                    else
                    {
                        repository.ReadWorker();
                        repository.PrintWorker();
                    }
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
                    Console.WriteLine("Ещё не готово");
                }

                else if (num == 0)
                break;
                
            }
           

         
        }


    }
}
