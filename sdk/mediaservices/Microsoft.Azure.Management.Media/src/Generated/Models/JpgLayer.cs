// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the settings to produce a JPEG image from the input video.
    /// </summary>
    public partial class JpgLayer : Layer
    {
        /// <summary>
        /// Initializes a new instance of the JpgLayer class.
        /// </summary>
        public JpgLayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JpgLayer class.
        /// </summary>
        /// <param name="width">The width of the output video for this layer.
        /// The value can be absolute (in pixels) or relative (in percentage).
        /// For example 50% means the output video has half as many pixels in
        /// width as the input.</param>
        /// <param name="height">The height of the output video for this layer.
        /// The value can be absolute (in pixels) or relative (in percentage).
        /// For example 50% means the output video has half as many pixels in
        /// height as the input.</param>
        /// <param name="label">The alphanumeric label for this layer, which
        /// can be used in multiplexing different video and audio layers, or in
        /// naming the output file.</param>
        /// <param name="quality">The compression quality of the JPEG output.
        /// Range is from 0-100 and the default is 70.</param>
        public JpgLayer(string width = default(string), string height = default(string), string label = default(string), int? quality = default(int?))
            : base(width, height, label)
        {
            Quality = quality;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the compression quality of the JPEG output. Range is
        /// from 0-100 and the default is 70.
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public int? Quality { get; set; }

    }
}
