using System.Runtime.InteropServices;

namespace Win32Bindings.HID.Structs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct HIDP_BUTTON_CAPS
    {
        [FieldOffset(0)] public ushort UsagePage;
        [FieldOffset(2)] public byte ReportID;

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(3)]
        public bool IsAlias;

        [FieldOffset(4)] public ushort BitField;
        [FieldOffset(6)] public ushort LinkCollection;
        [FieldOffset(8)] public ushort LinkUsage;
        [FieldOffset(10)] public ushort LinkUsagePage;

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(12)]
        public bool IsRange;

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(13)]
        public bool IsStringRange;

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(14)]
        public bool IsDesignatorRange;

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(15)]
        public bool IsAbsolute;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)] [FieldOffset(16)]
        public uint[] Reserved;

        [FieldOffset(56)] public HIDP_BUTTON_CAPS_RANGE Range;
        [FieldOffset(56)] public HIDP_BUTTON_CAPS_NOT_RANGE NotRange;
    }
}