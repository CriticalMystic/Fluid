namespace Fluid.Core
{
    /// <summary>
    /// EventArgs that can be cancelled
    /// </summary>
    public class CancelableEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
    }
}