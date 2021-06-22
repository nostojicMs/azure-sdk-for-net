// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    /// <summary> Signature of a signed manifest. </summary>
    public partial class DockerManifestV1ImageSignature
    {

        /// <summary> Initializes a new instance of DockerManifestV1ImageSignature. </summary>
        /// <param name="header"> A JSON web signature. </param>
        /// <param name="signature"> A signature for the image manifest, signed by a libtrust private key. </param>
        /// <param name="protected"> The signed protected header. </param>
        internal DockerManifestV1ImageSignature(DockerManifestV1Jwk header, string signature, string @protected)
        {
            Header = header;
            Signature = signature;
            Protected = @protected;
        }
    }
}
