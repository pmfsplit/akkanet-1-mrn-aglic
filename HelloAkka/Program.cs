using System;
using System.Collections.Generic;
using System.Linq;
using Akka.Actor;

namespace HelloAkka
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("system-1"))
            {
                // var actor = new GreeterActor(); // Ne može
                var props = Props.Create(() => new GreeterActor());
                var actor = system.ActorOf(props, "ante");
                var actor2 = system.ActorOf(props, "marin");
                // var actor2 = system.ActorOf(props, "ante");

                actor.Tell("Hello there");
                actor2.Tell("Hello there you...");
            }
        }
    }
}