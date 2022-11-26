using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class manager
    {
        public static readonly manager INSTANCE = new manager();
        Hashtable managerArr = new Hashtable();
        private manager() { }

        public void LoadTable()
        {
            int num;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 1000; i++)
            {
                num = rand.Next(100, 9999);
                if ((num % 2) == 0)
                {
                    Falafel f = new Falafel();
                    f.id = num;
                    f.NumberOfBalls = rand.Next(1, 5);
                    if(!managerArr.ContainsKey(f.id))
                    {
                        managerArr.Add(f.id, f);
                    }
                }
                else
                {
                    IceCream ic = new IceCream();
                    ic.id = num;
                    ic.NumberOfBalls = rand.Next(1, 5);
                    if(!managerArr.ContainsKey(ic.id))
                    {
                        managerArr.Add(ic.id, ic);
                    }
                }
            }
            for (int i = 1; i < 20; i++)
            {
                int check;
                Console.WriteLine("Please enter a number between 100 to 9999");
                check = Convert.ToInt32(Console.ReadLine());
                if(managerArr.ContainsKey(check))
                {
                    if(managerArr[check] is IceCream)
                    {
                        IceCream ic = (IceCream) managerArr[check];
                        Console.WriteLine("This Ice-Cream has " + ic.NumberOfBalls + " Balls");
                    }
                    else {
                        Falafel f = (Falafel)managerArr[check];
                        Console.WriteLine("This Falafel has " + f.NumberOfBalls + " Balls");
                    }
                }
            }
        }
    }
}
