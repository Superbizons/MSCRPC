using System;

public class MSCRPC
{
    private static const MSCRPC instance = new MSCRPC();
    private static const String MSCRPCID = "430157626546847759";


    public static void Log(String text)
    {
        Console.WriteLine(text);
    }

    public static MSCRPC getInstance()
    {
        return this.instance;
    }

    public static String getAppID()
    {
        return this.MSCRPCID;
    }

    static void Main(string args[])
    {
        Log("Logging...");
        MSCConnection().getInstance().initDiscord();
    }

    
}
