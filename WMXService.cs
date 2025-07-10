using System.Runtime.InteropServices;

public class WMXService
{
    private IWMXApiClient? _client = null;

    public bool SetInBit(int addr, int bit, byte data)
    {
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }
        return (_client.SetInBit(addr + byteOffset, bit, data) == 0);
    }

    public bool SetInBit(int alias, int moduleId, int bit, byte data)
    {
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }

        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.SetInBit(startAddr + byteOffset, bit, data) == 0);
    }

    public bool SetInByte(int addr, byte data)
    {
        if (_client == null) return false;
        return (_client.SetInByte(addr, data) == 0);
    }

    public bool SetInByte(int alias, int moduleId, byte data)
    {
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.SetInByte(startAddr, data) == 0);
    }

    public bool SetInBytes(int addr, int size, byte[] data)
    {
        if (_client == null) return false;
        return (_client.SetInBytes(addr, size, data) == 0);
    }

    public bool SetInBytes(int alias, int moduleId, int size, byte[] data)
    {
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.SetInBytes(startAddr, size, data) == 0);
    }

    public bool SetOutBit(int addr, int bit, byte data)
    {
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }

        return (_client.SetOutBit(addr + byteOffset, bit, data) == 0);
    }

    public bool SetOutBit(int alias, int moduleId, int bit, byte data)
    {
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }

        int startAddr = _client.GetOutAddress(alias, moduleId);

        if (startAddr < 0) return false;
        return (_client.SetOutBit(startAddr + byteOffset, bit, data) == 0);
    }

    public bool SetOutByte(int addr, byte data)
    {
        if (_client == null) return false;

        return (_client.SetOutByte(addr, data) == 0);
    }

    public bool SetOutByte(int alias, int moduleId, byte data)
    {
        if (_client == null) return false;

        int startAddr = _client.GetOutAddress(alias, moduleId);

        if (startAddr < 0) return false;
        return (_client.SetOutByte(startAddr, data) == 0);
    }

    public bool SetOutBytes(int addr, int size, byte[] data)
    {
        if (_client == null) return false;

        return (_client.SetOutBytes(addr, size, data) == 0);
    }

    public bool SetOutBytes(int alias, int moduleId, int size, byte[] data)
    {
        if (_client == null) return false;

        int startAddr = _client.GetOutAddress(alias, moduleId);

        if (startAddr < 0) return false;
        return (_client.SetOutBytes(startAddr, size, data) == 0);
    }

    public bool GetInBit(int addr, int bit, out byte data)
    {
        data = 0;
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }
        return (_client.GetInBit(addr + byteOffset, bit, out data) == 0);
    }

    public bool GetInBit(int alias, int moduleId, int bit, out byte data)
    {
        data = 0;
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }

        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetInBit(startAddr + byteOffset, bit, out data) == 0);
    }

    public bool GetInByte(int addr, out byte data)
    {
        data = 0;
        if (_client == null) return false;
        return (_client.GetInByte(addr, out data) == 0);
    }

    public bool GetInByte(int alias, int moduleId, out byte data)
    {
        data = 0;
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetInByte(startAddr, out data) == 0);
    }

    public bool GetInBytes(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        if (_client == null) return false;
        return (_client.GetInBytes(addr, size, out data) == 0);
    }

    public bool GetInBytes(int alias, int moduleId, int size, out byte[] data)
    {
        data = new byte[size];
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetInBytes(startAddr, size, out data) == 0);
    }

    public bool GetOutBit(int addr, int bit, out byte data)
    {
        data = 0;
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }
        return (_client.GetOutBit(addr + byteOffset, bit, out data) == 0);
    }

    public bool GetOutBit(int alias, int moduleId, int bit, out byte data)
    {
        data = 0;
        if (_client == null) return false;

        int byteOffset = 0;
        if (bit >= 8)
        {
            byteOffset += bit / 8;
            bit = bit % 8;
        }

        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetOutBit(startAddr + byteOffset, bit, out data) == 0);
    }

    public bool GetOutByte(int addr, out byte data)
    {
        data = 0;
        if (_client == null) return false;
        return (_client.GetOutByte(addr, out data) == 0);
    }

    public bool GetOutByte(int alias, int moduleId, out byte data)
    {
        data = 0;
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetOutByte(startAddr, out data) == 0);
    }

    public bool GetOutBytes(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        if (_client == null) return false;
        return (_client.GetOutBytes(addr, size, out data) == 0);
    }

    public bool GetOutBytes(int alias, int moduleId, int size, out byte[] data)
    {
        data = new byte[size];
        if (_client == null) return false;
        int startAddr = _client.GetOutAddress(alias, moduleId);
        if (startAddr < 0) return false;
        return (_client.GetOutBytes(startAddr, size, out data) == 0);
    }

    

    
}