using System;
using System.Linq;
using Foundation;
using Newtonsoft.Json;
using UIKit;

namespace OrbitSdk.iOS.Demo
{
    public class PickerItem
    {
        public string Title { get; set; }

        public string Id { get; set; }
    }

    public class PickerItemViewModel : UIPickerViewModel
    {
        readonly PickerItem[] data;

        public PickerItemViewModel(PickerItem[] data)
        {
            this.data = data;

            SelectedItem = data.FirstOrDefault();
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return data.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return data[row].Title;
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            SelectedItem = data[row];
        }

        public PickerItem SelectedItem { get; private set; }
    }

    public partial class ViewController : UIViewController
    {
        NSObject[] docTypes;

        PickerItemViewModel pickerItems;

        ScanDelegate orbitDelegate;


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            docTypes = OrbitViewController.SupportedDocumentTypes;

            pickerItems = new PickerItemViewModel(
                docTypes
                    .Select(d => new PickerItem { Id = d.ToString(), Title = OrbitViewController.GetDocumentTypeDisplayName(d.ToString()) })
                    .Where(d => d.Id.StartsWith("AUS", StringComparison.InvariantCultureIgnoreCase))
                    .ToArray()
            );

            IdTypePicker.Model = pickerItems;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        partial void ScanButton_TouchUpInside(UIButton sender)
        {
            var selectedIdType = pickerItems.SelectedItem.Id;

            var parameters = new
            {
                RequestParam = new object[]
                {
                    new { Value = selectedIdType, Name = "DocType" },
                    new { Value = "123129-1239i9023", Name = "SessionID" },
                    new { Value = "1-FDAS04", Name = "CustomerID" },
                }
            };

            orbitDelegate = new ScanDelegate(this);
            orbitDelegate.ScanComplete += OrbitDelegate_ScanComplete;

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
                HideManualEntryButton = true,
                ScanForCardHolderPosition = OrbitScanForCardHolderPosition.All,
                RequestParam = JsonConvert.SerializeObject(parameters)
            };

            PresentViewController(orbitVC, true, null);
        }

        void OrbitDelegate_ScanComplete(object sender, Demo.ScanCompleteEventArgs e)
        {
            orbitDelegate.ScanComplete -= OrbitDelegate_ScanComplete;
            orbitDelegate.Dispose();

            // TODO: do something with e.Response...
        }
    }
}
