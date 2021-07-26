// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PaHostApiInfo" /> struct.</summary>
    public static unsafe class PaHostApiInfoTests
    {
        /// <summary>Validates that the <see cref="PaHostApiInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PaHostApiInfo>(), Is.EqualTo(sizeof(PaHostApiInfo)));
        }

        /// <summary>Validates that the <see cref="PaHostApiInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PaHostApiInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PaHostApiInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PaHostApiInfo), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(PaHostApiInfo), Is.EqualTo(24));
            }
        }
    }
}
