using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();

            sehirler.Add(34, "İstanbul");
            sehirler.Add(44, "Malatya");
            sehirler.Add(23, "Elazığ");
            sehirler.Add(06, "Ankara");
            
        }
    }
}
