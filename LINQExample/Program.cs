using LINQExample.Extentions;
using LINQExample.Models;

namespace LINQExample
{
    internal class Program
    {

        public static List<T> Where<T>(List<T> stu, Func<T,bool> condition)
        {
            List<T> students   = new List<T>();
            foreach (T student in stu)
            {
                if(condition(student))
                    students.Add(student);
            }
            return students;
        }
        static void Main(string[] args)
        {
            List<Student> students = Student.FillList();
            List<Student> AllFromKita1 = Where(students, ((x) =>  x.Kita == 1));
            string str = "";
            int i = 4;
            i.Gaza();
            str.Gaza();
        }
    }
}