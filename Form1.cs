using Commond_speech;
using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpeechRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notify.Visible = false;
        }

        static Label Com;
        public static ActionsSpeak ASpeak = new ActionsSpeak();

        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.6)
            {
                Com.Text = e.Result.Text;
            }

            ASpeak.MethodAction(Com.Text);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Com = label1;
            System.Globalization.CultureInfo Cultura = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(Cultura);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            StreamReader sr = new StreamReader("command.txt");
            List<string> myList = new List<string>();
            while (!sr.EndOfStream) myList.Add(sr.ReadLine());

            Choices Command = new Choices();
            string[] res = myList.Select(n => n.ToString()).ToArray();
            Command.Add(res);

            GrammarBuilder GrBild = new GrammarBuilder();
            GrBild.Culture = Cultura;
            GrBild.Append(Command);
            Grammar Grammat = new Grammar(GrBild);
            sre.LoadGrammar(Grammat);
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notify.Visible = true; Hide();
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notify.Visible = false; Show();
            WindowState = FormWindowState.Normal;
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            this.Opacity = 0.6;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Opacity = 1;
        }
    }
}
