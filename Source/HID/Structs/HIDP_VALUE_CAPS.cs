using System.Runtime.InteropServices;

namespace Win32Bindings.HID.Structs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct HIDP_VALUE_CAPS
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

        [MarshalAs(UnmanagedType.U1)] [FieldOffset(16)]
        public bool HasNull;

        [FieldOffset(17)] public byte Reserved;
        [FieldOffset(18)] public ushort BitSize;
        [FieldOffset(20)] public ushort ReportCount;
        [FieldOffset(22)] public ushort Reserved21;
        [FieldOffset(24)] public ushort Reserved22;
        [FieldOffset(26)] public ushort Reserved23;
        [FieldOffset(28)] public ushort Reserved24;
        [FieldOffset(30)] public ushort Reserved25;
        [FieldOffset(32)] public uint UnitsExp;
        [FieldOffset(36)] public uint Units;
        [FieldOffset(40)] public int LogicalMin;
        [FieldOffset(44)] public int LogicalMax;
        [FieldOffset(48)] public int PhysicalMin;
        [FieldOffset(52)] public int PhysicalMax;
        [FieldOffset(56)] public HIDP_VALUE_CAPS_RANGE Range;
        [FieldOffset(56)] public HIDP_VALUE_CAPS_NOT_RANGE NotRange;
    }
}