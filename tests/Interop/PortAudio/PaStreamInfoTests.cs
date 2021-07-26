// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaStreamInfo" /> struct.</summary>
    public static unsafe class PaStreamInfoTests
    {
        /// <summary>Validates that the <see cref="PaStreamInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaStreamInfo>(), Is.EqualTo(sizeof(PaStreamInfo)));
        }

        /// <summary>Validates that the <see cref="PaStreamInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaStreamInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaStreamInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PaStreamInfo), Is.EqualTo(32));
        }
    }
}
