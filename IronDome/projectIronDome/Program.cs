using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;

namespace projectIronDome
{
    internal class Program
    {  
            static void Main(string[] args)
            {
                string port = "3108";
                 ConcurrentQueue<Missile> missileQueue = new ConcurrentQueue<Missile>();

                WebSocketServer wss = new WebSocketServer($"ws://localhost:{port}");

                wss.AddWebSocketService<MissileHandler>("/MissileHandler", () => new MissileHandler(wss, missileQueue));
                QueueManager manager = new QueueManager(missileQueue, wss);
                manager.Start();

                wss.Start();
                Console.WriteLine($"Web Socket server is listening on port: {port}");
                Console.ReadLine();
            
                wss.Stop();
            }
        }
    
}
    

