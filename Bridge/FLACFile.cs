using Bridge.Interfaces;

namespace Bridge
{
    internal class FLACFile : IMusicFile
    {
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
