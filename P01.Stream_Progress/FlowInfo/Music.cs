using System;
using System.Collections.Generic;
using System.Text;
using P01.Stream_Progress.FlowInfo;

namespace P01.Stream_Progress
{
    public class Music : IFlowInfo
    {
        private string artist;
        private string album;
        public int Length { get; set; }

        public Music(string artist, string album, int length)
        {
            this.artist = artist;
            this.album = album;
            Length = length;
        }
    }
}
