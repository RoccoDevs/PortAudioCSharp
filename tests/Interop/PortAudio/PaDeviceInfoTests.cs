// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaDeviceInfo" /> struct.</summary>
    public static unsafe class PaDeviceInfoTests
    {
        /// <summary>Validates that the <see cref="PaDeviceInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaDeviceInfo>(), Is.EqualTo(sizeof(PaDeviceInfo)));
        }

        /// <summary>Validates that the <see cref="PaDeviceInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaDeviceInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaDeviceInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaDeviceInfo), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(PaDeviceInfo), Is.EqualTo(64));
            }
        }
    }
}
