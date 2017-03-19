using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigword.BLL
{
    public class Greeter
    {
        public string GetGreetingWords(string name)
        {
            return string.Format("Hi {0}, welcome to our program!!!", name);
        }
    }
}
