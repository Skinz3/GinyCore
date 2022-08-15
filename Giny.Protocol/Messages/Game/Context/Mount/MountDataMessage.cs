using System.Collections.Generic;
using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;
using Giny.Protocol;
using Giny.Protocol.Enums;

namespace Giny.Protocol.Messages
{ 
    public class MountDataMessage : NetworkMessage  
    { 
        public  const ushort Id = 391;
        public override ushort MessageId => Id;

        public MountClientData mountData;

        public MountDataMessage()
        {
        }
        public MountDataMessage(MountClientData mountData)
        {
            this.mountData = mountData;
        }
        public override void Serialize(IDataWriter writer)
        {
            mountData.Serialize(writer);
        }
        public override void Deserialize(IDataReader reader)
        {
            mountData = new MountClientData();
            mountData.Deserialize(reader);
        }


    }
}








