// Copyright (c) Six Labors and contributors.
// See LICENSE for more details.

using System;
using SixLabors.ZlibStream;
using Xunit;
using SharpAdler32 = ICSharpCode.SharpZipLib.Checksum.Adler32;

namespace ZlibStream.Tests
{
    public class Adler32Tests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ReturnsCorrectWhenEmpty(uint input)
        {
            Assert.Equal(input, Adler32.Calculate(input, default));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(8)]
        [InlineData(215)]
        [InlineData(1024)]
        [InlineData(1024 + 15)]
        [InlineData(2034)]
        [InlineData(4096)]
        public void MatchesReference(int length)
        {
            var data = GetBuffer(length);
            var adler = new SharpAdler32();
            adler.Update(data);

            long expected = adler.Value;
            long actual = Adler32.Calculate(data);

            Assert.Equal(expected, actual);
        }

        private static byte[] GetBuffer(int length)
        {
            var data = new byte[length];
            new Random(1).NextBytes(data);

            return data;
        }
    }
}
