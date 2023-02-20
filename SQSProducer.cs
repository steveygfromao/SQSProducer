using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQSProducerDemo
{
    internal class SQSProducer
    {
        public SQSProducer()
        {

        }

        public async Task Send(String message)
        {
            string accessKey = "";
            string secret = "";
            string queueUrl = "";
            string awsregion = "";

            BasicAWSCredentials creds = new BasicAWSCredentials(accessKey, secret);

            RegionEndpoint region = RegionEndpoint.GetBySystemName(awsregion);

            SendMessageRequest sendMessageRequest = new SendMessageRequest(queueUrl, message);

            var sqsClient = new AmazonSQSClient(creds, region);

            await sqsClient.SendMessageAsync(sendMessageRequest);


        }

    }
}
