using Ryujinx.Graphics.GAL;
using Ryujinx.Graphics.Gpu.Engine.Threed;

namespace Ryujinx.Graphics.Gpu.Shader
{
    /// <summary>
    /// State used by the <see cref="GpuAccessor"/>.
    /// </summary>
    struct GpuChannelGraphicsState
    {
        // New fields should be added to the end of the struct to keep disk shader cache compatibility.

        /// <summary>
        /// Early Z force enable.
        /// </summary>
        public readonly bool EarlyZForce;

        /// <summary>
        /// Primitive topology of current draw.
        /// </summary>
        public readonly PrimitiveTopology Topology;

        /// <summary>
        /// Tessellation mode.
        /// </summary>
        public readonly TessMode TessellationMode;

        /// <summary>
        /// Indicates whenever the viewport transform is disabled.
        /// </summary>
        public readonly bool ViewportTransformDisable;

        /// <summary>
        /// Creates a new GPU graphics state.
        /// </summary>
        /// <param name="earlyZForce">Early Z force enable</param>
        /// <param name="topology">Primitive topology</param>
        /// <param name="tessellationMode">Tessellation mode</param>
        /// <param name="viewportTransformDisable">Indicates whenever the viewport transform is disabled</param>
        public GpuChannelGraphicsState(bool earlyZForce, PrimitiveTopology topology, TessMode tessellationMode, bool viewportTransformDisable)
        {
            EarlyZForce = earlyZForce;
            Topology = topology;
            TessellationMode = tessellationMode;
            ViewportTransformDisable = viewportTransformDisable;
        }
    }
}