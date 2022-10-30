namespace P01.Stream_Progress.Stream
{
    public class FileStream : IStream
    {
        public FileStream(int bytesSent)
        {
            BytesSent = bytesSent;
        }

        public int BytesSent { get; set; }
    }
}