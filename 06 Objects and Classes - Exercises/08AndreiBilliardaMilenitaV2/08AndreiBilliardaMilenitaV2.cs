using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> ShopList { get; set; }
    public decimal Bill { get; set; }
}

class AndreyAndBilliard
{
    static void Main()
    {
        var shop = new Dictionary<string, decimal>();

        int entitiesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < entitiesCount; i++)
        {
            var newEntity = Console.ReadLine().Split('-').ToArray();
            string entityName = newEntity[0];
            decimal entityPrise = decimal.Parse(newEntity[1]);

            if (!shop.ContainsKey(entityName))
            {
                shop.Add(entityName, entityPrise);
            }
            else
            {
                shop[entityName] = entityPrise;
            }
        }

        List<Customer> allCustomers = new List<Customer>();

        string order = Console.ReadLine();
        while (order != "end of clients")
        {
            string[] orderArgs = order.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string product = orderArgs[1];
            if (shop.ContainsKey(product))
            {
                string customerName = orderArgs[0];
                int quantity = int.Parse(orderArgs[2]);
                decimal spent = decimal.Parse(orderArgs[2]) * shop[orderArgs[1]];

                Customer currentCustomer = new Customer();
                currentCustomer.Name = customerName;
                currentCustomer.ShopList = new Dictionary<string, int>();
                currentCustomer.ShopList.Add(product, quantity);
                currentCustomer.Bill = spent;

                if (allCustomers.Any(x => x.Name == currentCustomer.Name))
                {
                    Customer existingCustomer = allCustomers
                        .First(x => x.Name == currentCustomer.Name);

                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                        existingCustomer.Bill += spent;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
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

        decimal totalBill = 0;
        foreach (var customer in allCustomers.OrderBy(x => x.Name))
        {
            Console.WriteLine(customer.Name);
            foreach (var product in customer.ShopList)
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