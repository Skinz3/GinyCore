using Giny.Core.IO;
using System.ComponentModel;

namespace Giny.IO.ELE.Repertory
{
    public class BlendedGraphicalElementData : NormalGraphicalElementData
    {


        private string _BlendMode;

        public string BlendMode
        {
            get
            {
                return this._BlendMode;
            }

            set
            {
                if (string.Equals(this._BlendMode, value))
                {
                    return;
                }
                this._BlendMode = value;

            }
        }

        public override EleGraphicalElementTypes Type
        {
            get
            {
                return EleGraphicalElementTypes.BLENDED;
            }
        }

        public BlendedGraphicalElementData(Elements instance, int id)
            : base(instance, id)
        {
        }

        public new static BlendedGraphicalElementData ReadFromStream(Elements instance, int id, BigEndianReader reader)
        {
            return new BlendedGraphicalElementData(instance, id)
            {
                Gfx = reader.ReadInt(),
                Height = reader.ReadByte(),
                HorizontalSymmetry = reader.ReadBoolean(),
                OriginX = reader.ReadShort(),
                OriginY = reader.ReadShort(),
                Size = new System.Drawing.Size((int)reader.ReadShort(), (int)reader.ReadShort()),
                BlendMode = reader.ReadUTF7BitLength()
            };
        }
    }
}