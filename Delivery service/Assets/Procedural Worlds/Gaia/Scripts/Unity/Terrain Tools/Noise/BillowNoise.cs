#if UNITY_EDITOR
using System.Collections.Generic;


namespace Gaia
{
    /// <summary>
    /// A NoiseType implementation for Billow noise
    /// </summary>
    [System.Serializable]
    public class BillowNoise : NoiseType<BillowNoise>
    {
        private static NoiseTypeDescriptor desc =  new NoiseTypeDescriptor()
        {
            name = "Billow",
            outputDir = "Assets/Procedural Worlds/Gaia/Shaders/Unity/Terrain Tools/NoiseLib",
            sourcePath = "Assets/Procedural Worlds/Gaia/Shaders/Unity/Terrain Tools/NoiseLib/Implementation/BillowImpl.hlsl",
            supportedDimensions = NoiseDimensionFlags._1D | NoiseDimensionFlags._2D | NoiseDimensionFlags._3D,
            inputStructDefinition = null
            // inputStructDefinition = new List<HlslInput>()
            // {
            //     new HlslInput() { name = "scale", valueType = HlslValueType.Float4, float4Value = new HlslFloat4(1,1,1,1) }
            // }
        };

        public override NoiseTypeDescriptor GetDescription() => desc;
    }
}
#endif