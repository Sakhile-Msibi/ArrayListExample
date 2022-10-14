using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(12.56);
            arrayList.Add("GFG");
            arrayList.Add(null);
            arrayList.Add("G");
            arrayList.Add(1234);

            //arrayList.Sort();

            foreach(var elements in arrayList)
                Console.WriteLine(elements);
        }
    }
}
