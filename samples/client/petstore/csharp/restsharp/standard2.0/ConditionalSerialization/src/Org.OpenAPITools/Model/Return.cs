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
    /// Model for testing reserved words
    /// </summary>
    [DataContract(Name = "Return")]
    public partial class Return : IEquatable<Return>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Return" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Return()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Return" /> class.
        /// </summary>
        /// <param name="varReturn">varReturn.</param>
        /// <param name="varLock">varLock (required).</param>
        /// <param name="varAbstract">varAbstract (required).</param>
        /// <param name="varUnsafe">varUnsafe.</param>
        public Return(int varReturn = default(int), string varLock = default(string), string varAbstract = default(string), string varUnsafe = default(string))
        {
            // to ensure "varLock" is required (not null)
            if (varLock == null)
            {
                throw new ArgumentNullException("varLock is a required property for Return and cannot be null");
            }
            this._Lock = varLock;
            // to ensure "varAbstract" is required (not null)
            if (varAbstract == null)
            {
                throw new ArgumentNullException("varAbstract is a required property for Return and cannot be null");
            }
            this._Abstract = varAbstract;
            this._VarReturn = varReturn;
            if (this.VarReturn != null)
            {
                this._flagVarReturn = true;
            }
            this._Unsafe = varUnsafe;
            if (this.Unsafe != null)
            {
                this._flagUnsafe = true;
            }
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets VarReturn
        /// </summary>
        [DataMember(Name = "return", EmitDefaultValue = false)]
        public int? VarReturn
        {
            get{ return _VarReturn;}
            set
            {
                _VarReturn = value;
                _flagVarReturn = true;
            }
        }
        private int? _VarReturn;
        private bool _flagVarReturn;

        /// <summary>
        /// Returns false as VarReturn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarReturn()
        {
            return _flagVarReturn;
        }
        /// <summary>
        /// Gets or Sets Lock
        /// </summary>
        [DataMember(Name = "lock", IsRequired = true, EmitDefaultValue = true)]
        public string Lock
        {
            get{ return _Lock;}
            set
            {
                _Lock = value;
                _flagLock = true;
            }
        }
        private string _Lock;
        private bool _flagLock;

        /// <summary>
        /// Returns false as Lock should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLock()
        {
            return _flagLock;
        }
        /// <summary>
        /// Gets or Sets Abstract
        /// </summary>
        [DataMember(Name = "abstract", IsRequired = true, EmitDefaultValue = true)]
        public string Abstract
        {
            get{ return _Abstract;}
            set
            {
                _Abstract = value;
                _flagAbstract = true;
            }
        }
        private string _Abstract;
        private bool _flagAbstract;

        /// <summary>
        /// Returns false as Abstract should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAbstract()
        {
            return _flagAbstract;
        }
        /// <summary>
        /// Gets or Sets Unsafe
        /// </summary>
        [DataMember(Name = "unsafe", EmitDefaultValue = false)]
        public string Unsafe
        {
            get{ return _Unsafe;}
            set
            {
                _Unsafe = value;
                _flagUnsafe = true;
            }
        }
        private string _Unsafe;
        private bool _flagUnsafe;

        /// <summary>
        /// Returns false as Unsafe should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnsafe()
        {
            return _flagUnsafe;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Return {\n");
            sb.Append("  VarReturn: ").Append(VarReturn).Append("\n");
            sb.Append("  Lock: ").Append(Lock).Append("\n");
            sb.Append("  Abstract: ").Append(Abstract).Append("\n");
            sb.Append("  Unsafe: ").Append(Unsafe).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Return).AreEqual;
        }

        /// <summary>
        /// Returns true if Return instances are equal
        /// </summary>
        /// <param name="input">Instance of Return to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Return input)
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
                if (this.VarReturn != null)
                {
                    hashCode = (hashCode * 59) + this.VarReturn.GetHashCode();
                }
                if (this.Lock != null)
                {
                    hashCode = (hashCode * 59) + this.Lock.GetHashCode();
                }
                if (this.Abstract != null)
                {
                    hashCode = (hashCode * 59) + this.Abstract.GetHashCode();
                }
                if (this.Unsafe != null)
                {
                    hashCode = (hashCode * 59) + this.Unsafe.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
