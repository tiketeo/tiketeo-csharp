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
    /// TopupsTopup
    /// </summary>
    [DataContract]
    public partial class TopupsTopup :  IEquatable<TopupsTopup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopupsTopup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopupsTopup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopupsTopup" /> class.
        /// </summary>
        /// <param name="branchId">branchId.</param>
        /// <param name="topupBillerId">topupBillerId (required).</param>
        /// <param name="phone">phone (required).</param>
        /// <param name="phoneConfirmation">phoneConfirmation (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="externalId">externalId (required).</param>
        /// <param name="posId">posId.</param>
        public TopupsTopup(Guid branchId = default(Guid), Guid topupBillerId = default(Guid), string phone = default(string), string phoneConfirmation = default(string), float amount = default(float), string externalId = default(string), string posId = default(string))
        {
            // to ensure "topupBillerId" is required (not null)
            if (topupBillerId == null)
            {
                throw new InvalidDataException("topupBillerId is a required property for TopupsTopup and cannot be null");
            }
            else
            {
                this.TopupBillerId = topupBillerId;
            }

            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for TopupsTopup and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }

            // to ensure "phoneConfirmation" is required (not null)
            if (phoneConfirmation == null)
            {
                throw new InvalidDataException("phoneConfirmation is a required property for TopupsTopup and cannot be null");
            }
            else
            {
                this.PhoneConfirmation = phoneConfirmation;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TopupsTopup and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for TopupsTopup and cannot be null");
            }
            else
            {
                this.ExternalId = externalId;
            }

            this.BranchId = branchId;
            this.PosId = posId;
        }

        /// <summary>
        /// Gets or Sets BranchId
        /// </summary>
        [DataMember(Name="branch_id", EmitDefaultValue=false)]
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or Sets TopupBillerId
        /// </summary>
        [DataMember(Name="topup_biller_id", EmitDefaultValue=true)]
        public Guid TopupBillerId { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PhoneConfirmation
        /// </summary>
        [DataMember(Name="phone_confirmation", EmitDefaultValue=true)]
        public string PhoneConfirmation { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public float Amount { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets PosId
        /// </summary>
        [DataMember(Name="pos_id", EmitDefaultValue=false)]
        public string PosId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopupsTopup {\n");
            sb.Append("  BranchId: ").Append(BranchId).Append("\n");
            sb.Append("  TopupBillerId: ").Append(TopupBillerId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneConfirmation: ").Append(PhoneConfirmation).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  PosId: ").Append(PosId).Append("\n");
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
            return this.Equals(input as TopupsTopup);
        }

        /// <summary>
        /// Returns true if TopupsTopup instances are equal
        /// </summary>
        /// <param name="input">Instance of TopupsTopup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopupsTopup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BranchId == input.BranchId ||
                    (this.BranchId != null &&
                    this.BranchId.Equals(input.BranchId))
                ) && 
                (
                    this.TopupBillerId == input.TopupBillerId ||
                    (this.TopupBillerId != null &&
                    this.TopupBillerId.Equals(input.TopupBillerId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneConfirmation == input.PhoneConfirmation ||
                    (this.PhoneConfirmation != null &&
                    this.PhoneConfirmation.Equals(input.PhoneConfirmation))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.PosId == input.PosId ||
                    (this.PosId != null &&
                    this.PosId.Equals(input.PosId))
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
                if (this.BranchId != null)
                    hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                if (this.TopupBillerId != null)
                    hashCode = hashCode * 59 + this.TopupBillerId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneConfirmation != null)
                    hashCode = hashCode * 59 + this.PhoneConfirmation.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.PosId != null)
                    hashCode = hashCode * 59 + this.PosId.GetHashCode();
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
