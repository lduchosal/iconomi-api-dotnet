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
    /// StructureElement
    /// </summary>
    [DataContract]
        public partial class StructureElement :  IEquatable<StructureElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureElement" /> class.
        /// </summary>
        /// <param name="rebalancedWeight">rebalancedWeight.</param>
        /// <param name="targetWeight">targetWeight.</param>
        /// <param name="assetTicker">assetTicker.</param>
        /// <param name="assetName">assetName.</param>
        /// <param name="assetCategory">assetCategory.</param>
        public StructureElement(decimal? rebalancedWeight = default(decimal?), decimal? targetWeight = default(decimal?), string assetTicker = default(string), string assetName = default(string), string assetCategory = default(string))
        {
            this.RebalancedWeight = rebalancedWeight;
            this.TargetWeight = targetWeight;
            this.AssetTicker = assetTicker;
            this.AssetName = assetName;
            this.AssetCategory = assetCategory;
        }
        
        /// <summary>
        /// Gets or Sets RebalancedWeight
        /// </summary>
        [DataMember(Name="rebalancedWeight", EmitDefaultValue=true)]
        public decimal? RebalancedWeight { get; set; }

        /// <summary>
        /// Gets or Sets TargetWeight
        /// </summary>
        [DataMember(Name="targetWeight", EmitDefaultValue=true)]
        public decimal? TargetWeight { get; set; }

        /// <summary>
        /// Gets or Sets AssetTicker
        /// </summary>
        [DataMember(Name="assetTicker", EmitDefaultValue=true)]
        public string AssetTicker { get; set; }

        /// <summary>
        /// Gets or Sets AssetName
        /// </summary>
        [DataMember(Name="assetName", EmitDefaultValue=true)]
        public string AssetName { get; set; }

        /// <summary>
        /// Gets or Sets AssetCategory
        /// </summary>
        [DataMember(Name="assetCategory", EmitDefaultValue=true)]
        public string AssetCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructureElement {\n");
            sb.Append("  RebalancedWeight: ").Append(RebalancedWeight).Append("\n");
            sb.Append("  TargetWeight: ").Append(TargetWeight).Append("\n");
            sb.Append("  AssetTicker: ").Append(AssetTicker).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetCategory: ").Append(AssetCategory).Append("\n");
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
            return this.Equals(input as StructureElement);
        }

        /// <summary>
        /// Returns true if StructureElement instances are equal
        /// </summary>
        /// <param name="input">Instance of StructureElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructureElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RebalancedWeight == input.RebalancedWeight ||
                    (this.RebalancedWeight != null &&
                    this.RebalancedWeight.Equals(input.RebalancedWeight))
                ) && 
                (
                    this.TargetWeight == input.TargetWeight ||
                    (this.TargetWeight != null &&
                    this.TargetWeight.Equals(input.TargetWeight))
                ) && 
                (
                    this.AssetTicker == input.AssetTicker ||
                    (this.AssetTicker != null &&
                    this.AssetTicker.Equals(input.AssetTicker))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.AssetCategory == input.AssetCategory ||
                    (this.AssetCategory != null &&
                    this.AssetCategory.Equals(input.AssetCategory))
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
                if (this.RebalancedWeight != null)
                    hashCode = hashCode * 59 + this.RebalancedWeight.GetHashCode();
                if (this.TargetWeight != null)
                    hashCode = hashCode * 59 + this.TargetWeight.GetHashCode();
                if (this.AssetTicker != null)
                    hashCode = hashCode * 59 + this.AssetTicker.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetCategory != null)
                    hashCode = hashCode * 59 + this.AssetCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}