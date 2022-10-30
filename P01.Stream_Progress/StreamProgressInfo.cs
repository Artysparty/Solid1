using System;
using System.Collections.Generic;
using System.Text;
using P01.Stream_Progress.FlowInfo;
using P01.Stream_Progress.Stream;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IFlowInfo _flowInformation;
        private IStream _stream;
        
        public StreamProgressInfo(IFlowInfo flowInformation, IStream stream)
        {
            _flowInformation = flowInformation;
            _stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (_stream.BytesSent * 100) / _flowInformation.Length;
        }
    }
}
