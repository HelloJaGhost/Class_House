using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Street
{
    public class House
    {
        public readonly string adress;
        public string nickname;
        public House(string adress, string nickname)
        {
            this.adress = adress;
            this.nickname = nickname;
        }
        public House(string adress)
        {
            this.adress = adress;
        }
        public void Print()
        {
            if (nickname != null)
                Console.WriteLine("{0}", nickname);
            else
            {
                Console.WriteLine("{0}", adress);
            }
            Console.WriteLine();
        }
    }
}
