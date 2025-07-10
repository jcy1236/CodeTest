using System.Net.NetworkInformation;

public partial class Function
{
    public static WMXService? _wmxService = null;

    #region WMX_SetOutData

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int addr, int bitOffset, bool data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutBit(addr, bitOffset, (byte)(data ? 1 : 0));
    }

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int alias, int moduleId, int bitOffset, bool data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutBit(alias, moduleId, bitOffset, (byte)(data ? 1 : 0));
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int addr, byte data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutByte(addr, data);
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int alias, int moduleId, byte data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutByte(alias, moduleId, data);
    }

    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int addr, int size, byte[] data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutBytes(addr, size, data);
    }


    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_SetOutData(int alias, int moduleId, int size, byte[] data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetOutBytes(alias, moduleId, size, data);
    }

    #endregion


    #region WMX_GetOutData

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int addr, int bitOffset, out bool data)
    {
        data = false;
        if (_wmxService == null) return false;
        byte byteData;
        bool result = _wmxService.GetOutBit(addr, bitOffset, out byteData);
        data = byteData != 0;
        return result;
    }

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int alias, int moduleId, int bitOffset, out bool data)
    {
        data = false;
        if (_wmxService == null) return false;
        byte byteData;
        bool result = _wmxService.GetOutBit(alias, moduleId, bitOffset, out byteData);
        data = byteData != 0;
        return result;
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int addr, out byte data)
    {
        data = 0;
        if (_wmxService == null) return false;
        return _wmxService.GetOutByte(addr, out data);
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int alias, int moduleId, out byte data)
    {
        data = 0;
        if (_wmxService == null) return false;
        return _wmxService.GetOutByte(alias, moduleId, out data);
    }

    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        if (_wmxService == null) return false;
        return _wmxService.GetOutBytes(addr, size, out data);
    }

    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_GetOutData(int alias, int moduleId, int size, out byte[] data)
    {
        data = new byte[size];
        if (_wmxService == null) return false;
        return _wmxService.GetOutBytes(alias, moduleId, size, out data);
    }

    #endregion


    #region WMX_SetInData

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int addr, int bitOffset, bool data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInBit(addr, bitOffset, (byte)(data ? 1 : 0));
    }

    // bool (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int alias, int moduleId, int bitOffset, bool data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInBit(alias, moduleId, bitOffset, (byte)(data ? 1 : 0));
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int addr, byte data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInByte(addr, data);
    }

    // byte (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int alias, int moduleId, byte data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInByte(alias, moduleId, data);
    }

    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int addr, int size, byte[] data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInBytes(addr, size, data);
    }

    // byte[] (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_SetInData(int alias, int moduleId, int size, byte[] data)
    {
        if (_wmxService == null) return false;
        return _wmxService.SetInBytes(alias, moduleId, size, data);
    }

    #endregion


    #region WMX_GetInData

    // bool
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int addr, int bitOffset, out bool data)
    {
        data = false;
        if (_wmxService == null) return false;
        byte byteData;
        bool result = _wmxService.GetInBit(addr, bitOffset, out byteData);
        data = byteData != 0;
        return result;
    }

    // bool (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int alias, int moduleId, int bitOffset, out bool data)
    {
        data = false;
        if (_wmxService == null) return false;
        byte byteData;
        bool result = _wmxService.GetInBit(alias, moduleId, bitOffset, out byteData);
        data = byteData != 0;
        return result;
    }

    // byte
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int addr, out byte data)
    {
        data = 0;
        if (_wmxService == null) return false;
        return _wmxService.GetInByte(addr, out data);
    }

    // byte (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int alias, int moduleId, out byte data)
    {
        data = 0;
        if (_wmxService == null) return false;
        return _wmxService.GetInByte(alias, moduleId, out data);
    }

    // byte[]
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        if (_wmxService == null) return false;
        return _wmxService.GetInBytes(addr, size, out data);
    }

    // byte[] (alias overload)
    [FunctionCategory("WMX")]
    public static bool WMX_GetInData(int alias, int moduleId, int size, out byte[] data)
    {
        data = new byte[size];
        if (_wmxService == null) return false;
        return _wmxService.GetInBytes(alias, moduleId, size, out data);
    }

    #endregion
}