// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public unsafe partial struct PaDeviceInfo
    {
        public int structVersion;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("PaHostApiIndex")]
        public int hostApi;

        public int maxInputChannels;

        public int maxOutputChannels;

        [NativeTypeName("PaTime")]
        public double defaultLowInputLatency;

        [NativeTypeName("PaTime")]
        public double defaultLowOutputLatency;

        [NativeTypeName("PaTime")]
        public double defaultHighInputLatency;

        [NativeTypeName("PaTime")]
        public double defaultHighOutputLatency;

        public double defaultSampleRate;
    }
}
