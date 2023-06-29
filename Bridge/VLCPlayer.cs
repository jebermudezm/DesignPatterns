using Bridge.Interfaces;

namespace Bridge
{
    internal class VLCPlayer : IMediaPlayer
    {
        public void Play(IMusicFile musicFile)
        {
            Console.WriteLine("Play music file using VLC");
        }


        public void DrawSquare(int x, int y, int size)
        {
            Console.WriteLine("Draw square using WebGL");
        }

        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Console.WriteLine("Draw triangle using WebGL");
        }
    }
}
