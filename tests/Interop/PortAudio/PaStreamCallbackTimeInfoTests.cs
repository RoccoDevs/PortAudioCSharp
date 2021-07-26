// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaStreamCallbackTimeInfo" /> struct.</summary>
    public static unsafe class PaStreamCallbackTimeInfoTests
    {
        /// <summary>Validates that the <see cref="PaStreamCallbackTimeInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaStreamCallbackTimeInfo>(), Is.EqualTo(sizeof(PaStreamCallbackTimeInfo)));
        }

        /// <summary>Validates that the <see cref="PaStreamCallbackTimeInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaStreamCallbackTimeInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaStreamCallbackTimeInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PaStreamCallbackTimeInfo), Is.EqualTo(24));
        }
    }
}
