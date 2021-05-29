namespace Fluid.Core
{
    public class ShinyTestBlock : Block
    {
        public override bool Is<T>() => typeof(T) == typeof(Air);
        public override Block Copy() => new ShinyTestBlock();
    }
}