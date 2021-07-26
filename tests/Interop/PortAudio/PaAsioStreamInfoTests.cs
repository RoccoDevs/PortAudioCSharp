// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaAsioStreamInfo" /> struct.</summary>
    public static unsafe class PaAsioStreamInfoTests
    {
        /// <summary>Validates that the <see cref="PaAsioStreamInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaAsioStreamInfo>(), Is.EqualTo(sizeof(PaAsioStreamInfo)));
        }

        /// <summary>Validates that the <see cref="PaAsioStreamInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaAsioStreamInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaAsioStreamInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaAsioStreamInfo), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(PaAsioStreamInfo), Is.EqualTo(20));
            }
        }
    }
}
