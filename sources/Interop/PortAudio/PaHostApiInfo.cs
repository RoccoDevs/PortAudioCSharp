// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public unsafe partial struct PaHostApiInfo
    {
        public int structVersion;

        public PaHostApiTypeId type;

        [NativeTypeName("const char *")]
        public sbyte* name;

        public int deviceCount;

        [NativeTypeName("PaDeviceIndex")]
        public int defaultInputDevice;

        [NativeTypeName("PaDeviceIndex")]
        public int defaultOutputDevice;
    }
}
