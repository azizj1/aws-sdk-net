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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterParameterGroups operation.
    /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
    /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
    /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DescribeClusterParameterGroups"/>
    public class DescribeClusterParameterGroupsRequest : AmazonWebServiceRequest
    {
        private string parameterGroupName;
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// The name of a specific parameter group for which to return details. By default, details about all parameter groups and the default parameter
        /// group are returned.
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParameterGroupsRequest WithParameterGroupName(string parameterGroupName)
        {
            this.parameterGroupName = parameterGroupName;
            return this;
        }
            

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// The maximum number of response records to return in each call. If the number of remaining response records exceeds the specified
        /// <c>MaxRecords</c> value, a value is returned in a <c>marker</c> field of the response. You can retrieve the next set of records by retrying
        /// the command with the returned marker value. Default: <c>100</c> Constraints: minimum 20, maximum 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParameterGroupsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional parameter that specifies the starting point to return a set of response records. When the results of a
        /// <a>DescribeClusterParameterGroups</a> request exceed the value specified in <c>MaxRecords</c>, AWS returns a value in the <c>Marker</c>
        /// field of the response. You can retrieve the next set of response records by providing the returned marker value in the <c>Marker</c>
        /// parameter and retrying the request.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParameterGroupsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
    
