using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Homework7_class_
{
    public class Repository
    {

        string _fileName = "@Справочник.txt";
        public List<Worker> workers { get; private set; }

        /// <summary>
        /// конструктор
        /// </summary>
        public Repository()
        {
            workers = new List<Worker>();
            workers = ReadWorker();
        }

        public static int GetMaxiD(List<Worker> workers)
        {
            if (workers != null)
            {
                int maxId = workers.Max(x => x.Id);
                return ++maxId;

            }
            else
            {
                return 0;
            }
        }

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

                    FileInfo file = new FileInfo(_fileName);

                    
                    while (!swDirect.EndOfStream)
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
                

                return workers;
            }
            
        }

            
        

        public void PrintWorker()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Print());
            }
        }

        public void Addworkers(Worker worker)
        {
            workers.Add(worker);
        }


        public void Writeworkers()
        {
            using (StreamWriter swDirect = new StreamWriter("Справочник.txt", true, Encoding.UTF8))

                foreach (Worker worker in workers)
                {
                    swDirect.WriteLine($"ID:{worker.Id} # Время:{worker.Addtime} # ФИО:{worker.Fullname} # Возраст:{worker.Age} # Рост:{worker.Height} # Дата рождения:{worker.WasBorn} # Город:{worker.City}\n");
                }
        }

        public void DeleteWorker(List<Worker> workers, int Id)
        {
            var itemToDelete = workers.Where(worker => worker.Id == Id).Select(x => x).First();
            workers.Remove(itemToDelete);
        }



    }
}