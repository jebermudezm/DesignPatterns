using Bridge.Interfaces;

namespace Bridge
{
    internal class WAVFile : IMusicFile
    {
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
