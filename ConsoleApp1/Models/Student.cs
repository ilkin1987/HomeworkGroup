using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        private static int No;
        private string _fullname;
        private string _groupno;
        public static string GroupFullNameNumber;

        public Student(string fullname, string groupno)
        {
            FullName = fullname;
            GroupNo = groupno;
        }

        public string FullName
        {
            get
            {
                return _fullname;

            }
            set
            {
                while (!CheckFullName(value))
                {

                    Console.WriteLine("Ad ve Soyadi bitisik yazmaq olmaz!!");
                    value = Console.ReadLine();

                }
                _fullname = value;


            }
        }

        public string GroupNo
        {
            get => _groupno;


            set
            {

                while (!CheckGroupNo(value))
                {


                    Console.WriteLine("Qrup nomrenizi duzgun daxil edin");
                    value = Console.ReadLine();
                }
                _groupno = value;

            }
        }


        public static bool CheckGroupNo(string groupnNo)
        {
            if (groupnNo.Length == 5)
            {
                int count = 0;
                bool check = false;

                if (char.IsUpper(groupnNo[0]))
                {
                    for (int i = 1; i < groupnNo.Length; i++)
                    {
                        if (char.IsDigit(groupnNo[i]))
                        {
                            count++;

                        }
                        else
                        {

                            break;
                        }

                    }
                    if (count == 3)
                    {
                        check = true;
                        return check;

                    }


                }


            }

            return false;

        }

        public static bool CheckFullName(string fullName)
        {
            bool check = false;
            if (fullName.Contains('-'))
            { 
            }
            return check;
        }

        

        }

    }
