using System;
using System.IO;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Z.ExtensionMethods;

namespace RethinkDb.Driver.ReGrid.Tests
{
    [TestFixture]
    public class DownloadTests : BucketTest
    {

        [Test]
        public void test_download_as_bytes()
        {
            CreateBucketWithTwoFileRevisions();

            Console.WriteLine(">>>>> DOWNLOAD");
            var bytes = bucket.DownloadAsBytesByName(testfile);
            bytes.Should().Equal(TestBytes.OneHalfChunkReversed);

            bytes = bucket.DownloadAsBytesByName(testfile, revision: 0);
            bytes.Should().Equal(TestBytes.OneHalfChunk);
        }


        [Test]
        public void test_download_as_steream()
        {
            CreateBucketWithTwoFileRevisions();


            Console.WriteLine(">>>>> DOWNLOAD LATEST");
            var fs = File.Open("foobar_latest.mp3", FileMode.Create);
            bucket.DownloadToStreamByName(testfile, fs);
            fs.Close();

            var outBytes = File.ReadAllBytes("foobar_latest.mp3");

            TestBytes.OneHalfChunkReversed.Should().Equal(outBytes);



            Console.WriteLine(">>>>> DOWNLOAD ORIGINAL");

            fs = File.Open("foobar_original.mp3", FileMode.Create);
            bucket.DownloadToStreamByName(testfile, fs, revision: 0);
            fs.Close();

            outBytes = File.ReadAllBytes("foobar_original.mp3");

            TestBytes.OneHalfChunk.Should().Equal(outBytes);

        }

        [Test]
        public void test_seekable_stream()
        {
            CreateBucketWithOneFileTwoChunks();

            var opts = new DownloadOptions {Seekable = true};

            using( var stream = bucket.OpenDownloadStream(testfile, options: opts) )
            {
                stream.Seek(TestBytes.BlockLength, SeekOrigin.Begin);

                //read the stream into byte array.
                var dlbytes = stream.ToByteArray();

                dlbytes.Should().Equal(TestBytes.OneHalfChunk.Skip(TestBytes.BlockLength));
            }
        }

    }
}