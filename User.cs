using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    class User
    {
        public string name = "foo";
        public int age = 0;

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
        }

        public void setInfo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
