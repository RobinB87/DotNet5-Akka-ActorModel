namespace MovieStreaming.Messages
{
    public class PlayMovieMessage
    {
        // Use private set to make immutable after instantiation
        public string MovieTitle { get; private set; }
        public int UserId { get; private set; }

        public PlayMovieMessage(string movieTitle, int userId)
        {
            MovieTitle = movieTitle;
            UserId = userId;
        }
    }
}