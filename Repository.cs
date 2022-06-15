using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_class_
{
    public class Repository
    {
        int MaxId;

       

        /// <summary>
        /// конструктор
        /// </summary>
       public Repository()
        {
            this.MaxId = 0;
            
           
        }

       
      
        //public void WorkerID(Worker worker)
        //{
            
        //    string file = @"C:\Users\Ксения\source\repos\Homework7(class)\bin\Debug\Справочник.txt";
        //      FileInfo fileInfo = new FileInfo(file);
        //    if (fileInfo.Exists)
        //    {
        //        using (StreamReader readDirectory = new StreamReader("Справочник.txt"))
        //        {
                    

        //            int[] id = new int[1000];
        //            int newId = id.Max() + 1;

        //            worker.Id = newId;



        //        }

        //    }
        //    else
        //    {
        //        worker.Id = 1;
        //    }
        //}

        

        public void Addworkers(Worker worker)
        {
           

            string file = @"Справочник.txt";
            FileInfo fileInfo = new FileInfo(file);
            
            using (StreamWriter swDirect = new StreamWriter("Справочник.txt", true, Encoding.UTF8))
               
                {

                
                swDirect.WriteLine($"ID:{worker.Id} | Время:{worker.Addtime} | ФИО:{worker.Fullname} | Возраст:{worker.Age} | Рост:{worker.Height} | Дата рождения:{worker.WasBorn} | Место проживания:{worker.City}\n");

            }
        }

        public void DeleteWorker(int id) 
        {

        }

        //public void readFile()
        //{

        //    string file = @"C:\Users\Ксения\source\repos\Homework7(class)\bin\Debug\Справочник.csv";
        //    FileInfo fileInfo = new FileInfo(file);
        //    if (fileInfo.Exists)

        //    {

        //        using (StreamReader readDirectory = new StreamReader("Справочник.csv"))
        //        {

        //            while (!readDirectory.EndOfStream)
        //            {
        //                List<Worker> elements = new List<Worker>();
        //                Console.WriteLine(Int32.Parse(elements[0]), DateTime.Now.Parse(elements[1]), elements[2], Int32.Parse(elements[3]), Int32.Parse(elements[4]), DateTime.Parse(elements[5]), elements[6]);
        //            }


        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine($"Файл отстутвует");
        //    }
        //}


        //public void removeWorkers()
        //{
        //    List<Worker> workers = new List<Worker>();
           
        //}
    }

}
//List<Worker> workers = new List<Worker>();



//{

//    //workers.Add(new Worker() { Id = Guid.NewGuid() });
//    //workers.Add(new Worker() { Addtime = DateTime.Now });
//    //Console.WriteLine("Введите своё ФИО");
//    //workers.Add(new Worker() { Fullname = (Console.ReadLine()) });
//    //Console.WriteLine("Введите свой возраст");
//    //workers.Add(new Worker() { Age = int.Parse(Console.ReadLine()) });
//    //Console.WriteLine("Введите свой рост");
//    //workers.Add(new Worker() { Height = int.Parse(Console.ReadLine()) });
//    //Console.WriteLine("Введите свою дату рождения");
//    //workers.Add(new Worker() { WasBorn = DateTime.Parse(Console.ReadLine()) });
//    //Console.WriteLine("Введите своё место рождения");
//    //workers.Add(new Worker() { City = Console.ReadLine() }); 
//    workers.Add(new Worker()
//    {
//       Id = int.Parse(Console.ReadLine()),
//        Addtime = DateTime.Now,
//       //Console.WriteLine("Введите своё ФИО"),
//        Fullname = Console.ReadLine(),
//        //Console.WriteLine("Введите свой возраст"),
//    Age = int.Parse(Console.ReadLine()),
//         //Console.WriteLine("Введите свой рост"),
//    Height = int.Parse(Console.ReadLine()),
//        //Console.WriteLine("Введите свою дату рождения"),
//    WasBorn = DateTime.Parse(Console.ReadLine()),
//         //Console.WriteLine("Введите своё место рождения"),
//    City = Console.ReadLine()
//    });

//}


//for (int i = 0; i < workers.Count; i++)
//{
//swDirect.WriteLine($"{workers[i].Id}  {workers[i].Addtime}  {workers[i].Fullname}  {workers[i].Age}  {workers[i].Height}  {workers[i].WasBorn}  {workers[i].City}");
//}