using System;

namespace LLD.ConsoleApp.Factory.AudioPlayerFactory
{
    public class MP3Player : AudioPlayer
    {
        private int _volume;
        private double _playBackRate;

        public MP3Player(int volume, double playBackRate)
        {
            _volume = volume;
            _playBackRate = playBackRate;
        }

        public void Play()
        {
            Console.WriteLine("Playing MP3 audio");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing MP3 audio");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping MP3 audio");
        }

        public void SetVolume(int volume)
        {
            if (volume >= 0 && volume <= 100)
                _volume = volume;
        }

        public int GetVolume() => _volume;

        public double GetPlayBackRate() => _playBackRate;

        public override MediaFormat SupportsType()
        {
            return MediaFormat.MP3;
        }
    }
}