using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class LoadBalancer
    {
        static LoadBalancer instance;

        List<string> servers = new List<string>();
        Random random = new Random();

        // Lock synchronization object
        private static object locker = new object();


        // Constructor (private)
        private LoadBalancer()
        {
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {

            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked

            if (instance==null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;
        }

        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }

}
