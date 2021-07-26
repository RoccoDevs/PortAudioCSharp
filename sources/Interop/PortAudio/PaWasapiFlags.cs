// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public enum PaWasapiFlags
    {
        paWinWasapiExclusive = (1 << 0),
        paWinWasapiRedirectHostProcessor = (1 << 1),
        paWinWasapiUseChannelMask = (1 << 2),
        paWinWasapiPolling = (1 << 3),
        paWinWasapiThreadPriority = (1 << 4),
        paWinWasapiExplicitSampleFormat = (1 << 5),
        paWinWasapiAutoConvert = (1 << 6),
    }
}
