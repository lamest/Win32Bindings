/// <summary>
/// Usage Collections are special values from our Usage enumeration.
/// Thus they are also part of the corresponding Usage enumeration.
/// </summary>

namespace Win32Bindings.HID.Defines
{
    /// <summary>
    ///     Usage Collection for usage page GenericDesktopControls.
    /// </summary>
    public enum GenericDesktop : ushort
    {
        Pointer = 0x01,
        Mouse = 0x02,
        Joystick = 0x04,
        GamePad = 0x05,
        Keyboard = 0x06,
        KeyPad = 0x07,
        MultiAxisController = 0x08,
        TabletPCSystemControls = 0x09,
        SystemControl = 0x80
    }

    /// <summary>
    ///     Usage Collection for usage page Consumer.
    /// </summary>
    public enum Consumer : ushort
    {
        ConsumerControl = 0x01,
        NumericKeyPad = 0x02,
        ProgrammableButtons = 0x03,
        Microphone = 0x04,
        Headphone = 0x05,
        GraphicEqualizer = 0x06,
        FunctionButtons = 0x36,
        Selection = 0x80,
        MediaSelection = 0x0087,
        SelectDisc = 0x00BA,
        PlaybackSpeed = 0x00F1,
        Proximity = 0x0109,
        SpeakerSystem = 0x0160,
        ChannelLeft = 0x0161,
        ChannelRight = 0x0162,
        ChannelCenter = 0x0163,
        ChannelFront = 0x0164,
        ChannelCenterFront = 0x0165,
        ChannelSide = 0x0166,
        ChannelSurrond = 0x0167,
        ChannelLowFrequencyEnhancement = 0x0168,
        ChannelTop = 0x0169,
        ChannelUnknown = 0x016A,
        ApplicationLaunchButtons = 0x016A,
        GenericGuiApplicationControls = 0x0200
    }


    public enum WindowsMediaCenter : ushort
    {
        WindowsMediaCenterRemoteControl = 0x88,
        WindowsMediaCenterLowLevel = 0x89
    }
}