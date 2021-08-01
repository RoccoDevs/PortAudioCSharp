// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.

using System;

namespace PortAudioCSharp.Interop
{
    public unsafe partial struct PaWinWDMKSDeviceInfo
    {
        [NativeTypeName("wchar_t [260]")]
        public fixed ushort filterPath[260];

        [NativeTypeName("wchar_t [260]")]
        public fixed ushort topologyPath[260];

        public PaWDMKSType streamingType;

        [NativeTypeName("GUID")]
        public Guid deviceProductGuid;
    }
}
