using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDesignPatternExample_01_03_22
{
    public class TableServer
    {
        //Yapacağımız uygulamada bir sınıfımızdan sadece bir nesne oluşturmak istiyorsak kullanılır. Singletone sayesinde ikinci bir nesne oluşturulmaz.

        private static readonly TableServer _instance = new TableServer();
        private List<string> servers = new List<string>();
        private int nextserver = 0;
        private TableServer()
        {
            servers.Add("Tim");
            servers.Add("Bob");
            servers.Add("John");
            servers.Add("Mary");
            servers.Add("Sue");
        }
        public static TableServer GetTableServer()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextserver];
            nextserver++;
            if(nextserver >= servers.Count)
            {
                nextserver = 0;
            }
            return output;
        }
    }
}
