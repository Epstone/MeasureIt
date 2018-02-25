using System.Runtime.InteropServices;

namespace PerformanceMeasurement
{
    public static class NativeMethods
    {
        [DllImport("kernel32")]
        internal static extern ulong GetTickCount64();
    }
}