using System;

public class MSCConnection
{
    private static MSCConnection instance;
    private static DiscordRichPresence presence;


    public MSCConnection(DiscordRichPresence presence, MSCConnection instance)
    {
        this.presence = presence;
        this.instance = instance;
    }

    public static MSCConnection getInstance()
    {
        return this.instance;
    }

    public static void updateTimestamp()
    {
        presence.startTimestamp = System.currentTimeMillis() / 1000;
    }

    public void updateTimestamp(long timestamp)
    {
        presence.startTimestamp = timestamp;
    }

    public void updateState(String state, String details)
    {
        presence.state = state;
        presence.details = details;
    }

    public void updateImageText(String text)
    {
        presence.largeImageText = text;
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
