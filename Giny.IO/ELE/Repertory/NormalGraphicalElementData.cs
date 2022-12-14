using Giny.Core.IO;
using System.ComponentModel;

namespace Giny.IO.ELE.Repertory
{
    public class NormalGraphicalElementData : EleGraphicalData
    {
        private int _Gfx;

        public int Gfx
        {
            get
            {
                return this._Gfx;
            }

            set
            {
                if (this._Gfx == value)
                {
                    return;
                }
                this._Gfx = value;
            }
        }

        private uint _Height;

        public uint Height
        {
            get
            {
                return this._Height;
            }

            set
            {
                if (this._Height == value)
                {
                    return;
                }
                this._Height = value;
            }
        }

        private bool _HorizontalSymmetry;

        public bool HorizontalSymmetry
        {
            get
            {
                return this._HorizontalSymmetry;
            }

            set
            {
                if (this._HorizontalSymmetry == value)
                {
                    return;
                }
                this._HorizontalSymmetry = value;
            }
        }

        public short OriginX
        {
            get;
            set;
        }
        public short OriginY
        {
            get;
            set;
        }

        private System.Drawing.Size _Size;

        public System.Drawing.Size Size
        {
            get
            {
                return this._Size;
            }

            set
            {
                if (this._Size == value)
                {
                    return;
                }
                this._Size = value;
            }
        }

        public override EleGraphicalElementTypes Type
        {
            get
            {
                return EleGraphicalElementTypes.NORMAL;
            }
        }

        public NormalGraphicalElementData(Elements instance, int id)
            : base(instance, id)
        {
        }

        public static NormalGraphicalElementData ReadFromStream(Elements instance, int id, BigEndianReader reader)
        {
            return new NormalGraphicalElementData(instance, id)
            {
                Gfx = reader.ReadInt(),
                Height = reader.ReadByte(),
                HorizontalSymmetry = reader.ReadBoolean(),
                OriginX =reader.ReadShort(),
                OriginY = reader.ReadShort(),
                Size = new System.Drawing.Size((int)reader.ReadShort(), (int)reader.ReadShort())
            };
        }
    }
}