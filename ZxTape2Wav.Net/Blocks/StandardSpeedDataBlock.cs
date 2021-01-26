using System.IO;

namespace ZxTape2Wav.Blocks
{
    internal class StandardSpeedDataBlock : DataBlock
    {
        public StandardSpeedDataBlock(BinaryReader reader) : base(reader)
        {
        }

        protected StandardSpeedDataBlock()
        {
        }

        protected override void LoadData(BinaryReader reader)
        {
            TailMs = reader.ReadUInt16();
            base.LoadData(reader);
        }
    }
}