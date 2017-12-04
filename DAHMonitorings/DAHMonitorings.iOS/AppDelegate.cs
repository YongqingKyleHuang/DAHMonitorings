using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.IO;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DAHMonitorings.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        

        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Initialize the Xamarin Test Cloud Agent
            #if ENABLE_TEST_CLOUD
                        Xamarin.Calabash.Start();
            #endif

            string fileName = "monitorings_db.sqlite";
            string fileLocation = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");
            string full_path = Path.Combine(fileLocation, fileName);

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App (full_path));

            AppCenter.Start("cff975cb-8bd8-43f7-9893-1883701b6d48",
                   typeof(Analytics), typeof(Crashes));

            return base.FinishedLaunching(app, options);
        }
    }
}
