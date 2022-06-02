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

        public void Addworkers()
        {
            string file = @"Справочник.txt";
            FileInfo fileInfo = new FileInfo(file);
            
            using (StreamWriter swDirect = new StreamWriter("Справочник.txt", true, Encoding.UTF8))
            {

                List<Worker> workers = new List<Worker>();

               
                {
                    
                    new Worker() { Id = Guid.NewGuid() };
                    workers.Add(new Worker() { Addtime = DateTime.Now });
                    Console.WriteLine("Введите своё ФИО");
                    new Worker() {  Fullname = (Console.ReadLine()) };
                    Console.WriteLine("Введите свой возраст");
                    new Worker() { Age = int.Parse(Console.ReadLine()) };
                    Console.WriteLine("Введите свой рост");
                    new Worker() { Height = int.Parse(Console.ReadLine()) };
                    Console.WriteLine("Введите свою дату рождения");
                    new Worker() { WasBorn = DateTime.Parse(Console.ReadLine()) };
                    Console.WriteLine("Введите своё место рождения");
                    new Worker() { City = (Console.ReadLine()) };
                }

                    
                    for (int i = 0; i < workers.Count; i++)
                    {
                    swDirect.WriteLine($"{workers[i].Id}  {workers[i].Addtime}  {workers[i].Fullname}  {workers[i].Age}  {workers[i].Height}  {workers[i].WasBorn}  {workers[i].City}");
                    }
                    


                

            }
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
