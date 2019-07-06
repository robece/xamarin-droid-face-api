## Cognitive Services (Face API)

This code project is a transcription of the <a href="https://github.com/Microsoft/Cognitive-Face-Android" target="_blank">public Android client library</a> released by Microsoft for Face API, the purpose is demonstrate how is possible to integrate the Face API service with Xamarin, using the nuget package 'Xamarin.Cognitive.Face'.

This project it's just a part of a bundle of samples and library code provided in the <a href="https://github.com/colbylwilliams/Cognitive-Face-Xamarin" target="_blank">Xamarin.Cognitive.Face</a> nuget package, if you want to see more details about the Xamarin.iOS implementation, I strongly suggest visit <a href="https://github.com/colbylwilliams/Cognitive-Face-Xamarin/tree/master/Xamarin.Cognitive.Face/Xamarin.Cognitive.Face.Sample/Xamarin.Cognitive.Face.Sample.iOS" target="_blank">here</a>.

## Setup project

**Clone the project from GitHub repo**

`git clone https://github.com/robece/xamarin-droid-face-api.git`

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

<div style="text-align:center">
    <img src="https://github.com/robece/xamarin-droid-face-api/blob/master/images/face-api-xamarin-android-client.png?raw=true" width="250" />
</div>

E.g. of finding similar faces.

<div style="text-align:center">
    <img src="https://github.com/robece/xamarin-droid-face-api/blob/master/images/face-api-xamarin-android-client-find-similar.png?raw=true" width="250" />
</div>

## Credits

I want to thank <a href="https://github.com/naterickard" target="_blank">Nate Rickard</a>, <a href="https://github.com/colbylwilliams" target="_blank">Colby Williams</a> for the code reviews, and invite me to participate on this project.