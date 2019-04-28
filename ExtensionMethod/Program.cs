using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "John", Age = 33 };
            var p2 = new Person { Name = "Sally", Age = 35 };
            p.SayHello(p2);

        }
    }


    public static class Extension
    {

        public static void SayHello(this Person person, Person person2)
        {
            Console.WriteLine("{0} says Hello {1}", person.Name, person2.Name);
        }

    }

    

}
