using Bridge.Interfaces;

namespace Bridge
{
    internal class QuickTimePlayer : IMediaPlayer
    {
        public void Play(IMusicFile musicFile)
        {
            Console.WriteLine("Play music file using QuickTime");
        }
    }
}
