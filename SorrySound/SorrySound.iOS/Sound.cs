using AVFoundation;
using Foundation;
using SorrySound.iOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Sound))]
namespace SorrySound.iOS
{
    class Sound : IAudio
    {
        AVAudioPlayer _player;
        public bool PlayAudio()
        {
            var fileName = "ss01.mp3";
            string sFilePath = NSBundle.MainBundle.PathForResource
              (Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName));
            var url = NSUrl.FromString(sFilePath);
            _player = AVAudioPlayer.FromUrl(url);
            _player.FinishedPlaying += (object sender, AVStatusEventArgs e) => {
                _player = null;
            };
            _player.Play();
            return true;
        }
    }
}