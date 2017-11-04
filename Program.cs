using System;
using System.Collections.Generic;

namespace whatever
{
    class Program
    {
        static void Main(string[] args)
        {

            customer customer1 = new customer();
            customer1.ID = 101;
            customer1.name = "Mark";

            customer customer2 = new customer();
            customer2.ID = 102;
            customer2.name = "John";

            customer customer3 = new customer();
            customer3.ID = 103;
            customer3.name = "Sally";

            customer customer4 = new customer();
            customer4.ID = 104;
            customer4.name = "Mary";

            customer customer5 = new customer();
            customer5.ID = 105;
            customer5.name = "Daniel";

            Queue<customer> queueOfCustomers = new Queue<customer>();
            queueOfCustomers.Enqueue(customer1);
            queueOfCustomers.Enqueue(customer2);
            queueOfCustomers.Enqueue(customer3);
            queueOfCustomers.Enqueue(customer4);
            queueOfCustomers.Enqueue(customer5);

            foreach(customer c in queueOfCustomers)
            {
                Console.WriteLine("{0} - {1}",c.ID,c.name);
            }

            Console.WriteLine("");

            customer b = queueOfCustomers.Peek();
            Console.WriteLine("{0} - {1}",b.ID,b.name);

            Console.WriteLine("");
            customer c1 = queueOfCustomers.Dequeue(); //remove the first member 
            foreach (customer a in queueOfCustomers)
            {
                Console.WriteLine("{0} - {1}", a.ID, a.name);
            }


            Console.WriteLine("");

            Console.WriteLine("Total number {0}",queueOfCustomers.Count);

            if (queueOfCustomers.Contains(customer1))
            {
                Console.WriteLine("customer exist");
            }
            else
            {
                Console.WriteLine("Customer doesnot exist");
            }



            Console.ReadKey();
        }
    }

    class customer
    {
        public int ID { get; set; }
        public string name { get; set; }
       
    }
        
}
