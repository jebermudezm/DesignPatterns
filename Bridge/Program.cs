using Bridge;


var windowsMediaPlayer = new WindowsMediaPlayer();
var vlcPlayer = new VLCPlayer();
var quickTimePlayer = new QuickTimePlayer();

var mp3File = new MP3File();
var wavFile = new WAVFile();
var flacFile = new FLACFile();

var windowsMediaPlayerPlayer = new MusicPlayer(windowsMediaPlayer);
windowsMediaPlayerPlayer.Play(mp3File);

var vlcPlayerPlayer = new MusicPlayer(vlcPlayer);
vlcPlayerPlayer.Play(wavFile);

var quickTimePlayerPlayer = new MusicPlayer(quickTimePlayer);
quickTimePlayerPlayer.Play(flacFile);


