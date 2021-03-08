using System;
using System.Threading;
using Akka.Actor;

namespace HelloAkka
{
    public class GreeterActor : ReceiveActor
    {
        public GreeterActor()
        {
            Receive<Messages.CreateChild>(x => CreateChild());
            Receive<string>(x => IspisDetalja(x));
        }

        public void CreateChild()
        {
            var props = Props.Create(() => new ChildActor());
            var child = Context.ActorOf(props);
            child.Tell(new Messages.Greet("Say Mommy"));
        }

        public void IspisDetalja(string msg)
        {
            Console.WriteLine($"[{Self.Path}] Trenutna nit: {Thread.CurrentThread.ManagedThreadId}");
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