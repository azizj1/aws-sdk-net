/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>UpdateScalingParameters</c> request. Contains the status of the newly-configured scaling parameters.</para>
    /// </summary>
    public partial class UpdateScalingParametersResult
    {
        
        private ScalingParametersStatus scalingParameters;

        /// <summary>
        /// The status and configuration of a search domain's scaling parameters.
        ///  
        /// </summary>
        public ScalingParametersStatus ScalingParameters
        {
            get { return this.scalingParameters; }
            set { this.scalingParameters = value; }
        }

        /// <summary>
        /// Sets the ScalingParameters property
        /// </summary>
        /// <param name="scalingParameters">The value to set for the ScalingParameters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateScalingParametersResult WithScalingParameters(ScalingParametersStatus scalingParameters)
        {
            this.scalingParameters = scalingParameters;
            return this;
        }
            

        // Check to see if ScalingParameters property is set
        internal bool IsSetScalingParameters()
        {
            return this.scalingParameters != null;
        }
    }
}
