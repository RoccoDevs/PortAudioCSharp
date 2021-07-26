// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public enum PaWasapiStreamCategory
    {
        eAudioCategoryOther = 0,
        eAudioCategoryCommunications = 3,
        eAudioCategoryAlerts = 4,
        eAudioCategorySoundEffects = 5,
        eAudioCategoryGameEffects = 6,
        eAudioCategoryGameMedia = 7,
        eAudioCategoryGameChat = 8,
        eAudioCategorySpeech = 9,
        eAudioCategoryMovie = 10,
        eAudioCategoryMedia = 11,
    }
}
