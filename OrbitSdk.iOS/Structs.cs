using System;
using ObjCRuntime;

namespace OrbitSdk.iOS
{
    [Native]
    public enum OrbitCameraViewOrientation : long
    {
        Portrait = 0,
        Landscape = 1,
        PortraitAndLandscape = 2
    }

    [Native]
    public enum OrbitFaceMatchResultFormat : long
    {
        PercentageRate = 0,
        IdentificationRate = 1,
        PercentageAndIdentificationRate = 2
    }

    [Native]
    public enum OrbitCardSide : long
    {
        Unknown = 0,
        Front,
        Back
    }

    [Native]
    public enum OrbitShowHelpAnimationOnScanStart : long
    {
        Off = 0,
        Always,
        OnlyOnFirstScan
    }

    [Native]
    public enum OrbitScanForCardHolderPosition : long
    {
        All = 0,
        OrbitScanForCardHolderPosition1,
        OrbitScanForCardHolderPosition2,
        OrbitScanForCardHolderPosition3,
        OrbitScanForCardHolderPosition4,
        OrbitScanForCardHolderPosition5
    }

    [Native]
    public enum OrbitFaceAlignmentResult : long
    {
        Ok = 0,
        Incorrect,
        TooClose
    }

    [Native]
    public enum OBResponseStatusCode : long
    {
        ErrScaninitfailed = 100,
        ErrScaningfailed = 110,
        ErrInvalidrequest = 120,
        ErrInvalidsettings = 130,
        ErrCameranotavailable = 140,
        ErrOutofmemory = 150,
        ErrCanceledbyuser = 210,
        ErrExpiredLicense = 220,
        ErrInvalidLicense = 230,
        ErrUnk = 0,
        SuccessOk = 200
    }
}
