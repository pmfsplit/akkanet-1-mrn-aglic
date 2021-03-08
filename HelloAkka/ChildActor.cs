using System;
using Akka.Actor;

namespace HelloAkka
{
    public class ChildActor : ReceiveActor
    {
        public ChildActor()
        {
            Receive<Messages.Greet>(greet =>
            {
                Console.WriteLine($"[{Self.Path}] {greet.Msg} from sender: {Sender}");
                // Self.Tell(greet); // Beskonačna petlja
                Self.Tell(PoisonPill.Instance);
            });
        }
    }
}