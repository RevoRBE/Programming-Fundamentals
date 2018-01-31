using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRICES
            int n = int.Parse(Console.ReadLine());

            var menu = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();
                if (!menu.ContainsKey(input[0]))
                {
                    menu[input[0]] = decimal.Parse(input[1]);
                }
                else
                {
                    menu[input[0]] = decimal.Parse(input[1]);
                }
            }
            //ORDERS
            List<Customer> allCustomers = new List<Customer>();

            string order = Console.ReadLine();
            while (order != "end of clients")
            {
                string[] orderArgs = order.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string product = orderArgs[1];
                if (menu.ContainsKey(product))
                {
                    string customerName = orderArgs[0];
                    int quantity = int.Parse(orderArgs[2]);
                    decimal spent = decimal.Parse(orderArgs[2]) * menu[orderArgs[1]];

                    Customer currentCustomer = new Customer();
                    currentCustomer.Name = customerName;
                    currentCustomer.Purchase = new Dictionary<string, int>();
                    currentCustomer.Purchase.Add(product, quantity);
                    currentCustomer.Bill = spent;

                    if (allCustomers.Any(x => x.Name == currentCustomer.Name))
                    {
                        Customer existingCustomer = allCustomers
                            .First(x => x.Name == currentCustomer.Name);

                        if (existingCustomer.Purchase.ContainsKey(product))
                        {
                            existingCustomer.Purchase[product] += quantity;
                            existingCustomer.Bill += spent;
                        }
                        else
                        {
                            existingCustomer.Purchase[product] = quantity;
                            existingCustomer.Bill += spent;
                        }
                    }
                    else
                    {
                        allCustomers.Add(currentCustomer);
                    }
                }

                order = Console.ReadLine();
            }
            //PRINTING
            decimal totalBill = 0;
            foreach (var customer in allCustomers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.Purchase)
                {
                    Console.WriteLine("-- {0} - {1}",
                        product.Key, product.Value);
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
                totalBill += customer.Bill;
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Purchase = new Dictionary<string, int>();
        public decimal Bill { get; set; }
    }
}