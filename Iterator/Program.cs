using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection collection = new MyCollection();
            collection[0] = new MyItem("Item 0");
            collection[1] = new MyItem("Item 1");
            collection[2] = new MyItem("Item 2");
            collection[3] = new MyItem("Item 3");
            collection[4] = new MyItem("Item 4");
            collection[5] = new MyItem("Item 5");
            collection[6] = new MyItem("Item 6");
            collection[7] = new MyItem("Item 7");
            collection[8] = new MyItem("Item 8");

            // It's a simple Iterator,using yield
            int setp = 2;
            foreach(var item in EvenSequence(collection, setp))
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
        public static System.Collections.Generic.IEnumerable<MyItem> EvenSequence(MyCollection _collection,int step)
        {
            // Yield even numbers in the range.
            for (int index = 0; index <= _collection.Count; index= index+step)
            {
                if (index % 2 == 0)
                {
                    yield return _collection[index] as MyItem;
                }
            }
        }
    }
}
