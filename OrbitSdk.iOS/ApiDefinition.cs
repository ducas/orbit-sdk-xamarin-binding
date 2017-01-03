using System;
using UIKit;
using Foundation;
using ObjCRuntime;

namespace OrbitSdk.iOS
{
    // @protocol OrbitViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OrbitViewControllerDelegate
    {
        // @required -(void)responsed:(NSString *)response withDocFrontImage:(UIImage *)docFrontImage docBackImage:(UIImage *)docBackImage cameraFaceImage:(UIImage *)cameraFaceImage inOrbitViewController:(OrbitViewController *)orbitViewController;
        [Abstract]
        [Export("responsed:withDocFrontImage:docBackImage:cameraFaceImage:inOrbitViewController:")]
        void WithDocFrontImage(string response, UIImage docFrontImage, UIImage docBackImage, UIImage cameraFaceImage, OrbitViewController orbitViewController);
    }

    // @protocol OrbitAppearance <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OrbitAppearance
    {
        // @required +(instancetype)orbitAppearance;
        [Abstract]
        [Export("orbitAppearance")]
        OrbitAppearance OAppearance();
    }

    // @interface OrbitViewController : UINavigationController
    [BaseType(typeof(UINavigationController))]
    interface OrbitViewController
    {
        // @property (readwrite, copy, nonatomic) NSString * apiToken;
        [Export("apiToken")]
        string ApiToken { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * apiSecret;
        [Export("apiSecret")]
        string ApiSecret { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * requestParam;
        [Export("requestParam")]
        string RequestParam { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL useAutoCaptureMode;
        [Export("useAutoCaptureMode")]
        bool UseAutoCaptureMode { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL scanNonDefaultSide;
        [Export("scanNonDefaultSide")]
        bool ScanNonDefaultSide { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL scanFace;
        [Export("scanFace")]
        bool ScanFace { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL detectBlink;
        [Export("detectBlink")]
        bool DetectBlink { get; set; }

        // @property (assign, readwrite, nonatomic) OrbitFaceMatchResultFormat faceMatchResultFormat;
        [Export("faceMatchResultFormat", ArgumentSemantic.Assign)]
        OrbitFaceMatchResultFormat FaceMatchResultFormat { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat faceMatchFailObscureThreshold;
        [Export("faceMatchFailObscureThreshold")]
        nfloat FaceMatchFailObscureThreshold { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat faceMatchObscurePassThreshold;
        [Export("faceMatchObscurePassThreshold")]
        nfloat FaceMatchObscurePassThreshold { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL rescanFaceOnFail;
        [Export("rescanFaceOnFail")]
        bool RescanFaceOnFail { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL rescanFaceOnObscure;
        [Export("rescanFaceOnObscure")]
        bool RescanFaceOnObscure { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL saveFaceFromCamera;
        [Export("saveFaceFromCamera")]
        bool SaveFaceFromCamera { get; set; }

        // @property (assign, readwrite, nonatomic) OrbitCameraViewOrientation cameraViewOrientation;
        [Export("cameraViewOrientation", ArgumentSemantic.Assign)]
        OrbitCameraViewOrientation CameraViewOrientation { get; set; }

        // @property (assign, nonatomic) BOOL creditCardHolderNameRequired;
        [Export("creditCardHolderNameRequired")]
        bool CreditCardHolderNameRequired { get; set; }

        // @property (assign, nonatomic) BOOL creditCardExpiryDateRequired;
        [Export("creditCardExpiryDateRequired")]
        bool CreditCardExpiryDateRequired { get; set; }

        // @property (assign, readwrite, nonatomic) OrbitScanForCardHolderPosition scanForCardHolderPosition;
        [Export("scanForCardHolderPosition", ArgumentSemantic.Assign)]
        OrbitScanForCardHolderPosition ScanForCardHolderPosition { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * dateFormat;
        [Export("dateFormat")]
        string DateFormat { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL checkExpiryDateValid;
        [Export("checkExpiryDateValid")]
        bool CheckExpiryDateValid { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL vibrationEffectEnabled;
        [Export("vibrationEffectEnabled")]
        bool VibrationEffectEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL showCapturePreview;
        [Export("showCapturePreview")]
        bool ShowCapturePreview { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideHelpButton;
        [Export("hideHelpButton")]
        bool HideHelpButton { get; set; }

        // @property (assign, readwrite, nonatomic) OrbitShowHelpAnimationOnScanStart showHelpAnimationOnScanStart;
        [Export("showHelpAnimationOnScanStart", ArgumentSemantic.Assign)]
        OrbitShowHelpAnimationOnScanStart ShowHelpAnimationOnScanStart { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideMainTitle;
        [Export("hideMainTitle")]
        bool HideMainTitle { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideSubTitle;
        [Export("hideSubTitle")]
        bool HideSubTitle { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideInfoBar;
        [Export("hideInfoBar")]
        bool HideInfoBar { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideSettingsButton;
        [Export("hideSettingsButton")]
        bool HideSettingsButton { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideButtonBar;
        [Export("hideButtonBar")]
        bool HideButtonBar { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideCameraButton;
        [Export("hideCameraButton")]
        bool HideCameraButton { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hidePictureOnlyButton;
        [Export("hidePictureOnlyButton")]
        bool HidePictureOnlyButton { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideFlashButton;
        [Export("hideFlashButton")]
        bool HideFlashButton { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideManualEntryButton;
        [Export("hideManualEntryButton")]
        bool HideManualEntryButton { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * mainTitleStr;
        [Export("mainTitleStr")]
        string MainTitleStr { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * subTitleStr;
        [Export("subTitleStr")]
        string SubTitleStr { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * instructionStr;
        [Export("instructionStr")]
        string InstructionStr { get; set; }

        // -(id)initWithDelegate:(id<OrbitViewControllerDelegate>)aDelegate;
        [Export("initWithDelegate:")]
        IntPtr Constructor(OrbitViewControllerDelegate aDelegate);

        // +(NSString *)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        string SdkVersion { get; }

        // +(NSString *)sdkBuildDate;
        [Static]
        [Export("sdkBuildDate")]
        string SdkBuildDate { get; }

        // +(NSArray *)getSupportedCountries;
        [Static]
        [Export("getSupportedCountries")]
        NSObject[] SupportedCountries { get; }

        // +(NSString *)getCountryDisplayName:(NSString *)country;
        [Static]
        [Export("getCountryDisplayName:")]
        string GetCountryDisplayName(string country);

        // +(NSArray *)getSupportedDocumentTypesWithCountry:(NSString *)country;
        [Static]
        [Export("getSupportedDocumentTypesWithCountry:")]
        NSObject[] GetSupportedDocumentTypesWithCountry(string country);

        // +(NSArray *)getSupportedDocumentTypes;
        [Static]
        [Export("getSupportedDocumentTypes")]
        NSObject[] SupportedDocumentTypes { get; }

        // +(NSString *)getDocumentTypeDisplayName:(NSString *)docType;
        [Static]
        [Export("getDocumentTypeDisplayName:")]
        string GetDocumentTypeDisplayName(string docType);

        // +(OrbitCardSide)getDefaultScanSide:(NSString *)docType;
        [Static]
        [Export("getDefaultScanSide:")]
        OrbitCardSide GetDefaultScanSide(string docType);

        // +(BOOL)isFaceScanSupported:(NSString *)docType;
        [Static]
        [Export("isFaceScanSupported:")]
        bool IsFaceScanSupported(string docType);

        // +(NSArray *)getSupportedDateFormats;
        [Static]
        [Export("getSupportedDateFormats")]
        NSObject[] SupportedDateFormats { get; }

        // +(NSString *)getDateFormatDisplayName:(NSString *)dateFormat;
        [Static]
        [Export("getDateFormatDisplayName:")]
        string GetDateFormatDisplayName(string dateFormat);
    }

    // @interface OrbitBackButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitBackButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * image __attribute__((annotate("ui_appearance_selector")));
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }
    }

    // @interface OrbitButtonBar : UIView <OrbitAppearance>
    [BaseType(typeof(UIView))]
    interface OrbitButtonBar : OrbitAppearance
    {
    }

    // @interface OrbitCameraButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitCameraButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * image __attribute__((annotate("ui_appearance_selector")));
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }
    }

    // @interface OrbitCapturePreviewBackgroundView : UIView <OrbitAppearance>
    [BaseType(typeof(UIView))]
    interface OrbitCapturePreviewBackgroundView : OrbitAppearance
    {
    }

    // @interface OrbitFRStartButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitFRStartButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }
    }

    // @interface OrbitFlashButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitFlashButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * flashOnImage __attribute__((annotate("ui_appearance_selector")));
        [Export("flashOnImage", ArgumentSemantic.Strong)]
        UIImage FlashOnImage { get; set; }

        // @property (nonatomic, strong) UIImage * flashOffImage __attribute__((annotate("ui_appearance_selector")));
        [Export("flashOffImage", ArgumentSemantic.Strong)]
        UIImage FlashOffImage { get; set; }
    }

    // @interface OrbitHelpButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitHelpButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * image __attribute__((annotate("ui_appearance_selector")));
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (assign) CGFloat xOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("xOffset")]
        nfloat XOffset { get; set; }

        // @property (assign) CGFloat yOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("yOffset")]
        nfloat YOffset { get; set; }
    }

    // @interface OrbitInfoBar : UIView <OrbitAppearance>
    [BaseType(typeof(UIView))]
    interface OrbitInfoBar : OrbitAppearance
    {
    }

    // @interface OrbitInfoBarLabel : UILabel <OrbitAppearance>
    [BaseType(typeof(UILabel))]
    interface OrbitInfoBarLabel : OrbitAppearance
    {
        // @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }
    }

    // @interface OrbitMainTitleLabel : UILabel <OrbitAppearance>
    [BaseType(typeof(UILabel))]
    interface OrbitMainTitleLabel : OrbitAppearance
    {
        // @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }
    }

    // @interface OrbitManualEntryButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitManualEntryButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * image __attribute__((annotate("ui_appearance_selector")));
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }
    }

    // @interface OrbitPictureOnlyButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitPictureOnlyButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * pictureOnlyOnImage __attribute__((annotate("ui_appearance_selector")));
        [Export("pictureOnlyOnImage", ArgumentSemantic.Strong)]
        UIImage PictureOnlyOnImage { get; set; }

        // @property (nonatomic, strong) UIImage * pictureOnlyOffImage __attribute__((annotate("ui_appearance_selector")));
        [Export("pictureOnlyOffImage", ArgumentSemantic.Strong)]
        UIImage PictureOnlyOffImage { get; set; }
    }

    // @interface OrbitSettingsButton : UIButton <OrbitAppearance>
    [BaseType(typeof(UIButton))]
    interface OrbitSettingsButton : OrbitAppearance
    {
        // @property (nonatomic, strong) UIImage * image __attribute__((annotate("ui_appearance_selector")));
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }
    }

    // @interface OrbitSubTitleLabel : UILabel <OrbitAppearance>
    [BaseType(typeof(UILabel))]
    interface OrbitSubTitleLabel : OrbitAppearance
    {
        // @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }
    }

    // @interface OrbitTitleBar : UIView <OrbitAppearance>
    [BaseType(typeof(UIView))]
    interface OrbitTitleBar : OrbitAppearance
    {
    }
}
