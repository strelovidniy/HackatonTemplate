using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DesktopTemplate
{
    public sealed partial class MainPage
    {
        public MainPage() => InitializeComponent();
        
        public async void Greeting()
        {
            var mediaElement = new MediaElement();
            var stream = await new SpeechSynthesizer().SynthesizeTextToStreamAsync("Hello Marathone Team!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void HackatonWebView_OnLoadCompleted(object sender, NavigationEventArgs e) => Greeting();
    }
}
