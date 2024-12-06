/*
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NumberPropertiesOnly
    /// </summary>
    [DataContract(Name = "NumberPropertiesOnly")]
    public partial class NumberPropertiesOnly : IEquatable<NumberPropertiesOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberPropertiesOnly" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="varFloat">varFloat.</param>
        /// <param name="varDouble">varDouble.</param>
        public NumberPropertiesOnly(decimal number = default(decimal), float varFloat = default(float), double varDouble = default(double))
        {
            this.Number = number;
            this.Float = varFloat;
            this.Double = varDouble;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public decimal? Number { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name = "float", EmitDefaultValue = false)]
        public float? Float { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name = "double", EmitDefaultValue = false)]
        public double? Double { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NumberPropertiesOnly {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NumberPropertiesOnly);
        }

        /// <summary>
        /// Returns true if NumberPropertiesOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of NumberPropertiesOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberPropertiesOnly input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Float == input.Float ||
                    (this.Float != null &&
                    this.Float.Equals(input.Float))
                ) && 
                (
                    this.Double == input.Double ||
                    (this.Double != null &&
                    this.Double.Equals(input.Double))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Float != null)
                {
                    hashCode = (hashCode * 59) + this.Float.GetHashCode();
                }
                if (this.Double != null)
                {
                    hashCode = (hashCode * 59) + this.Double.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Double (double?) maximum
            if (this.Double > (double?)50.2)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value less than or equal to 50.2.", new [] { "Double" });
            }

            // Double (double?) minimum
            if (this.Double < (double?)0.8)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value greater than or equal to 0.8.", new [] { "Double" });
            }

            yield break;
        }
    }

}
