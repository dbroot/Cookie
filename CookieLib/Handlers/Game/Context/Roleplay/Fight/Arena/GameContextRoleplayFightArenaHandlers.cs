﻿using Cookie.Core;
using Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Fight.Arena;

namespace Cookie.Handlers.Game.Context.Roleplay.Fight.Arena
{
    public class GameContextRoleplayFightArenaHandlers
    {
        [MessageHandler(GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage.ProtocolId)]
        private void GameRolePlayArenaUpdatePlayerInfosAllQueuesMessageHandler(DofusClient Client, GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage Message)
        {
            //
        }
        [MessageHandler(GameRolePlayArenaSwitchToFightServerMessage.ProtocolId)]
        private void GameRolePlayArenaSwitchToFightServerMessageHandler(DofusClient Client, GameRolePlayArenaSwitchToFightServerMessage Message)
        {
            //
        }
    }
}
