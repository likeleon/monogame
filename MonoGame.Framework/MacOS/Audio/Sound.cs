/*
	Sound.cs
	 
	Author:
	      Christian Beaumont chris@foundation42.org (http://www.foundation42.com)
	
	Copyright (c) 2009 Foundation42 LLC
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:
	
	The above copyright notice and this permission notice shall be included in
	all copies or substantial portions of the Software.
	
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
	THE SOFTWARE.
*/

using System;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

using MonoMac;
using MonoMac.Foundation;	

namespace Microsoft.Xna.Framework.Audio
{	
	public class Sound
	{	
		//private AVAudioPlayer _audioPlayer;
		
		public Sound()
		{
		}
		
		public Sound(string url, float volume, bool looping)
		{
			var mediaFile = NSUrl.FromFilename(url);			
			//_audioPlayer =  AVAudioPlayer.FromUrl(mediaFile); 
			//_audioPlayer.Volume = volume;
			if ( looping )
			{
				//_audioPlayer.NumberOfLoops = -1;
			}
			else
			{
				//_audioPlayer.NumberOfLoops = 0;
			}
		}
		
		public void Dispose()
		{
			//_audioPlayer.Dispose();
		}
		
		public double Duration
		{
			get;
			set;
		}
		
		public double CurrentPosition
		{
			get;
			set;
		}
			
		public bool Looping
		{
			get;
			set;
		}
		
		public float Pan
		{
			get;
			set;
		}
		
		public bool Playing
		{
			get;
			set;
		}
		
		public void Pause()
		{		
			//_audioPlayer.Pause();
		}
		
		public void Play()
		{		
			//_audioPlayer.Play();
		}
		
		public void Stop()
		{			
			//_audioPlayer.Stop();
		}
		
		public float Volume
		{
			get;
			set;
		}
		
		public static Sound CreateAndPlay(string url, float volume, bool looping)
		{
			Sound sound = new Sound(url, volume, looping);
			
			sound.Play();
			
			return sound;
		}
	}
}
