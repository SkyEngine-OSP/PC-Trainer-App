using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using FFImageLoading.Forms.Platform;
using NC2TrainerApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace NC2TrainerApp.Droid
{
     [Activity(Label = "NC2 Trainer App", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize, HardwareAccelerated = true)]
     public class MainActivity : FormsAppCompatActivity
     {
          protected override void OnCreate(Bundle savedInstanceState)
          {
               base.OnCreate(savedInstanceState);

               FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
               Xamarin.Essentials.Platform.Init(this, savedInstanceState);
               Xamarin.Forms.Forms.Init(this, savedInstanceState);

               CachedImageRenderer.InitImageViewHandler();

               LoadApplication(new App());
          }

          public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
          {
               Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

               base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
          }
     }
}