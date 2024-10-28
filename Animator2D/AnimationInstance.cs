using System;
using System.Text;

namespace Ankama.Animator2D
{
    internal sealed class AnimationInstance // AnimationInstance = guy
    {
        public readonly string guid; // guid = dgix

        public readonly ushort frameCount; // frameCount = dgiy

        public readonly ushort nodeCount; // nodeCount = dgiz

        public readonly ushort labelCount; // labelCount = dgja

        public readonly Animation.NodeState combinedNodeState; // combinedNodeState = dgjb

        public readonly int[] frameDataPositions; // frameDataPositions = dgjc

        public readonly byte[] bytes; // bytes = dgjd

        public readonly AnimationLabel[] labels; // labels = dgje

        public int referenceCount = 1; // referenceCount = dgjf

        public AnimationInstance(string guid, byte[] bytes)
        {
            // TODO : Probably not the right implementation

            int num1 = 0;
            this.frameCount = BitConverter.ToUInt16(bytes, 0);
            this.nodeCount = BitConverter.ToUInt16(bytes, 2);
            this.labelCount = BitConverter.ToUInt16(bytes, 4);
            this.combinedNodeState = (Animation.NodeState) bytes[6];
            int startIndex = num1 + 8;
            this.labels = new AnimationLabel[(int) this.labelCount];
            if (this.labelCount > (ushort) 0)
            {
                for (int index1 = 0; index1 < (int) this.labelCount; ++index1)
                {
                    int uint16 = (int) BitConverter.ToUInt16(bytes, startIndex);
                    byte count = bytes[startIndex + 2];
                    int index2 = startIndex + 3;
                    string label = Encoding.UTF8.GetString(bytes, index2, (int) count);
                    int num2 = index2 + (int) count;
                    startIndex = num2 + num2 % 2;
                    this.labels[index1] = new AnimationLabel(uint16, label);
                }
                startIndex += startIndex % 4;
            }
            this.frameDataPositions = new int[(int) this.frameCount];
            for (int index = 0; index < (int) this.frameCount; ++index)
            {
                this.frameDataPositions[index] = BitConverter.ToInt32(bytes, startIndex);
                startIndex += 4;
            }
            this.guid = guid;
            this.bytes = bytes;
        }
    }

}