using Akka.Actor;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : UntypedActor
    {
        public PlaybackActor()
        {
            System.Console.WriteLine("Creating a playback actor");
        }

        protected override void OnReceive(object message)
        {
            throw new System.NotImplementedException();
        }
    }
}