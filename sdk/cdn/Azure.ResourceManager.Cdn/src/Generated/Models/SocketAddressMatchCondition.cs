// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for SocketAddress match conditions. </summary>
    public partial class SocketAddressMatchCondition
    {
        /// <summary> Initializes a new instance of SocketAddressMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public SocketAddressMatchCondition(SocketAddressMatchConditionType conditionType, SocketAddressOperator @operator)
        {
            ConditionType = conditionType;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of SocketAddressMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal SocketAddressMatchCondition(SocketAddressMatchConditionType conditionType, SocketAddressOperator @operator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public SocketAddressMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public SocketAddressOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
