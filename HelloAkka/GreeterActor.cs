using System;
using Akka.Actor;

namespace HelloAkka
{
    public class GreeterActor : ReceiveActor
    {
        public GreeterActor()
        {
            Receive<string>(x => Console.WriteLine(x));
        }
    }
}