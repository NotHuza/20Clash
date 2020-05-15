using System;
using System.Collections.Generic;
using ClashofClans.Protocol.Commands.Client;

namespace ClashofClans.Protocol
{
    public class LogicCommandManager
    {
        public static Dictionary<int, Type> Commands;

        static LogicCommandManager()
        {
            Commands = new Dictionary<int, Type>
            {
                {500, typeof(LogicBuyBuildingCommand)},
                {501, typeof(LogicMoveBuildingCommand)},
                {502, typeof(LogicUpgradeBuildingCommand)},
                {504, typeof(LogicSpeedUpConstructionCommand)},
                {505, typeof(LogicCancelConstructionCommand)},
                {506, typeof(LogicCollectResourcesCommand)},
                {507, typeof(LogicClearObstacleCommand)},
                {519, typeof(LogicMissionProgressCommand)},
                {520, typeof(LogicUnlockBuildingCommand)},
                {521, typeof(LogicFreeWorkerCommand)},
                {523, typeof(LogicCollectAchievementCommand)},
                {526, typeof(LogicBoostBuildingCommand)},
                {532, typeof(LogicNewShopItemsSeenCommand)},
                {533, typeof(LogicMoveMultipleBuildingsCommand)},
                {539, typeof(LogicNewsSeenCommand)},
                {544, typeof(LogicEditModeShownCommand)},
                {549, typeof(LogicUpgradeMultipleBuildingsCommand)},
                {577, typeof(LogicSwapBuildingsCommand)},
                {590, typeof(LogicBuyWallCommand)},
                {591, typeof(LogicSwitchVillageStateCommand)},
                {597, typeof(LogicEventsSeenCommand)},
                {603, typeof(LogicEndCombatCommand)},
                {705, typeof(LogicPlaceHeroCommand)},
                {800, typeof(LogicMatchmakingCommand)}
            };
        }
    }
}