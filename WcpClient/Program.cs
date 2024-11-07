
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using WcfContract;

    namespace WcfClient
    {
        class Program
        {
            static void Main(string[] args)
            {
                var serviceAddress = "192.168.3.3:10000";
                var serviceName = "MyService";

                Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
                EndpointAddress address = new EndpointAddress(tcpUri);
                NetTcpBinding clientBinding = new NetTcpBinding();
                clientBinding.Security.Mode = SecurityMode.None;
                ChannelFactory<ITransferObject> factory = new ChannelFactory<ITransferObject>(clientBinding, address);
                var service = factory.CreateChannel();

                var sum = service.TestGetSum(4, 7);

                Console.WriteLine($"sum = {sum}");

                var rez1 = service.SentPerson(new WcfContract.PersonDTO { Name = "Vasya1", Surname = "Pupkin" });
                Console.WriteLine(rez1.Result);
                Console.WriteLine(service.FindPerson(new WcfContract.PersonDTO { Name = "Vasya", Surname = "Pupkin" }).Result);

            Console.ReadKey();
            }
        }
    }

