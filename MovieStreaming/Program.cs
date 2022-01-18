using Akka.Actor;
using MovieStreaming.Actors;
using System;

namespace MovieStreaming
{
    class Program
    {
        private static ActorSystem MovieStreamingActorSystem;

        static void Main(string[] args)
        {
            // The name is important as it forms part of the address if we referencing remote actors
            MovieStreamingActorSystem = ActorSystem.Create("MovieStreamingActorSystem");
            Console.WriteLine("Actor system created");

            var playbackActorProps = Props.Create<PlaybackActor>();

            var playbackActorRef = MovieStreamingActorSystem.ActorOf(playbackActorProps, "PlaybackActor");

            playbackActorRef.Tell("Akka.NET: The Movie");
            playbackActorRef.Tell(42);
            playbackActorRef.Tell('c');

            Console.ReadLine();

            MovieStreamingActorSystem.Dispose();
        }
    }
}