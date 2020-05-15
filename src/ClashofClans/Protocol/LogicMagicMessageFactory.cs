using System;
using System.Collections.Generic;
using ClashofClans.Protocol.Messages.Client;
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
                {11186, typeof(AskForAvatarProfileMessage)},
                //{11734, typeof()},
                {12906, typeof(EndClientTurnMessage)},
                /*{14401, typeof(AskForAllianceRankingListMessage)},
                {14403, typeof(AskForAvatarRankingListMessage)},
                {14404, typeof(AskForAvatarLocalRankingListMessage)},
                {14715, typeof(SendGlobalChatLineMessage)}*/
                {16203, typeof(DebugEventMessage)},
                {17173, typeof(ChangeAvatarNameMessage)},
            };
        }
    }
}