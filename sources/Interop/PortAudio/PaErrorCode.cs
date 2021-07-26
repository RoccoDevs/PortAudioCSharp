// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public enum PaErrorCode
    {
        paNoError = 0,
        paNotInitialized = -10000,
        paUnanticipatedHostError,
        paInvalidChannelCount,
        paInvalidSampleRate,
        paInvalidDevice,
        paInvalidFlag,
        paSampleFormatNotSupported,
        paBadIODeviceCombination,
        paInsufficientMemory,
        paBufferTooBig,
        paBufferTooSmall,
        paNullCallback,
        paBadStreamPtr,
        paTimedOut,
        paInternalError,
        paDeviceUnavailable,
        paIncompatibleHostApiSpecificStreamInfo,
        paStreamIsStopped,
        paStreamIsNotStopped,
        paInputOverflowed,
        paOutputUnderflowed,
        paHostApiNotFound,
        paInvalidHostApi,
        paCanNotReadFromACallbackStream,
        paCanNotWriteToACallbackStream,
        paCanNotReadFromAnOutputOnlyStream,
        paCanNotWriteToAnInputOnlyStream,
        paIncompatibleStreamHostApi,
        paBadBufferPtr,
    }
}
