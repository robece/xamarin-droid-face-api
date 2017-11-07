## Cognitive Services (Face API)

This code project is a transcription of the [public Android client library](https://github.com/Microsoft/Cognitive-Face-Android) released by Microsoft for Face API, the purpose is demonstrate how is possible to integrate the Face API service with Xamarin, using the nuget package 'Xamarin.Cognitive.Face'.

This project it's just a part of a bundle of samples and library code provided in the [Xamarin.Cognitive.Face](https://github.com/colbylwilliams/Cognitive-Face-Xamarin) nuget package, if you want to see more details about the Xamarin.iOS implementation, I strongly suggest visit [here](https://github.com/colbylwilliams/Cognitive-Face-Xamarin/tree/master/Xamarin.Cognitive.Face/Xamarin.Cognitive.Face.Sample/Xamarin.Cognitive.Face.Sample.iOS).

## Setup project

#### Clone the project from GitHub repo

`git clone https://github.com/rcervantes/xamarin-droid-face-api.git`

#### Configure Azure resources

For this project is required:

- Cognitive Services (Face API).

## Mobile application (Xamarin)

Go directly to source/Xamarin.Cognitive.Face.Sample.Droid/FaceDemoApp.cs and configure the Face API key and zone:

```csharp
    string faceApiKey = ""; //YOUR_FACE_API_KEY
    string faceApiZone = ""; //YOUR_FACE_API_ZONE
```

Once you have configure it your app settings, you are able to run the app.

<img src="http://rcervantes.me/images/face-api-xamarin-android-client.png" width="250">

E.g. of finding similar faces.

<img src="http://rcervantes.me/images/face-api-xamarin-android-client-find-similar.png" width="250">

## Credits

I want to thank [Nate Rickard](https://github.com/naterickard), [Colby Williams](https://github.com/colbylwilliams) for the code reviews, and invite me to participate on this great project.
