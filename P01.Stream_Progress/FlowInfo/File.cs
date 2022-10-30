using P01.Stream_Progress.FlowInfo;

namespace P01.Stream_Progress
{
    public class File : IFlowInfo
    {
        private string name;
        public int Length { get; set; }
        
        public File(string name, int length)
        {
            this.name = name;
            Length = length;
        }
    }
}
