// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public unsafe partial struct PaWasapiStreamInfo
    {
        [NativeTypeName("unsigned long")]
        public uint size;

        public PaHostApiTypeId hostApiType;

        [NativeTypeName("unsigned long")]
        public uint version;

        [NativeTypeName("unsigned long")]
        public uint flags;

        [NativeTypeName("PaWinWaveFormatChannelMask")]
        public uint channelMask;

        [NativeTypeName("PaWasapiHostProcessorCallback")]
        public delegate* unmanaged[Cdecl]<void*, int, void*, int, void*, void> hostProcessorOutput;

        [NativeTypeName("PaWasapiHostProcessorCallback")]
        public delegate* unmanaged[Cdecl]<void*, int, void*, int, void*, void> hostProcessorInput;

        public PaWasapiThreadPriority threadPriority;

        public PaWasapiStreamCategory streamCategory;

        public PaWasapiStreamOption streamOption;
    }
}
