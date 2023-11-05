using LINQExample.Extentions;
using LINQExample.Models;
using LINQ;

namespace LINQExample
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students = Student.FillList();
           
    }
}