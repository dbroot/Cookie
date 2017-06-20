﻿using Cookie.Core;
using Cookie.Protocol.Network.Messages.Game.Character.Choice;
using Cookie.Protocol.Network.Types.Game.Character.Choice;

namespace Cookie.Handlers.Game.Character.Choice
{
    public class GameCharacterChoiceHandlers
    {
        [MessageHandler(BasicCharactersListMessage.ProtocolId)]
        private void BasicCharactersListMessageHandler(DofusClient client, BasicCharactersListMessage message)
        {
            CharacterBaseInformations c = message.Characters[0];
            client.Logger.Log("Connexion sur le personnage " + c.Name);
            client.Send(new CharacterSelectionMessage(c.ObjectID));
        }

        [MessageHandler(CharactersListMessage.ProtocolId)]
        private void CharactersListMessageHandler(DofusClient client, CharactersListMessage message)
        {
            CharacterBaseInformations c = message.Characters[0];
            client.Logger.Log("Connexion sur le personnage " + c.Name);
            client.Send(new CharacterSelectionMessage(c.ObjectID));
        }

        [MessageHandler(CharacterSelectedSuccessMessage.ProtocolId)]
        private void CharacterSelectedSuccessMessageHandler(DofusClient client, CharacterSelectedSuccessMessage message)
        {
            client.Account.Character.Level = message.Infos.Level;
            client.Account.Character.Id = message.Infos.ObjectID;
            client.Account.Character.Name = message.Infos.Name;
            client.Account.Character.Sex = message.Infos.Sex;
            client.Account.Character.Look = message.Infos.EntityLook;
            client.Account.Character.Breed = message.Infos.Breed;
        }
        [MessageHandler(CharacterSelectedForceMessage.ProtocolId)]
        private void CharacterSelectedForceMessageHandler(DofusClient client, CharacterSelectedForceMessage message)
        {
           //
        }
    }
}
