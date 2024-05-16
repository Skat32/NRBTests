public class Program
{
    private static readonly object LockObject = new();
    private static bool _pingTurn = true;

    public static void Main()
    {
        var pingThread = new Thread(Ping);
        var pongThread = new Thread(Pong);

        pingThread.Start();
        pongThread.Start();
    }

    private static void Ping()
    {
        while (true)
            lock (LockObject)
            {
                if (!_pingTurn) 
                    continue;
                
                Console.WriteLine("ping");
                _pingTurn = false;
            }
    }

    private static void Pong()
    {
        while (true)
            lock (LockObject)
            {
                if (_pingTurn) 
                    continue;
                
                Console.WriteLine("pong");
                _pingTurn = true;
            }
    }
}