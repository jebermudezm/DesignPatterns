namespace Bridge.Interfaces
{
    internal interface IMusicFile
    {
        string FilePath { get; }
        long FileSize { get; }
        TimeSpan Duration { get; }
    }
}
