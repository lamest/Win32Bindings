using System;

namespace Win32Bindings.user32.Defines
{
    /// <summary>
    ///     Defines the command flag for
    ///     <see
    ///         cref="Win32.IO.RawInput.RawInput.GetRawInputData(System.IntPtr,Win32.IO.RawInput.RID,System.IntPtr,ref uint,uint)" />
    ///     .
    /// </summary>
    [CLSCompliant(false)]
    public enum RID : uint
    {
        /// <summary>
        ///     Get the header information from the <see cref="RawHidReading.Win32.user32.Structs.RAWINPUT" /> structure.
        /// </summary>
        HEADER = 0x10000005,

        /// <summary>
        ///     Get the raw data from the <see cref="RawHidReading.Win32.user32.Structs.RAWINPUT" /> structure.
        /// </summary>
        INPUT = 0x10000003
    }
}