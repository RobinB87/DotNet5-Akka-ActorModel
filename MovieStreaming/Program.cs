using System;
using Akka.Actor;

namespace MovieStreaming
{
    class Program
    {
        private static ActorSystem MovieStreamingActorSystem;

        static void Main(string[] args)
        {
            // The name is important as it forms part of the address if we referencing remote actors
            MovieStreamingActorSystem = ActorSystem.Create("MovieStreamingActorSystem");

            Console.ReadLine();

            MovieStreamingActorSystem.Dispose();
        }
    }
}
