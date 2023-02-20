using System;
using System.Threading.Tasks;

namespace SQSProducerDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var message = "New Message for " + DateTime.Now.ToString();

            SQSProducer sqsMessageProducer = new SQSProducer();

            await sqsMessageProducer.Send(message);

            Console.WriteLine("Message Sent: " + message);
        }

    }
}