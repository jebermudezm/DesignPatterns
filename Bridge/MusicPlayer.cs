using Bridge.Interfaces;

namespace Bridge
{
    internal class MusicPlayer
    {
        private IMediaPlayer _mediaPlayer;

        public MusicPlayer(IMediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        public void Play(IMusicFile musicFile)
        {
            _mediaPlayer.Play(musicFile);
        }
    }
}
