using System;

public class RoombaPacket
{
    public const int BAUD_19200 = 7;
    public const int BAUD_115200 = 11;

    public const byte DO_ = 60; //_はdoが予約語のせい
    public const byte LE_ = 62;
    public const byte MI_ = 64;
    public const byte FA_ = 65;
    public const byte SO_ = 67;
    public const byte LA_ = 69;
    public const byte SI_ = 71;


    public RoombaPacket()
    {
    }

    public byte[] Start()
    {
        byte[] packet = new byte[] { 128 };
        return packet;
    }

    public byte[] Baud(byte baud_code)
    {
        byte[] packet = new byte[] { 129, baud_code };
        return packet;
    }

    //--------------------------------------------------------------------------

    public byte[] Safe()
    {
        byte[] packet = new byte[] { 131 };
        return packet;
    }

    public byte[] Full()
    {
        byte[] packet = new byte[] { 132 };
        return packet;
    }

    public byte[] Power()
    {
        byte[] packet = new byte[] { 133 };
        return packet;
    }

    //--------------------------------------------------------------------------

    public byte[] Clean()
    {
        byte[] packet = new byte[] { 135 };
        return packet;
    }

    //--------------------------------------------------------------------------

    public byte[] Drive(int velocity, int radius)
    {
        //convert HEX
        byte[] velocity_bytes = BitConverter.GetBytes(velocity);
        byte[] radius_bytes = BitConverter.GetBytes(radius);

        byte[] packet = new byte[] { 137, velocity_bytes[1], velocity_bytes[0], radius_bytes[1], radius_bytes[0] };
        return packet;
    }

    public byte[] Drive_Straight(int velocity)
    {
        //convert HEX
        byte[] velocity_bytes = BitConverter.GetBytes((UInt16)velocity);
        byte[] radius_bytes = BitConverter.GetBytes((UInt16)0x7FFF);

        byte[] packet = new byte[] { 137, velocity_bytes[1], velocity_bytes[0], radius_bytes[1], radius_bytes[0] };
        return packet;
    }


    public byte[] Drive_Turn(bool clockwise, int velocity)
    {
        int direct;
        if (clockwise)
            direct = 1;
        else
            direct = -1;

        //convert HEX
        byte[] velocity_bytes = BitConverter.GetBytes((UInt16)velocity);
        byte[] radius_bytes = BitConverter.GetBytes((UInt16)direct);

        byte[] packet = new byte[] { 137, velocity_bytes[1], velocity_bytes[0], radius_bytes[1], radius_bytes[0] };
        return packet;
    }


    public byte[] Motors(bool mainb_direct, bool sideb_direct, bool mainbrush, bool vaccum, bool sidebrush)
    {
        int data = 0;
        data += (mainb_direct) ? 16 : 0;
        data += (sideb_direct) ? 8 : 0;
        data += (mainbrush) ? 4 : 0;
        data += (vaccum) ? 2 : 0;
        data += (sidebrush) ? 1 : 0;


        byte[] packet = new byte[] { 138, Convert.ToByte(data) };

        return packet;
    }

    //--------------------------------------------------------------------------



    public byte[] Song()
    {
        byte songID = 0; //todo
        byte songLength = 4;
        byte[] packet = new byte[] { 140, songID, songLength, 50, 100, 50, 100, 50, 100, 50, 100 };
        return packet;
    }

    public byte[] Play()
    {

        byte songID = 0; //todo
        byte[] packet = new byte[] { 141, songID };
        return packet;
    }

    public byte[] FamilyMart(byte songID)
    {
        byte[] packet = new byte[] { 140, songID, 12,
            FA_+1, 30, 
            LE_, 30, 
            LA_, 30, 
            LE_, 50, 
            
            MI_, 30, 
            LA_, 30, 
            LA_, 50, 
            
            MI_, 30, 
            FA_+1, 30, 
            MI_, 30, 
            LA_, 30, 
            LE_, 100, 
            };
        return packet;
    }

    public byte[] Frog1(byte songID)
    {
        byte[] packet = new byte[] { 140, songID, 14,
            DO_, 30, 
            LE_, 30, 
            MI_, 30, 
            FA_, 30, 
            MI_, 30, 
            LE_, 30, 
            DO_, 50, 
            
            MI_, 30, 
            FA_, 30, 
            SO_, 30, 
            LA_, 30, 
            SO_, 30, 
            FA_, 30, 
            MI_, 50
        };

        return packet;
    }

    public byte[] Frog2(byte songID)
    {
        byte[] packet = new byte[] { 140, songID, 11,
            DO_, 50, 
            DO_, 50, 
            DO_, 50, 
            DO_, 50, 
            
            DO_, 30, 
            LE_, 30, 
            MI_, 30, 
            FA_, 30, 
            MI_, 30, 
            LE_, 30, 
            DO_, 50, 
        };

        return packet;
    }
}
