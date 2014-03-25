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
    /// <para>Options for a date field. Dates and times are specified in UTC (Coordinated Universal Time) according to IETF RFC3339:
    /// yyyy-mm-ddT00:00:00Z. Present if <c>IndexFieldType</c> specifies the field is of type <c>date</c> . All options are enabled by
    /// default.</para>
    /// </summary>
    public partial class DateOptions
    {
        
        private string defaultValue;
        private string sourceField;
        private bool? facetEnabled;
        private bool? searchEnabled;
        private bool? returnEnabled;
        private bool? sortEnabled;

        /// <summary>
        /// A value to use for the field if the field isn't specified for a document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// A string that represents the name of an index field. Field names begin with a letter and can contain the following characters: a-z
        /// (lowercase), 0-9, and _ (underscore). The name "score" is reserved and cannot be used as a field name. To reference a document's ID, you can
        /// use the name <c>_id</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceField
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        /// <summary>
        /// Sets the SourceField property
        /// </summary>
        /// <param name="sourceField">The value to set for the SourceField property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithSourceField(string sourceField)
        {
            this.sourceField = sourceField;
            return this;
        }
            

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this.sourceField != null;
        }

        /// <summary>
        /// Whether facet information can be returned for the field.
        ///  
        /// </summary>
        public bool FacetEnabled
        {
            get { return this.facetEnabled ?? default(bool); }
            set { this.facetEnabled = value; }
        }

        /// <summary>
        /// Sets the FacetEnabled property
        /// </summary>
        /// <param name="facetEnabled">The value to set for the FacetEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithFacetEnabled(bool facetEnabled)
        {
            this.facetEnabled = facetEnabled;
            return this;
        }
            

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this.facetEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field are searchable.
        ///  
        /// </summary>
        public bool SearchEnabled
        {
            get { return this.searchEnabled ?? default(bool); }
            set { this.searchEnabled = value; }
        }

        /// <summary>
        /// Sets the SearchEnabled property
        /// </summary>
        /// <param name="searchEnabled">The value to set for the SearchEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithSearchEnabled(bool searchEnabled)
        {
            this.searchEnabled = searchEnabled;
            return this;
        }
            

        // Check to see if SearchEnabled property is set
        internal bool IsSetSearchEnabled()
        {
            return this.searchEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field can be returned in the search results.
        ///  
        /// </summary>
        public bool ReturnEnabled
        {
            get { return this.returnEnabled ?? default(bool); }
            set { this.returnEnabled = value; }
        }

        /// <summary>
        /// Sets the ReturnEnabled property
        /// </summary>
        /// <param name="returnEnabled">The value to set for the ReturnEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithReturnEnabled(bool returnEnabled)
        {
            this.returnEnabled = returnEnabled;
            return this;
        }
            

        // Check to see if ReturnEnabled property is set
        internal bool IsSetReturnEnabled()
        {
            return this.returnEnabled.HasValue;
        }

        /// <summary>
        /// Whether the field can be used to sort the search results.
        ///  
        /// </summary>
        public bool SortEnabled
        {
            get { return this.sortEnabled ?? default(bool); }
            set { this.sortEnabled = value; }
        }

        /// <summary>
        /// Sets the SortEnabled property
        /// </summary>
        /// <param name="sortEnabled">The value to set for the SortEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DateOptions WithSortEnabled(bool sortEnabled)
        {
            this.sortEnabled = sortEnabled;
            return this;
        }
            

        // Check to see if SortEnabled property is set
        internal bool IsSetSortEnabled()
        {
            return this.sortEnabled.HasValue;
        }
    }
}
