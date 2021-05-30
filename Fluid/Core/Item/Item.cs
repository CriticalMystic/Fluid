using System;

namespace Fluid.Core
{
    public abstract record Item : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}