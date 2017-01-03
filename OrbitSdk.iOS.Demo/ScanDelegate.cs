using System;
using Newtonsoft.Json;
using UIKit;

namespace OrbitSdk.iOS.Demo
{
    public class ScanResult
    {
        public string StatusMessage { get; set; }
        public OBResponseStatusCode StatusCode { get; set; }
        public ScanResultData[] CardData { get; set; }
    }

    public class ScanResultData
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Accuracy { get; set; }
    }

    public class ScanCompleteEventArgs : EventArgs
    {
        public ScanResult Response { get; set; }
        public UIImage FrontImage { get; set; }
        public UIImage BackImage { get; set; }
        public UIImage CameraFaceImage { get; set; }
    }

    public class ScanDelegate : OrbitViewControllerDelegate
    {
        public event EventHandler<ScanCompleteEventArgs> ScanComplete;

        readonly ViewController parent;

        public ScanDelegate(ViewController parent)
        {
            this.parent = parent;
        }

        public override void WithDocFrontImage(string response, UIImage docFrontImage, UIImage docBackImage, UIImage cameraFaceImage, OrbitViewController orbitViewController)
        {
            Console.WriteLine(response);

            var parsed = JsonConvert.DeserializeObject<ScanResult>(response);

            parent.DismissViewController(
                true,
                () => ScanComplete?.Invoke(
                    this,
                    new ScanCompleteEventArgs
                    {
                        Response = parsed,
                        FrontImage = docFrontImage,
                        BackImage = docBackImage,
                        CameraFaceImage = cameraFaceImage
                    })
            );
        }
    }

}
