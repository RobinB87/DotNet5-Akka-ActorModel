using Akka.Actor;
using MovieStreaming.Messages;
using System;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : ReceiveActor
    {
        public PlaybackActor()
        {
            Console.WriteLine("Creating a playback actor");

            // A predicate is just a function that returns true or false
            // Use predate for example to only handle messages with user id of 42
            Receive<PlayMovieMessage>(message => HandlePlayMovieMessage(message),
                message => message.UserId == 42);
        }

        private void HandlePlayMovieMessage(PlayMovieMessage message)
        {
            Console.WriteLine("Received movie title " + message.MovieTitle);
            Console.WriteLine("Received user ID " + message.UserId);
        }
    }
}