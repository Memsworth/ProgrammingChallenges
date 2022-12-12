using System.Net.Sockets;

int startPort;
int endPort;

do
{
    startPort = GetTcpPort("Start");
    endPort = GetTcpPort("End");
} while (startPort > endPort);

for (int i = startPort; i <= endPort; i++)
{
    // Create a new TcpClient and connect to the port
    TcpClient client = new TcpClient();
    try
    {
        client.Connect("localhost", i);
        if (client.Connected)
        {
            Console.WriteLine($"Port {i} is open");
        }
        client.Close();
    }
    catch (Exception)
    {
        Console.WriteLine($"Port {i} is closed");
    }
}

int GetTcpPort(string prompt)
{
    int port;
    while (true)
    {
        Console.Write($"Enter a {prompt} port number between 1 and 65535: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out port))
        {
            if (port is >= 1 and <= 65535)
            {
                break;
            }
        }
        Console.WriteLine("Invalid port number. Please try again.");
    }

    return port;
}