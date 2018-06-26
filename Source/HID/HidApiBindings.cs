using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;
using Win32Bindings.HID.Defines;
using Win32Bindings.HID.Structs;

namespace Win32Bindings.HID
{
    public static class HidApiBindings
    {
        [DllImport("hid.dll", CharSet = CharSet.Unicode)]
        public static extern HidStatus HidP_GetUsagesEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3), Out] USAGE_AND_PAGE[] ButtonList, ref uint UsageLength, IntPtr PreparsedData, [MarshalAs(UnmanagedType.LPArray)] byte[] Report, uint ReportLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetManufacturerString(SafeFileHandle HidDeviceObject, StringBuilder Buffer, int BufferLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetProductString(SafeFileHandle HidDeviceObject, StringBuilder Buffer, int BufferLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetAttributes(SafeFileHandle HidDeviceObject, ref HIDD_ATTRIBUTES Attributes);

        [DllImport("hid.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetCaps(IntPtr PreparsedData, ref HIDP_CAPS Capabilities);

        [DllImport("hid.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetButtonCaps(HIDP_REPORT_TYPE ReportType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2), Out] HIDP_BUTTON_CAPS[] ButtonCaps, ref ushort ButtonCapsLength, IntPtr PreparsedData);

        [DllImport("hid.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetValueCaps(HIDP_REPORT_TYPE ReportType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2), Out] HIDP_VALUE_CAPS[] ValueCaps, ref ushort ValueCapsLength, IntPtr PreparsedData);

        [DllImport("hid.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetUsageValue(HIDP_REPORT_TYPE ReportType, ushort UsagePage, ushort LinkCollection, ushort Usage, ref uint UsageValue, IntPtr PreparsedData, [MarshalAs(UnmanagedType.LPArray)] byte[] Report, uint ReportLength);
    }
}