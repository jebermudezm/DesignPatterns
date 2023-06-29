using Bridge.Interfaces;

namespace Bridge
{
    internal class WindowsMediaPlayer : IMediaPlayer
    {
        public void Play(IMusicFile musicFile)
        {
            Console.WriteLine("Play music file using Windows Media Player");
        }
    }
}
