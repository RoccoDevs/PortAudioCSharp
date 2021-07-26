// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaAlsaStreamInfo" /> struct.</summary>
    public static unsafe class PaAlsaStreamInfoTests
    {
        /// <summary>Validates that the <see cref="PaAlsaStreamInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaAlsaStreamInfo>(), Is.EqualTo(sizeof(PaAlsaStreamInfo)));
        }

        /// <summary>Validates that the <see cref="PaAlsaStreamInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaAlsaStreamInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaAlsaStreamInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaAlsaStreamInfo), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(PaAlsaStreamInfo), Is.EqualTo(16));
            }
        }
    }
}
