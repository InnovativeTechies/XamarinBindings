using Android.App;
using Android.Widget;
using Android.OS;
using Com.Google.Android.Youtube.Player;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Android.Content;

namespace VideoPlayer
{
	[Activity(Label = "VideoPlayer", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : YouTubeBaseActivity,IYouTubePlayerOnInitializedListener
	{
		public static string Api_Key = "AIzaSyCyl5DAoFzVlxOgCFssQ1NrsYHcLpJZPLY";
		public static string Video_Id = "o7VVHhK9zf0";

		public void OnInitializationFailure(IYouTubePlayerProvider p0, YouTubeInitializationResult p1)
		{
			throw new NotImplementedException();
		}

		public void OnInitializationSuccess(IYouTubePlayerProvider p0, IYouTubePlayer p1, bool p2)
		{
			if (!p2)
			{
				p1.CueVideo(Video_Id);
			}
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			YouTubePlayerView youTubePlayerView = FindViewById<YouTubePlayerView>(Resource.Id.youtube_player_view);
			youTubePlayerView.Initialize(Api_Key, this);


			//Intent i = YouTubeStandalonePlayer.CreateVideoIntent(this, Api_Key, Video_Id);

			//StartActivity(i);
			//YouTubePlayerFragment ytb = 

			// Get our button from the layout resource,
			// and attach an event to it
	
		}
	}
}

