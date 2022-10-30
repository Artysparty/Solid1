namespace P01.Stream_Progress.Stream
{
    public class MusicStream : IStream
    {
        public MusicStream(int bytesSent)
        {
            BytesSent = bytesSent;
        }

        public int BytesSent { get; set; }
    }
}