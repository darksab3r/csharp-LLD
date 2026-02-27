namespace LLD.ConsoleApp.Factory.AudioPlayerFactory
{
    public class AudioPlayerFactory
    {
        // TODO:
        // Implement factory method
        // Return AudioPlayer based on MediaFormat
        public AudioPlayer GetAudioPlayer(MediaFormat format,int volume, double playBackRate)
        {
            switch (format)
            {
                case MediaFormat.MP3:
                    return new MP3Player(volume, playBackRate);
                case MediaFormat.WAV:
                    return new WAVPlayer(volume, playBackRate);
                case MediaFormat.FLAC:
                    return new FLACPlayer(volume, playBackRate);
                default:
                    throw new ArgumentException("Invalid player type");
            }
        }
    }
}