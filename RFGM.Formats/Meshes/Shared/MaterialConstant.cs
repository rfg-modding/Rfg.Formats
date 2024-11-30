using Microsoft.VisualBasic;
using RFGM.Formats.Streams;

namespace RFGM.Formats.Meshes.Shared;

public struct MaterialConstant
{
    public readonly float[] Constants = new float[4];

    public MaterialConstant()
    {
        
    }

    public void Read(Stream stream)
    {
        Constants[0] = stream.Read<float>();
        Constants[1] = stream.Read<float>();
        Constants[2] = stream.Read<float>();
        Constants[3] = stream.Read<float>();
    }
}