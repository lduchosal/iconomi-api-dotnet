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
    /// EnumMapIntervalBigDecimal
    /// </summary>
    [DataContract]
        public partial class EnumMapIntervalBigDecimal :  IEquatable<EnumMapIntervalBigDecimal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumMapIntervalBigDecimal" /> class.
        /// </summary>
        /// <param name="dAY">dAY.</param>
        /// <param name="wEEK">wEEK.</param>
        /// <param name="mONTH">mONTH.</param>
        /// <param name="tHREEMONTH">tHREEMONTH.</param>
        /// <param name="sIXMONTH">sIXMONTH.</param>
        /// <param name="yTD">yTD.</param>
        /// <param name="yEAR">yEAR.</param>
        /// <param name="aLLTIME">aLLTIME.</param>
        public EnumMapIntervalBigDecimal(decimal? dAY = default(decimal?), decimal? wEEK = default(decimal?), decimal? mONTH = default(decimal?), decimal? tHREEMONTH = default(decimal?), decimal? sIXMONTH = default(decimal?), decimal? yTD = default(decimal?), decimal? yEAR = default(decimal?), decimal? aLLTIME = default(decimal?))
        {
            this.DAY = dAY;
            this.WEEK = wEEK;
            this.MONTH = mONTH;
            this.THREE_MONTH = tHREEMONTH;
            this.SIX_MONTH = sIXMONTH;
            this.YTD = yTD;
            this.YEAR = yEAR;
            this.ALL_TIME = aLLTIME;
        }
        
        /// <summary>
        /// Gets or Sets DAY
        /// </summary>
        [DataMember(Name="DAY", EmitDefaultValue=true)]
        public decimal? DAY { get; set; }

        /// <summary>
        /// Gets or Sets WEEK
        /// </summary>
        [DataMember(Name="WEEK", EmitDefaultValue=true)]
        public decimal? WEEK { get; set; }

        /// <summary>
        /// Gets or Sets MONTH
        /// </summary>
        [DataMember(Name="MONTH", EmitDefaultValue=true)]
        public decimal? MONTH { get; set; }

        /// <summary>
        /// Gets or Sets THREE_MONTH
        /// </summary>
        [DataMember(Name="THREE_MONTH", EmitDefaultValue=true)]
        public decimal? THREE_MONTH { get; set; }

        /// <summary>
        /// Gets or Sets SIX_MONTH
        /// </summary>
        [DataMember(Name="SIX_MONTH", EmitDefaultValue=true)]
        public decimal? SIX_MONTH { get; set; }

        /// <summary>
        /// Gets or Sets YTD
        /// </summary>
        [DataMember(Name="YTD", EmitDefaultValue=true)]
        public decimal? YTD { get; set; }

        /// <summary>
        /// Gets or Sets YEAR
        /// </summary>
        [DataMember(Name="YEAR", EmitDefaultValue=true)]
        public decimal? YEAR { get; set; }

        /// <summary>
        /// Gets or Sets ALL_TIME
        /// </summary>
        [DataMember(Name="ALL_TIME", EmitDefaultValue=true)]
        public decimal? ALL_TIME { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumMapIntervalBigDecimal {\n");
            sb.Append("  DAY: ").Append(DAY).Append("\n");
            sb.Append("  WEEK: ").Append(WEEK).Append("\n");
            sb.Append("  MONTH: ").Append(MONTH).Append("\n");
            sb.Append("  THREE_MONTH: ").Append(THREE_MONTH).Append("\n");
            sb.Append("  SIX_MONTH: ").Append(SIX_MONTH).Append("\n");
            sb.Append("  YTD: ").Append(YTD).Append("\n");
            sb.Append("  YEAR: ").Append(YEAR).Append("\n");
            sb.Append("  ALL_TIME: ").Append(ALL_TIME).Append("\n");
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
            return this.Equals(input as EnumMapIntervalBigDecimal);
        }

        /// <summary>
        /// Returns true if EnumMapIntervalBigDecimal instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumMapIntervalBigDecimal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumMapIntervalBigDecimal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DAY == input.DAY ||
                    (this.DAY != null &&
                    this.DAY.Equals(input.DAY))
                ) && 
                (
                    this.WEEK == input.WEEK ||
                    (this.WEEK != null &&
                    this.WEEK.Equals(input.WEEK))
                ) && 
                (
                    this.MONTH == input.MONTH ||
                    (this.MONTH != null &&
                    this.MONTH.Equals(input.MONTH))
                ) && 
                (
                    this.THREE_MONTH == input.THREE_MONTH ||
                    (this.THREE_MONTH != null &&
                    this.THREE_MONTH.Equals(input.THREE_MONTH))
                ) && 
                (
                    this.SIX_MONTH == input.SIX_MONTH ||
                    (this.SIX_MONTH != null &&
                    this.SIX_MONTH.Equals(input.SIX_MONTH))
                ) && 
                (
                    this.YTD == input.YTD ||
                    (this.YTD != null &&
                    this.YTD.Equals(input.YTD))
                ) && 
                (
                    this.YEAR == input.YEAR ||
                    (this.YEAR != null &&
                    this.YEAR.Equals(input.YEAR))
                ) && 
                (
                    this.ALL_TIME == input.ALL_TIME ||
                    (this.ALL_TIME != null &&
                    this.ALL_TIME.Equals(input.ALL_TIME))
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
                if (this.DAY != null)
                    hashCode = hashCode * 59 + this.DAY.GetHashCode();
                if (this.WEEK != null)
                    hashCode = hashCode * 59 + this.WEEK.GetHashCode();
                if (this.MONTH != null)
                    hashCode = hashCode * 59 + this.MONTH.GetHashCode();
                if (this.THREE_MONTH != null)
                    hashCode = hashCode * 59 + this.THREE_MONTH.GetHashCode();
                if (this.SIX_MONTH != null)
                    hashCode = hashCode * 59 + this.SIX_MONTH.GetHashCode();
                if (this.YTD != null)
                    hashCode = hashCode * 59 + this.YTD.GetHashCode();
                if (this.YEAR != null)
                    hashCode = hashCode * 59 + this.YEAR.GetHashCode();
                if (this.ALL_TIME != null)
                    hashCode = hashCode * 59 + this.ALL_TIME.GetHashCode();
                return hashCode;
            }
        }
    }
}
