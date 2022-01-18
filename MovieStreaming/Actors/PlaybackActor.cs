using Akka.Actor;
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

            else if (message is int)
                Console.WriteLine("Received user ID " + message);

            else
                Unhandled(message);
        }
    }
}