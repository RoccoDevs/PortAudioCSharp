// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaWasapiStreamInfo" /> struct.</summary>
    public static unsafe class PaWasapiStreamInfoTests
    {
        /// <summary>Validates that the <see cref="PaWasapiStreamInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaWasapiStreamInfo>(), Is.EqualTo(sizeof(PaWasapiStreamInfo)));
        }

        /// <summary>Validates that the <see cref="PaWasapiStreamInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaWasapiStreamInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaWasapiStreamInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaWasapiStreamInfo), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(PaWasapiStreamInfo), Is.EqualTo(40));
            }
        }
    }
}
