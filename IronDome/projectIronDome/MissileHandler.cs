using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using WebSocketSharp.Server;
using System.Threading.Tasks;
using WebSocketSharp;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Concurrent;

namespace projectIronDome
{
        internal class MissileHandler : WebSocketBehavior
        {

            private readonly WebSocketServer _wss;
            private  ConcurrentQueue<Missile> _missileQueue = new ConcurrentQueue<Missile>();

            public MissileHandler(WebSocketServer wss, ConcurrentQueue<Missile> missileQueue)
            {
                this._wss = wss;
                
            }

        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);

            try
            {
                Missile missile_ = JsonSerializer.Deserialize<Missile>(e.Data);
               
                if (missile_ != null)
                {
                    this._missileQueue.Enqueue(missile_);
                    

                    Console.WriteLine("Missile added to queue.");
                }
                else
                {
                    Console.WriteLine("Deserialization failed: Missile is null.");
                }
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"JSON Deserialization error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
            }
        }


        public void BroadcastStatus(string message)
            {
                //Send(message);
                this._wss.WebSocketServices["SOME_SERVICE"].Sessions.Broadcast(message);
            }
        }    
}

