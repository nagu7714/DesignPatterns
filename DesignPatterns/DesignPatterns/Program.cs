using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void InvokeFactory()
        {
           // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }

        static void InvokePrototype()
        {
            InvitationCard obj1 = new InvitationCard();
            obj1.p_To = "Ram";
            obj1.p_Title = "My birthday invitation";
            obj1.p_content = "Hey guys !! I am throwing a cheers party in my home";
            obj1.SendBy = "Sourav";
            obj1.p_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //Here our first object has created  
            InvitationCard[] objList = new InvitationCard[5];
            String[] nameList = { "Ram", "Shyam", "Hari", "Tapan", "Sukant" };
            int i = 0;
            foreach (String name in nameList)
            {               
                objList[i] = obj1.CloneMe(obj1);
                objList[i].p_To = nameList[i];
                i++;
            }
            // Print all Invitation Card here  
            foreach (InvitationCard obj in objList)
            {
                Console.WriteLine("To :- " + obj.p_To);
                Console.WriteLine("Title :- " + obj.p_Title);
                Console.WriteLine("Content :- " + obj.p_content);
                Console.WriteLine("Send By :- " + obj.p_SendBy);
                Console.WriteLine("Date :- " + obj.Date);
                Console.WriteLine("\n");
            }
        }

       static void InvokeFacade()
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }

        static void InvokeDecorator()
        {
            // Create ConcreteComponent and two Decorators
            var compoment = new ConcreteComponent();
            compoment.Operation();

            var decorateA = new ConcreteDecoratorA(compoment);

            decorateA.Operation();

            var decorateB = new ConcreteDecoratorB(compoment);

            decorateB.Operation();
        }

        static void InvokeProxy()
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();
            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }

        static void InvokeSingleton()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();
            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

        }

        static void InvokeStrategy()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
        static void Main(string[] args)
        {
            //InvokeFacade();

            //InvokeFactory();

            //InvokePrototype();

            //InvokeDecorator();

            //InvokeProxy();

            //InvokeSingleton();

            InvokeStrategy();

            Console.ReadKey();
        }
    }
}
