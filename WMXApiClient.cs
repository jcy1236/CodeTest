public class WMXApiClient : IWMXApiClient
{
    // Setin
    public int SetInBit(int addr, int bit, byte data)
    {
        return Wmx3Sim.SetInBit(addr, bit, data);
    }

    public int SetInByte(int addr, byte data)
    {
        return Wmx3Sim.SetInByte(addr, data);
    }

    public int SetInBytes(int addr, int size, byte[] data)
    {
        return Wmx3Sim.SetInBytes(addr, size, data);
    }

    // SetOut
    public int SetOutBit(int addr, int bit, byte data)
    {
        return Wmx3Lib_Io.SetOutBit(addr, bit, data);
    }

    public int SetOutByte(int addr, byte data)
    {
        return Wmx3Lib_Io.SetOutByte(addr, data);
    }

    public int SetOutBytes(int addr, int size, byte[] data)
    {
        return Wmx3Lib_Io.SetOutBytes(addr, size, data);
    }

    // GetIn
    public int GetInBit(int addr, int bit, out byte data)
    {
        data = 0;
        return Wmx3Lib_Io.GetInBit(addr, bit, ref data);
    }

    public int GetInByte(int addr, out byte data)
    {
        data = 0;
        return Wmx3Lib_Io.GetInByte(addr, ref data);
    }

    public int GetInBytes(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        return Wmx3Lib_Io.GetInBytes(addr, size, ref data);
    }

    // GetOut
    public int GetOutBit(int addr, int bit, out byte data)
    {
        data = 0;
        return Wmx3Lib_Io.GetOutBit(addr, bit, ref data);
    }

    public int GetOutByte(int addr, out byte data)
    {
        data = 0;
        return Wmx3Lib_Io.GetOutByte(addr, ref data);
    }

    public int GetOutBytes(int addr, int size, out byte[] data)
    {
        data = new byte[size];
        return Wmx3Lib_Io.GetOutBytes(addr, size, ref data);
    }

    public int GetOutAddress(int alias, int moduleId)
    {
        return Wmx3Lib_Io.GetOutAddress(alias, moduleId);
    }



    


    
}