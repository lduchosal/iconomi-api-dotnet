/* 
 * Iconomi API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IconomiApi.Client.SwaggerDateConverter;

namespace IconomiApi.Model
{
    /// <summary>
    /// Structure
    /// </summary>
    [DataContract]
        public partial class Structure :  IEquatable<Structure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Structure" /> class.
        /// </summary>
        /// <param name="ticker">ticker.</param>
        /// <param name="values">values.</param>
        /// <param name="numberOfAssets">numberOfAssets.</param>
        /// <param name="lastRebalanced">lastRebalanced.</param>
        /// <param name="monthlyRebalancedCount">monthlyRebalancedCount.</param>
        public Structure(string ticker = default(string), List<StructureElement> values = default(List<StructureElement>), int? numberOfAssets = default(int?), long? lastRebalanced = default(long?), long? monthlyRebalancedCount = default(long?))
        {
            this.Ticker = ticker;
            this.Values = values;
            this.NumberOfAssets = numberOfAssets;
            this.LastRebalanced = lastRebalanced;
            this.MonthlyRebalancedCount = monthlyRebalancedCount;
        }
        
        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name="ticker", EmitDefaultValue=true)]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public List<StructureElement> Values { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfAssets
        /// </summary>
        [DataMember(Name="numberOfAssets", EmitDefaultValue=true)]
        public int? NumberOfAssets { get; set; }

        /// <summary>
        /// Gets or Sets LastRebalanced
        /// </summary>
        [DataMember(Name="lastRebalanced", EmitDefaultValue=true)]
        public long? LastRebalanced { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyRebalancedCount
        /// </summary>
        [DataMember(Name="monthlyRebalancedCount", EmitDefaultValue=true)]
        public long? MonthlyRebalancedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Structure {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  NumberOfAssets: ").Append(NumberOfAssets).Append("\n");
            sb.Append("  LastRebalanced: ").Append(LastRebalanced).Append("\n");
            sb.Append("  MonthlyRebalancedCount: ").Append(MonthlyRebalancedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Structure);
        }

        /// <summary>
        /// Returns true if Structure instances are equal
        /// </summary>
        /// <param name="input">Instance of Structure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Structure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.NumberOfAssets == input.NumberOfAssets ||
                    (this.NumberOfAssets != null &&
                    this.NumberOfAssets.Equals(input.NumberOfAssets))
                ) && 
                (
                    this.LastRebalanced == input.LastRebalanced ||
                    (this.LastRebalanced != null &&
                    this.LastRebalanced.Equals(input.LastRebalanced))
                ) && 
                (
                    this.MonthlyRebalancedCount == input.MonthlyRebalancedCount ||
                    (this.MonthlyRebalancedCount != null &&
                    this.MonthlyRebalancedCount.Equals(input.MonthlyRebalancedCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.NumberOfAssets != null)
                    hashCode = hashCode * 59 + this.NumberOfAssets.GetHashCode();
                if (this.LastRebalanced != null)
                    hashCode = hashCode * 59 + this.LastRebalanced.GetHashCode();
                if (this.MonthlyRebalancedCount != null)
                    hashCode = hashCode * 59 + this.MonthlyRebalancedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}