using System;
using System.Collections.Generic;
using ClashofClans.Protocol.Messages.Client;
using ClashofClans.Protocol.Messages.Client.Alliance;
using ClashofClans.Protocol.Messages.Client.Home;
using ClashofClans.Protocol.Messages.Client.Login;

namespace ClashofClans.Protocol
{
    public class LogicMagicMessageFactory
    {
        public static Dictionary<int, Type> Messages;

        static LogicMagicMessageFactory()
        {
            Messages = new Dictionary<int, Type>
            {
                {10100, typeof(ClientHelloMessage)},
                {10101, typeof(LoginMessage)},
                {10108, typeof(KeepAliveMessage)},
                //{10113, typeof(SetDeviceTokenMessage)},
                /*{10905, typeof(NewsSeenMessage)},*/
                //{14101, typeof(GoHomeMessage)},
                {11186, typeof(AskForAllianceDataMessage)},
                {11734, typeof(AskForAvatarProfileMessage)},
                {12906, typeof(EndClientTurnMessage)},
                // 13708 - Contains a key
                /*{14401, typeof(AskForAllianceRankingListMessage)},
                {14403, typeof(AskForAvatarRankingListMessage)},
                {14404, typeof(AskForAvatarLocalRankingListMessage)},*/
                {14466, typeof(ChatToAllianceStreamMessage)},
                {16203, typeof(DebugEventMessage)},
                {17173, typeof(ChangeAvatarNameMessage)},
            };
        }
    }
}