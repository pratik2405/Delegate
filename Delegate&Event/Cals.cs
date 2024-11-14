using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate_Event
{
    //Syntax:-
    //Access specifier  delegate-keyword return type delegate-name(parameters…)
    //Method syntax & delegate syntax should be same  (syntax – return type, parameters)

    public delegate int MyDelegate(int a, int b);
    public delegate string MyDelegate2(string a);
    public class Cals
    {
        public int Add(int x, int y) 
        {
            return x + y;
        }
        
        public int Sub(int x, int y) 
        {
            return x - y;
        }
        public int Mul(int x, int y) 
        {
            return x * y;
        }
    }

    public class User
    {
        public string ChangeName(string name)
        {
            return name.ToUpper();
        }
    }
}
