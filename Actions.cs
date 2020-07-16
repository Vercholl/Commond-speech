using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commond_speech
{
    public class ActionsSpeak
    {
        public void MethodAction(string str)
        {
            System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
            speech.SelectVoice("ScanSoft Katerina_Full_22kHz");
            speech.Rate = -2;
            speech.Volume = 100;

            switch (str)
            {
                case "сколько время":
                    DateTime Data = DateTime.Now;
                    string Time = $"{Data.Hour} часов {Data.Minute} минут";
                    speech.Speak("Сейчас" + Time);
                    break;
                case "ты меня слышишь":
                    speech.Speak("Да, я тебя прекрасно слышу");
                    break;
                case "открой браузер":
                    Process.Start("browser.exe");
                    break;
            }
        }
    }
}
