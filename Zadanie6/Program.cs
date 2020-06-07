using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace Zadanie6
{
    class lol
    {
        public class Student

        {
            public string ID;

            public string FIO;

            public string GROUP;

            public string DATA;

        }

        public List<Student> list = new List<Student>();

        public void add(string ID, string FIO, string GROUP, string DATA)

        {
            list.Add(new Student() { ID = ID, FIO = FIO, GROUP = GROUP, DATA = DATA });
        }

        public void remov(string ID)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID) list.RemoveAt(i);
            }
        }

        public void change(string ID, string FIO, string GROUP, string DATA)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID)

                {
                    list[i].FIO = FIO;

                    list[i].GROUP = GROUP;

                    list[i].DATA = DATA;

                }

            }

        }
        public void viv(string ID)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID)

                {
                    Console.WriteLine(list[i].ID + " " + list[i].FIO + " " + list[i].GROUP + " " + list[i].DATA);
                }
            }
        }
        public void year(string ID, int day1, int month1, int yea1)

        {
            int W;
            int P;
            int vozrast;
            string day = "";
            string month = "";
            string year = "";
            string data = "";

            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID)
                {
                    data = list[i].DATA + "";
                }
            }

            W = data.IndexOf(".");
            P = data.LastIndexOf(".");

            for (int i = 0; i < W; i++)
            {
                day = day + data[i];
            }

            for (int i = W + 1; i < P; i++)
            {
                month = month + data[i];
            }

            for (int i = P + 1; i < data.Length; i++)
            {
                year = year + data[i];
            }
            Console.WriteLine("Дата рождения" + day + "." + month + "." + year);
            vozrast = yea1 - ToInt32(year);
            if (ToInt32(month) > month1) vozrast = vozrast - 1;

            else if (ToInt32(month) == month1)
                if (ToInt32(day) < day1) vozrast = vozrast - 1;
            Console.WriteLine("\nВозраст = " + vozrast);
        }


        public void show()

        {
            foreach (var i in list)

            {
                Console.WriteLine(i.ID + " " + i.FIO + " " + i.GROUP + " " + i.DATA);
            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            lol a = new lol();
            WriteLine("1 - Dobavit studenta.\n2 - Izmenit dannye studenta.\n3 - Udalit studenta.\n4 - Vse studenty.");
            int n = ToInt32(ReadLine());
            while (n > 0)
            {
                if (n == 1)

                {
                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.add(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }
                else if (n == 2)

                {
                    WriteLine("Vvod ID i i izmen. dannyh: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.change(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }
                else if (n == 3)

                {
                    WriteLine("Vvod ID: ");

                    string ID = ReadLine();

                    a.remov(ID);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }
                else if (n == 4)

                {
                    a.show();

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }
                else if (n == 5)

                {
                    WriteLine("Vvod ID: ");
                    string ID = ReadLine();
                    a.viv(ID);
                    WriteLine("Vvod deist: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 6)

                {
                    WriteLine("Vvod ID: ");
                    string ID = ReadLine();
                    WriteLine("Vvod Data: ");
                    WriteLine("Day: ");
                    int day = ToInt32(ReadLine());
                    WriteLine("Month: ");
                    int month = ToInt32(ReadLine());
                    WriteLine("Year: ");
                    int year = ToInt32(ReadLine());
                    a.year(ID, day, month, year);
                    WriteLine("Vvod deist: ");
                    n = ToInt32(ReadLine());
                }
            }
        }
    }
}

