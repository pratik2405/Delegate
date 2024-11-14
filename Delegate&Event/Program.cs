using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    internal class Program
    {
        //Delegates are reference type.
        //Delegate used to hold an reference of method
        //Single cast delegate  → One delegate hold one method reference
        //Multicast delegate  → One delegate hold multiple method references
        static void Main(string[] args)
        {
            Cals c=new Cals();

            MyDelegate obj = new MyDelegate(c.Add);
            // += used to append reference obj in invocation list
            // -= used to remove reference obj from invocation list
            obj += new MyDelegate(c.Sub); //add delegate and create multi cast delegate
            obj += new MyDelegate(c.Mul);

            //int result = obj.Invoke(20, 10); //Invoke is used to run single cast delegate
            //Console.WriteLine(result);

            // Delegate will create the invocationList 
            // invocationList hold methods refer in the same sequence that we have added
            // basic need of multicast delegate is --> to invoke methods in a sequence.
            Delegate[] list = obj.GetInvocationList();
            foreach (Delegate item in list) 
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(30,20));
            }

            //User class

            User u= new User();
            MyDelegate2 obj2 = new MyDelegate2(u.ChangeName);

            string str=obj2.Invoke("pratik");
            Console.WriteLine(str);
        }
    }
}