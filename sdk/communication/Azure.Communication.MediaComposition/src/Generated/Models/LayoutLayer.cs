// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication.MediaComposition;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> Configure layer to control the z-position of input groups. </summary>
    public partial class LayoutLayer
    {
        /// <summary> Initializes a new instance of LayoutLayer. </summary>
        /// <param name="zIndex"> The z position of the layer. </param>
        public LayoutLayer(int zIndex)
        {
            ZIndex = zIndex;
        }

        /// <summary> Initializes a new instance of LayoutLayer. </summary>
        /// <param name="zIndex"> The z position of the layer. </param>
        /// <param name="visibility"> The visibility of the layer. </param>
        internal LayoutLayer(int zIndex, LayerVisibility? visibility)
        {
            ZIndex = zIndex;
            Visibility = visibility;
        }

        /// <summary> The z position of the layer. </summary>
        public int ZIndex { get; set; }
        /// <summary> The visibility of the layer. </summary>
        public LayerVisibility? Visibility { get; set; }
    }
}
