using MahApps.Metro.Controls;
using System.Speech.Synthesis;
using System.Windows;

namespace Speech_Synthesizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            speechSynth.Speak(speechTxt.Text);
        }
    }
}
