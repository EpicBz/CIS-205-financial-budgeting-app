using System;
using static System.Console;
using System.Globalization;
class DebugTen04
{
    static void Main()
    {
        HotelRoom aRoom = new HotelRoom(234);
        SingleRoom aSingle = new SingleRoom(135);
        Suite aSuite = new Suite(453);
        WriteLine(aRoom.ToString());
        WriteLine(aSingle.ToString());
        WriteLine(aSuite.ToString());
    }
}
class HotelRoom
{
    public const double PREMIUM = 30.00;
    public const double STD_RATE = 89.99;
    public int roomNumber;

    public HotelRoom(int room)
    {
        roomNumber = room;
        
    }
    public int RoomNumber
    {
        get
        {
            return roomNumber;
        }
    }
    public double rate
    {
        get
        {
            return rate;
        }
    }
    override public string ToString()
    {
        string temp = GetType() + " Room " + RoomNumber + " Rate: " +
          rate.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        return temp;
    }
}
class SingleRoom : HotelRoom
{
    public double rate;

    public SingleRoom(int room) : base(room)
   {
    rate = STD_RATE - PREMIUM;
}   
}
class Suite : HotelRoom
{
    public double rate;
    public Suite(int room)
{
    rate = STD_RATE + PREMIUM;
}
}