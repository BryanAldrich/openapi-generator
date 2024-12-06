/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// BananaReq
    /// </summary>
    [DataContract(Name = "bananaReq")]
    public partial class BananaReq : IEquatable<BananaReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BananaReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BananaReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BananaReq" /> class.
        /// </summary>
        /// <param name="lengthCm">lengthCm (required).</param>
        /// <param name="sweet">sweet.</param>
        public BananaReq(decimal lengthCm = default(decimal), bool sweet = default(bool))
        {
            this.LengthCm = lengthCm;
            this.Sweet = sweet;
        }

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [DataMember(Name = "lengthCm", IsRequired = true, EmitDefaultValue = true)]
        public decimal LengthCm { get; set; }

        /// <summary>
        /// Gets or Sets Sweet
        /// </summary>
        [DataMember(Name = "sweet", EmitDefaultValue = true)]
        public bool? Sweet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BananaReq {\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
            sb.Append("  Sweet: ").Append(Sweet).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as BananaReq).AreEqual;
        }

        /// <summary>
        /// Returns true if BananaReq instances are equal
        /// </summary>
        /// <param name="input">Instance of BananaReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BananaReq input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + this.LengthCm.GetHashCode();
                if (this.Sweet != null)
                {
                    hashCode = (hashCode * 59) + this.Sweet.GetHashCode();
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
            yield break;
        }
    }

}
