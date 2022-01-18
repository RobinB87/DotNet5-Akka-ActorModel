using Akka.Actor;
using MovieStreaming.Actors;
using MovieStreaming.Messages;
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

            playbackActorRef.Tell(new PlayMovieMessage("Akka.NET: The Movie", 41));

            Console.ReadLine();

            MovieStreamingActorSystem.Dispose();
        }
    }
}