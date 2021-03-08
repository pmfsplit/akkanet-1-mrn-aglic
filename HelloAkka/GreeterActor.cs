using System;
using Akka.Actor;

namespace HelloAkka
{
    public class GreeterActor : ReceiveActor
    {
        public GreeterActor()
        {
            Receive<string>(x => IspisDetalja(x));
        }

        public void IspisDetalja(string msg)
        {
            Console.WriteLine(Sender);
            Console.WriteLine(Self);
            Console.WriteLine(msg);
        }

        protected override void Unhandled(object message)
        {
            Console.WriteLine($"Unhandled: {message}");
            // Console.WriteLine(message);
            base.Unhandled(message);
        }
    }
}