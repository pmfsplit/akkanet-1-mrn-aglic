namespace HelloAkka
{
    public class Messages
    {
        public class CreateChild
        {
        }

        public class Greet
        {
            public string Msg { get; }

            public Greet(string msg)
            {
                Msg = msg;
            }
        }
    }
}