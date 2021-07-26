// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaWinWDMKSInfo" /> struct.</summary>
    public static unsafe class PaWinWDMKSInfoTests
    {
        /// <summary>Validates that the <see cref="PaWinWDMKSInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaWinWDMKSInfo>(), Is.EqualTo(sizeof(PaWinWDMKSInfo)));
        }

        /// <summary>Validates that the <see cref="PaWinWDMKSInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaWinWDMKSInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaWinWDMKSInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PaWinWDMKSInfo), Is.EqualTo(24));
        }
    }
}
