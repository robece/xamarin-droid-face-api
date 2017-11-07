using System;
using Android.App;
using Android.Runtime;

namespace Xamarin.Cognitive.Face.Sample.Droid
{
	[Application]
	public class FaceDemoApp : Application
	{
		public FaceDemoApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

            string faceApiKey = ""; //YOUR_FACE_API_KEY
            string faceApiZone = ""; //YOUR_FACE_API_ZONE

			if (string.IsNullOrEmpty (faceApiKey))
			{
				throw new Exception ("No API key set.  Please sign up for a Face API key at https://azure.microsoft.com/en-us/services/cognitive-services/face/");
			}

            if (string.IsNullOrEmpty(faceApiZone))
            {
                throw new Exception("No API zone set.  Please sign up for a Face API key at https://azure.microsoft.com/en-us/services/cognitive-services/face/");
            }

            FaceClient.Shared.SubscriptionKey = faceApiKey;
            FaceClient.Shared.Endpoint = $"https://{faceApiZone}.api.cognitive.microsoft.com/face/v1.0/";
		}
	}
}