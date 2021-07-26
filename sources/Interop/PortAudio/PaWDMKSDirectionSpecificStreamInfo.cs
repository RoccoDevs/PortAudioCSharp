// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public partial struct PaWDMKSDirectionSpecificStreamInfo
    {
        [NativeTypeName("PaDeviceIndex")]
        public int device;

        [NativeTypeName("unsigned int")]
        public uint channels;

        [NativeTypeName("unsigned int")]
        public uint framesPerHostBuffer;

        public int endpointPinId;

        public int muxNodeId;

        public PaWDMKSSubType streamingSubType;
    }
}
