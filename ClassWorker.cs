using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_class_
{
    public class Worker
    {
        /// <summary>
        /// Айди сотрудника 
        /// </summary> 
        public Guid Id { get; set; }
        /// <summary>
        /// время добавления записи
        /// </summary>
        public DateTime Addtime { get; set; }
        /// <summary>
        /// полное емя
        /// </summary>
        public string Fullname { get; set; }
        /// <summary>
        /// возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// рост
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime WasBorn { get; set; }
        /// <summary>
        /// место рождения
        /// </summary>
        public string City { get; set; }

        public string Print()
        {
            return ($"Айди: {Id} Время добавления записи: {Addtime} ФИО: {Fullname} Возраст: {Age} Рост: {Height} Дата рождения: {WasBorn} Место рождения: {City}");
        }


        #region конструктор
        public Worker(Guid Id, DateTime Addtime, string Fullname, int Age, int Height, DateTime WasBorn, string City)
        {
            this.Id = Id;
            this.Addtime = Addtime;
            this.Fullname = Fullname;
            this.Age = Age;
            this.Height = Height;
            this.WasBorn = WasBorn;
            this.City = City;
        }

        public Worker()
        {      
        }
        #endregion
    }
}
