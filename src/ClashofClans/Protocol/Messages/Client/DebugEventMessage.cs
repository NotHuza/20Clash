using System;
using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client
{
    public class DebugEventMessage : PiranhaMessage
    {
        public DebugEventMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public override void Decode()
        {
            Console.WriteLine(Reader.ReadScString());
            Console.WriteLine(Reader.ReadScString());
        }
    }
}