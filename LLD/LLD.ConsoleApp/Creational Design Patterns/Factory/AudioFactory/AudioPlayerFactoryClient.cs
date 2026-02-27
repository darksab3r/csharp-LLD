namespace LLD.ConsoleApp.Factory.AudioPlayerFactory
{
    public class AudioPlayerFactoryClient
    {
        public static void Run()
        {
            AudioPlayerFactory factory = new AudioPlayerFactory();

            // TODO:
            // Use factory to create players
            // Test different MediaFormats
            
            AudioPlayer player1 = factory.GetAudioPlayer(MediaFormat.MP3,1,256);
            AudioPlayer player2 = factory.GetAudioPlayer(MediaFormat.WAV, 2, 128);
            AudioPlayer player3 = factory.GetAudioPlayer(MediaFormat.MP3, 3, 256);
            
            Console.WriteLine($"Players created: {player1.SupportsType()}, {player2.SupportsType()}, {player3.SupportsType()}");
        }
    }
}