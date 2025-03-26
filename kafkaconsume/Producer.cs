using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using MessagePack;
namespace kafkaproduce
{
    public class MsgPackservSerialise<T> : ISerializer<T>
    {
        public byte[] Serialize(T data, SerializationContext context)
        {
            
            return MessagePackSerializer.Serialize(data);
        }
    }

}