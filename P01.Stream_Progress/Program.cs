using System;
using P01.Stream_Progress.FlowInfo;
using P01.Stream_Progress.Stream;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {   
            IStream stream = new MusicStream(100);
            IFlowInfo file = new Music("", "", 1000);
            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(file, stream);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
        }
    }
}
