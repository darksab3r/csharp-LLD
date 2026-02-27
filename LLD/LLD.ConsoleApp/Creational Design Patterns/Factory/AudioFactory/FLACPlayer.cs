using System;

namespace LLD.ConsoleApp.Factory.AudioPlayerFactory
{
    public class FLACPlayer : AudioPlayer
    {
        private int _volume;
        private double _playBackRate;

        public FLACPlayer(int volume, double playBackRate)
        {
            _volume = volume;
            _playBackRate = playBackRate;
        }

        public void Play()
        {
            Console.WriteLine("Playing FLAC audio");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing FLAC audio");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping FLAC audio");
        }

        public int GetVolume() => _volume;

        public void SetVolume(int volume)
        {
            if (volume >= 0 && volume <= 100)
                _volume = volume;
        }

        public double GetPlayBackRate() => _playBackRate;

        public override MediaFormat SupportsType()
        {
            return MediaFormat.FLAC;
        }
    }
}