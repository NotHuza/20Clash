using System;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Analyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hex = "";
            hex = hex.Replace(" ", string.Empty);

            var buffer = Unpooled.Buffer();
            buffer.WriteHex(hex);

            buffer.SetReaderIndex(0);

            //DecodeHeader(buffer);

            /*for(var i = 0; i < 97; i++)
                Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");*/

            //DecodeLogicClientHome(buffer);
            //DecodeLogicClientAvatar(buffer);

            buffer.DiscardReadBytes();
            Console.WriteLine(BitConverter.ToString(buffer.ReadBytes(buffer.ReadableBytes).Array).Replace("-", string.Empty));

            Console.Read();
        }

        public static void DecodeHeader(IByteBuffer buffer)
        {
            Console.WriteLine("--HEADER--");
            Console.WriteLine($"ID:      {buffer.ReadShort()}");
            Console.WriteLine($"Length:  {buffer.ReadMedium()}");
            Console.WriteLine($"Version: {buffer.ReadShort()}");
            Console.WriteLine("--HEADER END--");
        }

        public static void DecodeLogicClientAvatar(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadLong());

            Console.WriteLine(buffer.ReadByte()); // HasAlliance

            Console.WriteLine("--ALLIANCE--");
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt()); // Badge
            Console.WriteLine(buffer.ReadInt()); // Members
            Console.WriteLine(buffer.ReadInt()); // Members

            Console.WriteLine(buffer.ReadByte());
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine("--ALLIANCE END--");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt()); // Exp Level
            Console.WriteLine(buffer.ReadInt()); // Exp Points

            Console.WriteLine(buffer.ReadInt()); // Diamonds
            Console.WriteLine(buffer.ReadInt()); // Diamonds

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt()); // Trophies
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt()); // Clan Castle Gold
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadByte());

            Console.WriteLine(buffer.ReadInt());
        }

        public static void DecodeLogicClientHome(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadLong());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt()); // 14400

            Console.WriteLine(buffer.ReadCompressedString());
            Console.WriteLine(buffer.ReadCompressedString());
            Console.WriteLine(buffer.ReadCompressedString());
        }

        public static void DecodeLoginOk(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadByte());
            Console.WriteLine(buffer.ReadByte());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
        }
    }
}
