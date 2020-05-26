// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> This is the disk image base class. </summary>
    public partial class GalleryDiskImage
    {
        /// <summary> Initializes a new instance of GalleryDiskImage. </summary>
        public GalleryDiskImage()
        {
        }

        /// <summary> Initializes a new instance of GalleryDiskImage. </summary>
        /// <param name="sizeInGB"> This property indicates the size of the VHD to be created. </param>
        /// <param name="hostCaching"> The host caching of the disk. Valid values are &apos;None&apos;, &apos;ReadOnly&apos;, and &apos;ReadWrite&apos;. </param>
        /// <param name="source"> The gallery artifact version source. </param>
        internal GalleryDiskImage(int? sizeInGB, HostCaching? hostCaching, GalleryArtifactVersionSource source)
        {
            SizeInGB = sizeInGB;
            HostCaching = hostCaching;
            Source = source;
        }

        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public int? SizeInGB { get; }
        /// <summary> The host caching of the disk. Valid values are &apos;None&apos;, &apos;ReadOnly&apos;, and &apos;ReadWrite&apos;. </summary>
        public HostCaching? HostCaching { get; set; }
        /// <summary> The gallery artifact version source. </summary>
        public GalleryArtifactVersionSource Source { get; set; }
    }
}
