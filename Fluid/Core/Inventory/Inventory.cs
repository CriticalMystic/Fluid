using System;

namespace Fluid.Core
{
    public abstract record Inventory : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
