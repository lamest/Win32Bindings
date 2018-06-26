using System;
using System.Runtime.InteropServices;
using Win32Bindings.user32.Defines;

namespace Win32Bindings.user32.Structs
{
    /// <summary>
    ///     Contains information about the state of the keyboard.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [CLSCompliant(false)]
    public struct RAWKEYBOARD
    {
        /// <summary>
        ///     The scan code from the key depression. The scan code for keyboard overrun is
        ///     <see cref="KEYBOARD.OVERRUN_MAKE_CODE">KEYBOARD_OVERRUN_MAKE_CODE</see>.
        /// </summary>
        public ushort MakeCode;

        /// <summary>
        ///     Flags for scan code information.
        /// </summary>
        public RI_KEY Flags;

        /// <summary>
        ///     Reserved; must be zero.
        /// </summary>
        public ushort Reserved;

        /// <summary>
        ///     Windows message compatible virtual-key code. For more information, see Virtual Key Codes.
        /// </summary>
        public ushort VKey;

        /// <summary>
        ///     The corresponding window message, for example <see cref="RawHidReading.Win32.WinMessage.WM.KEYDOWN">WM_KEYDOWN</see>,
        ///     <see cref="RawHidReading.Win32.WinMessage.WM.SYSKEYDOWN">WM_SYSKEYDOWN</see>, and so forth.
        /// </summary>
        public /*WM*/ uint Message;

        /// <summary>
        ///     The device-specific additional information for the event.
        /// </summary>
        public uint ExtraInformation;

        /// <summary>
        ///     Size of <see cref="RAWKEYBOARD" /> in bytes.
        /// </summary>
        public static readonly uint SIZE = (uint) Marshal.SizeOf(typeof(RAWKEYBOARD));
    }
}