using Bridge.Interfaces;

namespace Bridge
{
    internal class MP3File : IMusicFile
    {
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
