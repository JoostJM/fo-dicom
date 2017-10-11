// Copyright (c) 2012-2017 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom.Bugs
{
    using Xunit;

    [Collection("General")]
    public class GH626
    {
        [Fact]
        public void BadPrivateSequence_Does_Not_Exit_Prematurely()
        {
            var d = DicomFile.Open(@"Test Data\GH626.dcm");
            var pixelData = d.Dataset.Get<DicomItem>(DicomTag.PixelData, -1, null);  // Last tag is expected to be pixeldata
            Assert.Null(pixelData);
        }
    }
}
