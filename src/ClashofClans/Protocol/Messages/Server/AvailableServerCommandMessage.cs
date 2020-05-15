using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server
{
    public class AvailableServerCommandMessage : PiranhaMessage
    {
        public AvailableServerCommandMessage(Device device) : base(device)
        {
            Id = 24111;
        }

        public LogicCommand Command { get; set; }

        public override void Encode()
        {
            Writer.WriteInt(Command.Type);
            Writer.WriteBytes(Command.Data);
        }
    }
}