using System;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServiceConsole
{
    [DataContract(Namespace = "")]
    public class Data
    {
        [DataMember]
        public string Message { get; set; }
    }

    [ServiceContract(Namespace = "")]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/response")]
        [FaultContract(typeof(ErrorDetails))]
        Data GetResponse();
    }

    [DataContract(Namespace = "")]
    public class ErrorDetails
    {
        [DataMember]
        public string ErrorMessage { get; set; }
    }

    public class Service : IService
    {
        public Data GetResponse()
        {
            throw new WebFaultException<ErrorDetails>(
                new ErrorDetails { ErrorMessage = "Server Config Value not set" },
                HttpStatusCode.OK
                );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(Service));
            try
            {
                // request from: http://localhost:8000/SampleService.Service/response
                host.Open();
                Console.WriteLine("Press <ENTER> to terminate");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException cex)
            {
                Console.WriteLine("An exception occurred: {0}", cex.Message);
                host.Abort();
            }
        }
    }
}
