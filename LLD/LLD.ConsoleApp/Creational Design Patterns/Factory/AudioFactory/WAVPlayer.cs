using System;

namespace LLD.ConsoleApp.Factory.AudioPlayerFactory
{
    public class WAVPlayer : AudioPlayer
    {
        private int _volume;
        private double _playBackRate;

        public WAVPlayer(int volume, double playBackRate)
        {
            _volume = volume;
            _playBackRate = playBackRate;
        }

        public void Play()
        {
            Console.WriteLine("Playing WAV audio");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing WAV audio");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping WAV audio");
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
            return MediaFormat.WAV;
        }
    }
}