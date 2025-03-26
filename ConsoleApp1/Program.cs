using Confluent.Kafka;
using kafkaproduce;
internal class Program
{
    private static IConsumer<string, string> _consumer;

    static void Main(string[] args)
    {
        _consumer = new ConsumerBuilder<string, string>(new)
        {
            GroupId = "test-consumer-gr",
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest
        }).Build();

        _consumer.Subscribe("my-topic")


        while (true)
        {
            var consumeResult = _consumer.Consume();

            System.Console.WriteLine(consumeResult);
        }
    }
}

