// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaWDMKSSpecificStreamInfo" /> struct.</summary>
    public static unsafe class PaWDMKSSpecificStreamInfoTests
    {
        /// <summary>Validates that the <see cref="PaWDMKSSpecificStreamInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaWDMKSSpecificStreamInfo>(), Is.EqualTo(sizeof(PaWDMKSSpecificStreamInfo)));
        }

        /// <summary>Validates that the <see cref="PaWDMKSSpecificStreamInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaWDMKSSpecificStreamInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaWDMKSSpecificStreamInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PaWDMKSSpecificStreamInfo), Is.EqualTo(48));
        }
    }
}
