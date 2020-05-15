using System;
using System.Threading.Tasks;
using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol
{
    public class PiranhaMessage
    {
        public Device.State RequiredState = Device.State.Home;

        public PiranhaMessage(Device device)
        {
            Device = device;
            Writer = Unpooled.Buffer();
        }

        public PiranhaMessage(Device device, IByteBuffer buffer)
        {
            Device = device;
            Reader = buffer;
        }

        public IByteBuffer Writer { get; set; }
        public IByteBuffer Reader { get; set; }
        public Device Device { get; set; }
        public ushort Id { get; set; }
        public int Length { get; set; }
        public ushort Version { get; set; }
        public bool Save { get; set; }

        public virtual void Decode()
        {
        }

        public virtual void Encode()
        {
        }

        public virtual void Process()
        {
        }

        /// <summary>
        ///     Writes this message to the clients channel
        /// </summary>
        /// <returns></returns>
        public async Task SendAsync()
        {
            try
            {
                await Device.Handler.Channel.WriteAndFlushAsync(this);

                Logger.Log($"[S] Message {Id} ({GetType().Name}) sent.", GetType(), Logger.ErrorLevel.Debug);
            }
            catch (Exception)
            {
                Logger.Log($"Failed to send {Id}.", GetType(), Logger.ErrorLevel.Debug);
            }
        }
    }
}