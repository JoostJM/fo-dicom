// Copyright (c) 2012-2017 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom
{
    public partial class DicomUID
    {
        private static void LoadPrivateUIDs()
        {
            _uids.Add(DicomUID.GEPrivateImplicitVRBigEndian.UID, DicomUID.GEPrivateImplicitVRBigEndian);
            _uids.Add(DicomUID.PhillipsPrivateMRseriesDataStorage.UID, DicomUID.PhillipsPrivateMRseriesDataStorage);
            _uids.Add(DicomUID.PhilipsPrivateMRSpectrumStorage.UID, DicomUID.PhilipsPrivateMRSpectrumStorage);
            _uids.Add(DicomUID.PhilipsPrivateMRExamcardStorage.UID, DicomUID.PhilipsPrivateMRExamcardStorage);
        }

        /// <summary>GE Private Implicit VR Big Endian</summary>
        /// <remarks>Same as Implicit VR Little Endian except for big endian pixel data.</remarks>
        public static readonly DicomUID GEPrivateImplicitVRBigEndian = new DicomUID(
            "1.2.840.113619.5.2",
            "GE Private Implicit VR Big Endian",
            DicomUidType.TransferSyntax);
        public static readonly DicomUID PhillipsPrivateMRseriesDataStorage = new DicomUID(
            "1.3.46.670589.11.0.0.12.2", 
            "Phillips Private MR Series Data Storage", 
            DicomUidType.SOPClass);
        public static readonly DicomUID PhilipsPrivateMRSpectrumStorage = new DicomUID(
            "1.3.46.670589.11.0.0.12.1",
            "Philips Private MR Spectrum Storage", 
            DicomUidType.SOPClass);
        public static readonly DicomUID PhilipsPrivateMRExamcardStorage = new DicomUID(
            "1.3.46.670589.11.0.0.12.4", 
            "Philips Private MR Examcard Storage", 
            DicomUidType.SOPClass);
    }
}
