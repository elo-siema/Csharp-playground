using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFTestClient.ServiceReference1;

namespace WCFTestClient
{
    public class Methods
    {
        public Service1Client Client;

       public Methods()
        {
            Client = new Service1Client();
        }

        public string HelloWorld()
        {
            return Client.HelloWorld();
        }

        public string GetValue(int val)
        {
            return Client.GetData(val);
        }

        ~Methods()
        {
            Client.Close();
        }
    }
}
