using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using System.Threading;
using System.Collections.Concurrent;

namespace projectIronDome
{
    
    
        public class QueueManager
        {
            private readonly WebSocketServer _wss;
            private  ConcurrentQueue<Missile> _missileQueue;


            public QueueManager(ConcurrentQueue<Missile> missileQueue, WebSocketServer wss)
            {
                this._missileQueue = missileQueue;
                this._wss = wss;
            }


            public void Start()
            {

                int ironDomeAmount = 4;
                for (int i = 0; i < ironDomeAmount; i++)
                {
                    var interceptorThread = new Thread(() => Interceptor(i.ToString()));
                    interceptorThread.Start();
                }

            }

            public async void Interceptor(string name)
        {
                IronDome ironDome = new IronDome();
                while (true)
                {
                    if (this._missileQueue.Count > 0 && this._missileQueue.TryDequeue(out Missile result))
                    {
                       
                        bool res_bool = await ironDome.handleMissile(result);
                        var message = new { intercepted = res_bool, missileName = result.name };
                        var json = JsonSerializer.Serialize(message);
                        
                        this._wss.WebSocketServices["/MissileHanlder"].Sessions.Broadcast(json); 
                    }
                }
            }
        }
    }

