/*
 * Tiketeo API
 *
 * Autenticación: Bearer <secret_key> 
 *
 * The version of the OpenAPI document: v1
 * Contact: romario.lopez@tiketeo.mx
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// WinnerscheckWinner
    /// </summary>
    [DataContract]
    public partial class WinnerscheckWinner :  IEquatable<WinnerscheckWinner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinnerscheckWinner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WinnerscheckWinner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WinnerscheckWinner" /> class.
        /// </summary>
        /// <param name="phone">phone (required).</param>
        /// <param name="secret">secret (required).</param>
        public WinnerscheckWinner(string phone = default(string), string secret = default(string))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for WinnerscheckWinner and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }

            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for WinnerscheckWinner and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }

        }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=true)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WinnerscheckWinner {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as WinnerscheckWinner);
        }

        /// <summary>
        /// Returns true if WinnerscheckWinner instances are equal
        /// </summary>
        /// <param name="input">Instance of WinnerscheckWinner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WinnerscheckWinner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
