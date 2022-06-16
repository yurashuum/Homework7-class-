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
        public int MaxId;

        /// <summary>
        /// конструктор
        /// </summary>
       public Repository()
        {
            this.MaxId = 0;
            Load();
            MaxId++;

        }
        public void Load() 
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Ксения\source\repos\Homework7(class)\bin\Debug\Справочник.txt"))
            {



                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');

                    Addworkers(new Worker(int.Parse(args[0]), DateTime.Parse(args[1]), args[2], int.Parse(args[3]), int.Parse(args[4]), DateTime.Parse(args[5]), args[6]));
                    
                }
            }
        }



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