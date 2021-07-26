// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaWinWDMKSDeviceInfo" /> struct.</summary>
    public static unsafe class PaWinWDMKSDeviceInfoTests
    {
        /// <summary>Validates that the <see cref="PaWinWDMKSDeviceInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaWinWDMKSDeviceInfo>(), Is.EqualTo(sizeof(PaWinWDMKSDeviceInfo)));
        }

        /// <summary>Validates that the <see cref="PaWinWDMKSDeviceInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaWinWDMKSDeviceInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaWinWDMKSDeviceInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PaWinWDMKSDeviceInfo), Is.EqualTo(1060));
        }
    }
}
