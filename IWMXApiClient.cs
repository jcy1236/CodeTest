public interface IWMXApiClient
{
    // SetOut methods
    int SetOutBit(int addr, int bit, byte data);
    int SetOutByte(int addr, byte data);
    int SetOutBytes(int addr, int size, byte[] data);

    // GetOut methods
    int GetOutBit(int addr, int bit, out byte data);
    int GetOutByte(int addr, out byte data);
    int GetOutBytes(int addr, int size, out byte[] data);
    int GetOutAddress(int alias, int moduleId);

    // SetIn methods
    int SetInBit(int addr, int bit, byte data);
    int SetInByte(int addr, byte data);
    int SetInBytes(int addr, int size, byte[] data);

    // GetIn methods
    int GetInBit(int addr, int bit, out byte data);
    int GetInByte(int addr, out byte data);
    int GetInBytes(int addr, int size, out byte[] data);
}