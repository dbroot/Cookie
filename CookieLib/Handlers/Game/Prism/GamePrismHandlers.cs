﻿using Cookie.Core;
using Cookie.Protocol.Enums;
using Cookie.Protocol.Network.Messages.Game.Prism;
using Cookie.Utils.Extensions;

namespace Cookie.Handlers.Game.Prism
{
    public class GamePrismHandlers
    {
        [MessageHandler(PrismsListMessage.ProtocolId)]
        private void PrismsListMessageHandler(DofusClient client, PrismsListMessage message)
        {
            //message.Prisms.ForEach(p => Client.Logger.Log($"Prism: Alliance({p.AllianceId}) SubArea({p.SubAreaId})"));
        }

        [MessageHandler(PrismsListUpdateMessage.ProtocolId)]
        private void PrismsListUpdateMessageHandler(DofusClient client, PrismsListUpdateMessage message)
        {
            //
        }
    }
}
