using Android.Media;
using SorrySound.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Dependency(typeof(Sound))]
namespace SorrySound.Droid
{
    public class Sound : IAudio
    {

        private MediaPlayer _mediaPlayer;

        public bool PlayAudio()
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.ss01);
            _mediaPlayer.Start();
            return true;
        }

    }
}