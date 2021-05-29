namespace Fluid.Core
{
    public class Air : Block
    {
        public override bool Is<T>() => typeof(T) == typeof(Air);
        public override Block Copy() => new Air();
    }
}