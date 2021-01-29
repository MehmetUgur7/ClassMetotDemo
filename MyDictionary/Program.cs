using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDictionary<int, string> StudentList = new MyGenericDictionary<int, string>();
            StudentList.Add(1, "Mehmet Uğur");
            StudentList.Add(2, "Gökhan Kerman");
            StudentList.Add(3, "Erdem Demirel");
            StudentList.Add(4, "Ahmet Tosun");

            StudentList.Items();
        }
    }
}
