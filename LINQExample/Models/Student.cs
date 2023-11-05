using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Kita { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Kita:{Kita}";

        }

        /// <summary>
        /// פעולה המחזירה אוסף של תלמידים
        /// </summary>
        /// <returns>רשימת תלמידים</returns>
        public static List<Student> FillList()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student()
            {
                Name = "Ro",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Idan",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Ofek L.",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Shira",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Shai",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Ran",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Aviv",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Shahar O.",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Idan",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Itamar",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Ziv",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Noam",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Noa",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Tami",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Shiri",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Gal",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Ofek R.",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Lynn",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Gil",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Shahar S.",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Ben",
                Kita = 1
            });
            return list;    
        }

    }




}
