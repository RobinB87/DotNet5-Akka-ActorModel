using Akka.Actor;
using MovieStreaming.Messages;
using System;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : UntypedActor
    {
        public PlaybackActor()
        {
            Console.WriteLine("Creating a playback actor");
        }

        protected override void OnReceive(object message)
        {
            if (message is string)
                Console.WriteLine("Received movie title " + message);

            else if (message is PlayMovieMessage)
            {
                var m = message as PlayMovieMessage;

                Console.WriteLine("Received movie title " + m.MovieTitle);
                Console.WriteLine("Received user ID " + m.UserId);
            }

            else
                Unhandled(message);
        }
    }
}