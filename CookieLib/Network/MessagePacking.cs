﻿using Cookie.IO;

namespace Cookie
{
    public class MessagePacking
    {
        private const byte BIT_RIGHT_SHIFT_LEN_PACKET_ID = 2;
        private const byte BIT_MASK = 3;
        private uint _instanceId = 0;

        public void Pack(NetworkMessage message, ICustomDataOutput writer)
        {
            var methode = message.GetType().GetMethod("Serialize");
            methode.Invoke(message, new object[1] { writer });
            WritePacket(writer, message);
        }
        public void Pack(int id, ICustomDataOutput writer)
        {
            WritePacket(writer, id);
        }
        private void WritePacket(ICustomDataOutput writer, NetworkMessage message)
        {
            var packet = writer.Data;

            writer.Clear();

            var typeLen = ComputeTypeLen(packet.Length);
            var id = message.GetType().GetProperty("MessageID").GetValue(message);

            var header = (short)SubComputeStaticHeader((uint)id, typeLen);
            writer.WriteShort(header);

            writer.WriteUInt(_instanceId++);

            switch (typeLen)
            {
                case 0:
                    break;
                case 1:
                    writer.WriteByte((byte)packet.Length);
                    break;
                case 2:
                    writer.WriteShort((short)packet.Length);
                    break;
                case 3:
                    writer.WriteByte((byte)(packet.Length >> 16 & 255));
                    writer.WriteShort((short)(packet.Length & 65535));
                    break;
                default:
                    throw new System.Exception("Packet's length can't be encoded on 4 or more bytes");
            }
            writer.WriteBytes(packet);
        }

        private void WritePacket(ICustomDataOutput writer, int id)
        {
            byte[] packet = writer.Data;

            writer.Clear();

            byte typeLen = ComputeTypeLen(packet.Length);

            var header = (short)SubComputeStaticHeader((uint)id, typeLen);
            writer.WriteShort(header);

            switch (typeLen)
            {
                case 0:
                    break;
                case 1:
                    writer.WriteByte((byte)packet.Length);
                    break;
                case 2:
                    writer.WriteShort((short)packet.Length);
                    break;
                case 3:
                    writer.WriteByte((byte)(packet.Length >> 16 & 255));
                    writer.WriteShort((short)(packet.Length & 65535));
                    break;
                default:
                    throw new System.Exception("Packet's length can't be encoded on 4 or more bytes");
            }
            writer.WriteBytes(packet);
        }
        private static byte ComputeTypeLen(int param1)
        {
            if (param1 > 65535)
                return 3;

            if (param1 > 255)
                return 2;

            if (param1 > 0)
                return 1;

            return 0;
        }

        private static uint SubComputeStaticHeader(uint id, byte typeLen)
        {
            return id << BIT_RIGHT_SHIFT_LEN_PACKET_ID | typeLen;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
