using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve Soyad");

            string fullname = Console.ReadLine();

            Console.WriteLine("Qrup Nomresi");

            string groupno = Console.ReadLine();

            Student stud = new Student(fullname, groupno);

            Console.WriteLine(Student.GroupFullNameNumber);

        }
    }
    }
