using System;

public class MSCConnection
{
    private static const MSCConnection instance = new MSCConnection();


    public static MSCConnection getInstance()
    {
        return this.instance;
    }

    public static void initDiscord()
    {
        DiscordEventHandlers handlers;
        memset(&handlers, 0, sizeof(handlers));
        handlers.ready = handleDiscordReady;
        handlers.errored = handleDiscordError;
        handlers.disconnected = handleDiscordDisconnected;
        handlers.joinGame = handleDiscordJoinGame;
        handlers.spectateGame = handleDiscordSpectateGame;
        handlers.joinRequest = handleDiscordJoinRequest;

        Discord_Initialize(MSCRPC().getInstance().getAppID(), &handlers, 1, "1234");
    }

    public static void Discord_Shutdown()
    {

    }
}
