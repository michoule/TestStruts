using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Student
    {
        public int Id;
        public string Name;
        public char Sex;
        public int Age;
        public string Phone;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[3];
            for (int i = 0; i < stu.Length; i++)
            {
                stu[i].Id = i + 1;
                Console.WriteLine("请输入学生姓名：");
                stu[i].Name = Console.ReadLine();
                Console.WriteLine("请输入学生性别：");
                stu[i].Sex = char.Parse(Console.ReadLine());
                Console.WriteLine("请输入学生年龄：");
                stu[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入学生联系方式：");
                stu[i].Phone = Console.ReadLine();
            }

            GetStu(stu);

        }
        public static void GetStu(Student[] a)
        {
            Console.WriteLine("序号\t姓名\t性别\t年龄\t联系方式");
            foreach (Student s in a)
            {
                Console.Write(s.Id + "\t" + s.Name + "\t" + s.Sex + "\t" + s.Age + "\t" + s.Phone);
                Console.WriteLine();
            }
        }
    }
}
