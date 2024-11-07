
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using WcfContract;

    namespace WcfClient
    {
        public static class Transfer
        {
            public static ITransferObject Service { get; set; }

                public static void InitializeConnection()
            {
                var serviceAddress = "192.168.3.3:10000";
                var serviceName = "MyService";

                Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
                EndpointAddress address = new EndpointAddress(tcpUri);
                NetTcpBinding clientBinding = new NetTcpBinding();
                clientBinding.Security.Mode = SecurityMode.None;
                ChannelFactory<ITransferObject> factory = new ChannelFactory<ITransferObject>(clientBinding, address);
                Service = factory.CreateChannel();

                //var sum = Service.TestGetSum(4, 7);

                //Console.WriteLine($"sum = {sum}");

                //var rez1 = Service.SentPerson(new WcfContract.PersonDTO { Name = "Vasya1", Surname = "Pupkin" });
                //Console.WriteLine(rez1.Result);
                //Console.WriteLine(Service.FindPerson(new WcfContract.PersonDTO { Name = "Vasya", Surname = "Pupkin" }).Result);

            }
        }
    }

