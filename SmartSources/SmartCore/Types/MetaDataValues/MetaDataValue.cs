using System.IO;
using UnityEngine;

namespace Smart.Types.MetaDataValues
{
    public abstract class MetaDataValue
    {
        //--------------------------------------------------------------------------------------------------------------------------

        public abstract bool IsNull();

        public abstract byte GetTypeId();

        internal abstract void WriteData(BinaryWriter bw);

        internal abstract void ReadData(BinaryReader br);

        public abstract MetaDataValue CreateCopy();

        //--------------------------------------------------------------------------------------------------------------------------

        public virtual int AsInteger()
        {
            return 0;
        }

        public virtual float AsFloat()
        {
            return 0;
        }

        public virtual string AsString()
        {
            return "";
        }

        public virtual Color AsColor()
        {
            return Color.white;
        }

        public virtual Vector2 AsVector2()
        {
            return Vector2.zero;
        }

        public virtual Vector3 AsVector3()
        {
            return Vector3.zero;
        }

        public virtual bool AsBoolean()
        {
            return false;
        }

        //--------------------------------------------------------------------------------------------------------------------------
    }
}
