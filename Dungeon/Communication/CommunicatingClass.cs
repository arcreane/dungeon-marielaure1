public enum MessageType
{
    QUERY,
    COMBAT_INFO,
    WARNINGS,
    HIT_RECEIVED,
    HIT_DEALT,
    HIT_BLOCKED,
    DEAD,
    WINNING_FIGHT
}


public class CommunicatingClass
{
    public delegate string GetPlayerActionDelegate();

    public delegate void InformPlayerDelegate(string message, MessageType messageType);

    public GetPlayerActionDelegate GetPlayerAction;
    public InformPlayerDelegate InformPlayer;

    public CommunicatingClass()
    {
    }
}


