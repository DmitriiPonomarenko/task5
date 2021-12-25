using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var vPlayer1 = new VideoPlayer();
            var vPlayer2 = new VideoPlayer();
            var vPlayer3 = new VideoPlayer();
            var vPlayer4 = new VideoPlayer();

            var vPlayerList = new List<VideoPlayer> {vPlayer1, vPlayer2, vPlayer3, vPlayer4};

            // Включить все плееры
            vPlayerList.ForEach(vp => vp.ChangeTurnState());

            // Увеличить громкость на всех плеерах
            vPlayerList.ForEach(vp => vp.VolumeUp());

            // Начать запись на плеерах, громкость на которых больше 20, на остальных остановить
            vPlayerList.ForEach(vp =>
            {
                if (vp.Volume > 20) vp.ChangeRecordingState();
            });

            // Поменять видеовыход на плеерах на DVI
            vPlayerList.ForEach(vp => vp.VideoOutput = VideoOutput.DVI);

            // Найти, есть ли хотя бы один плеер с громкостью больше 50 и видеовыходом DVI
            vPlayerList.Any(vp => vp.Volume > 50 && vp.VideoOutput == VideoOutput.DVI);

            // Выключить звук на всех плеерах
            vPlayerList.ForEach(vp => vp.ChangeMuteState());

            // Выключить все плееры
            vPlayerList.ForEach(vp => vp.ChangeTurnState());
        }
    }
}