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
    /// Topup
    /// </summary>
    [DataContract]
    public partial class Topup :  IEquatable<Topup>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Inprogress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            Inprogress = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 2,

            /// <summary>
            /// Enum Failure for value: failure
            /// </summary>
            [EnumMember(Value = "failure")]
            Failure = 3

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines FailureReason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FailureReasonEnum
        {
            /// <summary>
            /// Enum Exception for value: exception
            /// </summary>
            [EnumMember(Value = "exception")]
            Exception = 1,

            /// <summary>
            /// Enum Unexpectederror for value: unexpected_error
            /// </summary>
            [EnumMember(Value = "unexpected_error")]
            Unexpectederror = 2,

            /// <summary>
            /// Enum Invalidtopupamount for value: invalid_topup_amount
            /// </summary>
            [EnumMember(Value = "invalid_topup_amount")]
            Invalidtopupamount = 3,

            /// <summary>
            /// Enum Invalidphonenumberordifferentcompany for value: invalid_phone_number_or_different_company
            /// </summary>
            [EnumMember(Value = "invalid_phone_number_or_different_company")]
            Invalidphonenumberordifferentcompany = 4,

            /// <summary>
            /// Enum Invalidbiller for value: invalid_biller
            /// </summary>
            [EnumMember(Value = "invalid_biller")]
            Invalidbiller = 5,

            /// <summary>
            /// Enum Insufficientaccountbalance for value: insufficient_account_balance
            /// </summary>
            [EnumMember(Value = "insufficient_account_balance")]
            Insufficientaccountbalance = 6,

            /// <summary>
            /// Enum Dailytopuplimitexceeded for value: daily_topup_limit_exceeded
            /// </summary>
            [EnumMember(Value = "daily_topup_limit_exceeded")]
            Dailytopuplimitexceeded = 7,

            /// <summary>
            /// Enum Billerunavailable for value: biller_unavailable
            /// </summary>
            [EnumMember(Value = "biller_unavailable")]
            Billerunavailable = 8,

            /// <summary>
            /// Enum Billertimeout for value: biller_timeout
            /// </summary>
            [EnumMember(Value = "biller_timeout")]
            Billertimeout = 9,

            /// <summary>
            /// Enum Phoneinactive for value: phone_inactive
            /// </summary>
            [EnumMember(Value = "phone_inactive")]
            Phoneinactive = 10

        }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failure_reason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Topup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="phone">phone.</param>
        /// <param name="topupBillerId">topupBillerId.</param>
        /// <param name="branchId">branchId.</param>
        /// <param name="posId">posId.</param>
        /// <param name="authorizationNumber">authorizationNumber.</param>
        /// <param name="ticketText">ticketText.</param>
        public Topup(Guid id = default(Guid), string externalId = default(string), float amount = default(float), StatusEnum? status = default(StatusEnum?), FailureReasonEnum? failureReason = default(FailureReasonEnum?), string phone = default(string), Guid topupBillerId = default(Guid), Guid branchId = default(Guid), string posId = default(string), string authorizationNumber = default(string), string ticketText = default(string))
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.Amount = amount;
            this.Status = status;
            this.FailureReason = failureReason;
            this.Phone = phone;
            this.TopupBillerId = topupBillerId;
            this.BranchId = branchId;
            this.PosId = posId;
            this.AuthorizationNumber = authorizationNumber;
            this.TicketText = ticketText;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float Amount { get; set; }



        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets TopupBillerId
        /// </summary>
        [DataMember(Name="topup_biller_id", EmitDefaultValue=false)]
        public Guid TopupBillerId { get; set; }

        /// <summary>
        /// Gets or Sets BranchId
        /// </summary>
        [DataMember(Name="branch_id", EmitDefaultValue=false)]
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or Sets PosId
        /// </summary>
        [DataMember(Name="pos_id", EmitDefaultValue=false)]
        public string PosId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationNumber
        /// </summary>
        [DataMember(Name="authorization_number", EmitDefaultValue=false)]
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// Gets or Sets TicketText
        /// </summary>
        [DataMember(Name="ticket_text", EmitDefaultValue=false)]
        public string TicketText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Topup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  TopupBillerId: ").Append(TopupBillerId).Append("\n");
            sb.Append("  BranchId: ").Append(BranchId).Append("\n");
            sb.Append("  PosId: ").Append(PosId).Append("\n");
            sb.Append("  AuthorizationNumber: ").Append(AuthorizationNumber).Append("\n");
            sb.Append("  TicketText: ").Append(TicketText).Append("\n");
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
            return this.Equals(input as Topup);
        }

        /// <summary>
        /// Returns true if Topup instances are equal
        /// </summary>
        /// <param name="input">Instance of Topup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Topup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.TopupBillerId == input.TopupBillerId ||
                    (this.TopupBillerId != null &&
                    this.TopupBillerId.Equals(input.TopupBillerId))
                ) && 
                (
                    this.BranchId == input.BranchId ||
                    (this.BranchId != null &&
                    this.BranchId.Equals(input.BranchId))
                ) && 
                (
                    this.PosId == input.PosId ||
                    (this.PosId != null &&
                    this.PosId.Equals(input.PosId))
                ) && 
                (
                    this.AuthorizationNumber == input.AuthorizationNumber ||
                    (this.AuthorizationNumber != null &&
                    this.AuthorizationNumber.Equals(input.AuthorizationNumber))
                ) && 
                (
                    this.TicketText == input.TicketText ||
                    (this.TicketText != null &&
                    this.TicketText.Equals(input.TicketText))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.TopupBillerId != null)
                    hashCode = hashCode * 59 + this.TopupBillerId.GetHashCode();
                if (this.BranchId != null)
                    hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                if (this.PosId != null)
                    hashCode = hashCode * 59 + this.PosId.GetHashCode();
                if (this.AuthorizationNumber != null)
                    hashCode = hashCode * 59 + this.AuthorizationNumber.GetHashCode();
                if (this.TicketText != null)
                    hashCode = hashCode * 59 + this.TicketText.GetHashCode();
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
