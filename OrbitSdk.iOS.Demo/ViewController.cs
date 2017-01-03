using System;
using Foundation;
using Newtonsoft.Json;
using UIKit;

namespace OrbitSdk.iOS.Demo
{
    public partial class ViewController : UIViewController
    {
        NSObject[] docTypes;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            docTypes = OrbitViewController.GetSupportedDocumentTypesWithCountry("Australia");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        partial void ScanButton_TouchUpInside(UIButton sender)
        {
            var parameters = new
            {
                RequestParam = new object[]
                {
                    new { Value = docTypes[0].ToString(), Name = "DocType" },
                    new { Value = "123129-1239i9023", Name = "SessionID" },
                    new { Value = "1-FDAS04", Name = "CustomerID" },
                }
            };

            var orbitDelegate = new OrbitDelegate(this);

            var orbitVC = new OrbitViewController(orbitDelegate)
            {
                ApiToken = "SET_TOKEN_HERE",
                ApiSecret = "SET_SECRET_HERE",
                CheckExpiryDateValid = false,
                ScanFace = false,
                HideMainTitle = true,
                FaceMatchFailObscureThreshold = 48f,
                FaceMatchObscurePassThreshold = 50f,
                HideSettingsButton = true,
                HideButtonBar = true,
                ScanForCardHolderPosition = OrbitScanForCardHolderPosition.All,
                RequestParam = JsonConvert.SerializeObject(parameters)
            };

            PresentViewController(orbitVC, true, null);
        }
    }

    public class OrbitDelegate : OrbitViewControllerDelegate
    {
        readonly ViewController parent;

        public OrbitDelegate(ViewController parent)
        {
            this.parent = parent;
        }

        public override void WithDocFrontImage(string response, UIImage docFrontImage, UIImage docBackImage, UIImage cameraFaceImage, OrbitViewController orbitViewController)
        {
            parent.DismissViewController(false, () =>
            {
            });
        }
    }
}
