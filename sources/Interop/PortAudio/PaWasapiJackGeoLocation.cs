// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public enum PaWasapiJackGeoLocation
    {
        eJackGeoLocUnk = 0,
        eJackGeoLocRear = 0x1,
        eJackGeoLocFront,
        eJackGeoLocLeft,
        eJackGeoLocRight,
        eJackGeoLocTop,
        eJackGeoLocBottom,
        eJackGeoLocRearPanel,
        eJackGeoLocRiser,
        eJackGeoLocInsideMobileLid,
        eJackGeoLocDrivebay,
        eJackGeoLocHDMI,
        eJackGeoLocOutsideMobileLid,
        eJackGeoLocATAPI,
        eJackGeoLocReserved5,
        eJackGeoLocReserved6,
    }
}
