using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Homework7_class_
{
    public class Repository
    {

        string _fileName = "Справочник.txt";
        public List<Worker> workers { get; private set; }

        /// <summary>
        /// конструктор
        /// </summary>
        public Repository()
        {
            workers = new List<Worker>();
            workers = ReadWorker();
        }

        /// <summary>
        /// присваивание ID
        /// </summary>
        /// <param name="workers"></param>
        /// <returns></returns>
        public static int GetMaxiD(List<Worker> workers)
        {
            if (workers.Count /*!= null & workers.Capacity*/ > 0)
            {
                int maxId = workers.Max(x => x.Id);
                return ++maxId;

            }
            else
            {
                return 0;
            }
            //return workers != null ? workers.Max(x => x.Id) + 1 : 0;
        }

        /// <summary>
        /// считывание файла
        /// </summary>
        /// <returns></returns>
        public List<Worker> ReadWorker()
        {
            FileInfo file1 = new FileInfo(_fileName);
            string path = _fileName;
            if (!file1.Exists)
            {
                File.Create(path);
            }


            using (StreamReader swDirect = new StreamReader(_fileName))
            {

                //    FileInfo file = new FileInfo(_fileName);
                //    string path = _fileName;
                //if (!file.Exists)
                //{
                //    File.Create(path);
                //}
                //else
                //{
                while (swDirect.EndOfStream)
                {
                    string[] args = swDirect.ReadLine().Split('#');
                    foreach (string arg in args)
                    {
                        workers.Add(new Worker(

                            int.Parse(args[0]),
                            DateTime.Parse(args[1]),          //вх строка имела не верный формат
                            args[2],
                            int.Parse(args[3]),
                            int.Parse(args[4]),
                            DateTime.Parse(args[5]),
                            args[6]));
                    }
                }


            }

            return workers;

        }



        /// <summary>
        /// вывод на консоль
        /// </summary>
        public void PrintWorker()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Print());
            }
        }

        /// <summary>
        /// запись в лист
        /// </summary>
        /// <param name="worker"></param>
        public void Addworkers(Worker worker)
        {
            workers.Add(worker);
        }

        /// <summary>
        /// запись в файл
        /// </summary>
        public void Writeworkers()
        {
            using (StreamWriter swDirect = new StreamWriter("Справочник.txt", true, Encoding.UTF8))

                foreach (Worker worker in workers)
                {
                    swDirect.WriteLine($"ID:{worker.Id} # Время:{worker.Addtime} # ФИО:{worker.Fullname} # Возраст:{worker.Age} # Рост:{worker.Height} # Дата рождения:{worker.WasBorn} # Город:{worker.City}\n");
                }
        }


        /// <summary>
        /// Удаление сотрудника по айди
        /// </summary>
        /// <param name="workers"></param>
        /// <param name="Id"></param>
        public void DeleteWorker(List<Worker> workers, int Id)
        {

            var itemToDelete = workers.Where(worker => worker.Id == Id).Select(x => x).First();
            workers.Remove(itemToDelete);
        }

        /// <summary>
        /// Сортировка по дате рождения
        /// </summary>
        public void SortBirthday()
        {
            var SortedWorkers = workers.OrderBy(item => item.WasBorn);

            foreach (var worker in SortedWorkers)
            {
                Console.WriteLine(worker.Print());
            }
                
            Console.WriteLine();
        }

    }
}