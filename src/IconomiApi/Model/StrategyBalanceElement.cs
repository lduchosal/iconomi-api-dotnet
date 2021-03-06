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
    /// StrategyBalanceElement
    /// </summary>
    [DataContract]
        public partial class StrategyBalanceElement :  IEquatable<StrategyBalanceElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrategyBalanceElement" /> class.
        /// </summary>
        /// <param name="ticker">ticker.</param>
        /// <param name="balance">balance.</param>
        public StrategyBalanceElement(string ticker = default(string), string balance = default(string))
        {
            this.Ticker = ticker;
            this.Balance = balance;
        }
        
        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name="ticker", EmitDefaultValue=true)]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=true)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrategyBalanceElement {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as StrategyBalanceElement);
        }

        /// <summary>
        /// Returns true if StrategyBalanceElement instances are equal
        /// </summary>
        /// <param name="input">Instance of StrategyBalanceElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrategyBalanceElement input)
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
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                return hashCode;
            }
        }
    }
}
