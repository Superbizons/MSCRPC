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

    private static void initDiscord()
    {
        DiscordEventHandlers handlers;
        memset(&handlers, 0, sizeof(handlers));
        handlers.ready = handleDiscordReady;
        handlers.errored = handleDiscordError;
        handlers.disconnected = handleDiscordDisconnected;
        handlers.joinGame = handleDiscordJoinGame;
        handlers.spectateGame = handleDiscordSpectateGame;
        handlers.joinRequest = handleDiscordJoinRequest;
        Discord_Initialize(getAppID , &handlers, 1, "1234");
    }

    static void Main(string args[])
    {
        Log("Logging...");
        initDiscord();
    }

    
}
