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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAnalysisSchemes operation.
    /// <para>Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific text processing options for a
    /// <c>text</c> field. Can be limited to specific analysis schemes by name. By default, shows all analysis schemes and includes any pending
    /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes.
    /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
    /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeAnalysisSchemes"/>
    public class DescribeAnalysisSchemesRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private List<string> analysisSchemeNames = new List<string>();
        private bool? deployed;

        /// <summary>
        /// The name of the domain you want to describe.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesRequest WithDomainName(string domainName)
        {
            this.domainName = domainName;
            return this;
        }
            

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// The analysis schemes you want to describe.
        ///  
        /// </summary>
        public List<string> AnalysisSchemeNames
        {
            get { return this.analysisSchemeNames; }
            set { this.analysisSchemeNames = value; }
        }
        /// <summary>
        /// Adds elements to the AnalysisSchemeNames collection
        /// </summary>
        /// <param name="analysisSchemeNames">The values to add to the AnalysisSchemeNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesRequest WithAnalysisSchemeNames(params string[] analysisSchemeNames)
        {
            foreach (string element in analysisSchemeNames)
            {
                this.analysisSchemeNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AnalysisSchemeNames collection
        /// </summary>
        /// <param name="analysisSchemeNames">The values to add to the AnalysisSchemeNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesRequest WithAnalysisSchemeNames(IEnumerable<string> analysisSchemeNames)
        {
            foreach (string element in analysisSchemeNames)
            {
                this.analysisSchemeNames.Add(element);
            }

            return this;
        }

        // Check to see if AnalysisSchemeNames property is set
        internal bool IsSetAnalysisSchemeNames()
        {
            return this.analysisSchemeNames.Count > 0;
        }

        /// <summary>
        /// Whether to display the deployed configuration (<c>true</c>) or include any pending changes (<c>false</c>). Defaults to <c>false</c>.
        ///  
        /// </summary>
        public bool Deployed
        {
            get { return this.deployed ?? default(bool); }
            set { this.deployed = value; }
        }

        /// <summary>
        /// Sets the Deployed property
        /// </summary>
        /// <param name="deployed">The value to set for the Deployed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAnalysisSchemesRequest WithDeployed(bool deployed)
        {
            this.deployed = deployed;
            return this;
        }
            

        // Check to see if Deployed property is set
        internal bool IsSetDeployed()
        {
            return this.deployed.HasValue;
        }
    }
}
    
