using LINQExample.Extentions;
using LINQExample.Models;
using LINQ;

namespace LINQExample
{
    internal class Program
    {

        //פעולה גנרית שתחזיר רשימה של עצמים שעונים על תנאי כלשהו מהרשימה
        public static List<T> Where<T>(List<T> list, Func<T,bool> condition)
        {
            List<T> result=new List<T>();//רשימה שתוחזר

            for (int i = 0; i < list.Count; i++)
                if (condition(list[i]))
                    result.Add(list[i]);
            return result;  
            
            
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students = Student.FillList();

            int i = 4;
            string str = "Talsi";
            //using Extension----> see ExtentionClass how to implement
            i.Gaza();
            str.Gaza();
            students.Gaza();
            List<char> integers = new List<char>();
            integers.Add('1') ;
            integers.Add('2');
         char a=   integers.Where(x => x ==0).FirstOrDefault();


        }
    }
}