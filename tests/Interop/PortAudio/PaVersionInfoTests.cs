// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaVersionInfo" /> struct.</summary>
    public static unsafe class PaVersionInfoTests
    {
        /// <summary>Validates that the <see cref="PaVersionInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaVersionInfo>(), Is.EqualTo(sizeof(PaVersionInfo)));
        }

        /// <summary>Validates that the <see cref="PaVersionInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaVersionInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaVersionInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaVersionInfo), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(PaVersionInfo), Is.EqualTo(20));
            }
        }
    }
}
