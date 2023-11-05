using LINQExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample.Data
{
    public class StudentCollection
    {
        public List<Student> Students { get; private set; }

        public StudentCollection()
        {
            Students = new List<Student>(Student.FillList());
          
        }
        public Student FindStudentByName(string name)
        {
            //Find method - used to search a list for specific object
            ////use this delegate as parameter:public delegate bool Predicate<T>(T obj)
            Student? ss = this.Students.Find(x => x.Name == name);

            return ss;
        }

        public Student FindStudentByNameQuery(string name)
        {
            //Find method using a query syntax- used to search a list for specific object
          List<Student> query = (from s in this.Students
                                         where s.Name == name
                                         select s).ToList();
            Student? ss = query.FirstOrDefault();
            return ss;
        }

        public List<Student> GetAllStudentsInCertainKita(int kita)
        {
            //Where method - used to search a list for all objects that match a criteria
            IEnumerable<Student> students = this.Students.Where(s => s.Kita == kita);
            List<Student> studentList = students.ToList();
            return studentList;
        }

       

        public bool IsThereAStudentWithThatName(string name)
        {
            //Any method is a bollean method that checks if an object in the list math a criteria
            bool nameExist = this.Students.Any(s => s.Name == name);
            return nameExist;
        }

        public List<Student> GetStudentsOrderedByKitaAndName()
        {
            //OrderBy and ThenBy Methods are used to sort a list
            List<Student> list =( this.Students.OrderBy(s => s.Kita)
                                                             .ThenByDescending(s => s.Name)).ToList();
           
            return list;
        }

        public List<Student> GetStudentsOrderedByKitaAndNameQuery()
        {
            //OrderBy using a query style laungauge
           List<Student> list = (from s in this.Students
                                                orderby s.Kita, s.Name
                                                select s).ToList();
         
            return list;
        }

       

    }
}
