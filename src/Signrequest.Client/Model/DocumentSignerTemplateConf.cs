/* 
 * SignRequest API
 *
 * API for SignRequest.com
 *
 * OpenAPI spec version: v1
 * Contact: tech-support@signrequest.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Signrequest.Client.Client.SwaggerDateConverter;

namespace Signrequest.Client.Model
{
    /// <summary>
    /// DocumentSignerTemplateConf
    /// </summary>
    [DataContract]
    public partial class DocumentSignerTemplateConf :  IEquatable<DocumentSignerTemplateConf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSignerTemplateConf" /> class.
        /// </summary>
        /// <param name="SignerIndex">SignerIndex.</param>
        /// <param name="NeedsToSign">NeedsToSign.</param>
        /// <param name="ApproveOnly">ApproveOnly.</param>
        /// <param name="NotifyOnly">NotifyOnly.</param>
        /// <param name="InPerson">InPerson.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Placeholders">Placeholders.</param>
        public DocumentSignerTemplateConf(int? SignerIndex = default(int?), bool? NeedsToSign = default(bool?), bool? ApproveOnly = default(bool?), bool? NotifyOnly = default(bool?), bool? InPerson = default(bool?), int? Order = default(int?), List<Placeholder> Placeholders = default(List<Placeholder>))
        {
            this.SignerIndex = SignerIndex;
            this.NeedsToSign = NeedsToSign;
            this.ApproveOnly = ApproveOnly;
            this.NotifyOnly = NotifyOnly;
            this.InPerson = InPerson;
            this.Order = Order;
            this.Placeholders = Placeholders;
        }
        
        /// <summary>
        /// Gets or Sets SignerIndex
        /// </summary>
        [DataMember(Name="signer_index", EmitDefaultValue=false)]
        public int? SignerIndex { get; set; }

        /// <summary>
        /// Gets or Sets NeedsToSign
        /// </summary>
        [DataMember(Name="needs_to_sign", EmitDefaultValue=false)]
        public bool? NeedsToSign { get; set; }

        /// <summary>
        /// Gets or Sets ApproveOnly
        /// </summary>
        [DataMember(Name="approve_only", EmitDefaultValue=false)]
        public bool? ApproveOnly { get; set; }

        /// <summary>
        /// Gets or Sets NotifyOnly
        /// </summary>
        [DataMember(Name="notify_only", EmitDefaultValue=false)]
        public bool? NotifyOnly { get; set; }

        /// <summary>
        /// Gets or Sets InPerson
        /// </summary>
        [DataMember(Name="in_person", EmitDefaultValue=false)]
        public bool? InPerson { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Placeholders
        /// </summary>
        [DataMember(Name="placeholders", EmitDefaultValue=false)]
        public List<Placeholder> Placeholders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSignerTemplateConf {\n");
            sb.Append("  SignerIndex: ").Append(SignerIndex).Append("\n");
            sb.Append("  NeedsToSign: ").Append(NeedsToSign).Append("\n");
            sb.Append("  ApproveOnly: ").Append(ApproveOnly).Append("\n");
            sb.Append("  NotifyOnly: ").Append(NotifyOnly).Append("\n");
            sb.Append("  InPerson: ").Append(InPerson).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Placeholders: ").Append(Placeholders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as DocumentSignerTemplateConf);
        }

        /// <summary>
        /// Returns true if DocumentSignerTemplateConf instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentSignerTemplateConf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSignerTemplateConf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignerIndex == input.SignerIndex ||
                    (this.SignerIndex != null &&
                    this.SignerIndex.Equals(input.SignerIndex))
                ) && 
                (
                    this.NeedsToSign == input.NeedsToSign ||
                    (this.NeedsToSign != null &&
                    this.NeedsToSign.Equals(input.NeedsToSign))
                ) && 
                (
                    this.ApproveOnly == input.ApproveOnly ||
                    (this.ApproveOnly != null &&
                    this.ApproveOnly.Equals(input.ApproveOnly))
                ) && 
                (
                    this.NotifyOnly == input.NotifyOnly ||
                    (this.NotifyOnly != null &&
                    this.NotifyOnly.Equals(input.NotifyOnly))
                ) && 
                (
                    this.InPerson == input.InPerson ||
                    (this.InPerson != null &&
                    this.InPerson.Equals(input.InPerson))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Placeholders == input.Placeholders ||
                    this.Placeholders != null &&
                    this.Placeholders.SequenceEqual(input.Placeholders)
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
                if (this.SignerIndex != null)
                    hashCode = hashCode * 59 + this.SignerIndex.GetHashCode();
                if (this.NeedsToSign != null)
                    hashCode = hashCode * 59 + this.NeedsToSign.GetHashCode();
                if (this.ApproveOnly != null)
                    hashCode = hashCode * 59 + this.ApproveOnly.GetHashCode();
                if (this.NotifyOnly != null)
                    hashCode = hashCode * 59 + this.NotifyOnly.GetHashCode();
                if (this.InPerson != null)
                    hashCode = hashCode * 59 + this.InPerson.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Placeholders != null)
                    hashCode = hashCode * 59 + this.Placeholders.GetHashCode();
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
            // SignerIndex (int?) maximum
            if(this.SignerIndex > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerIndex, must be a value less than or equal to 2147483647.", new [] { "SignerIndex" });
            }

            // SignerIndex (int?) minimum
            if(this.SignerIndex < (int?)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerIndex, must be a value greater than or equal to -2147483648.", new [] { "SignerIndex" });
            }

            // Order (int?) maximum
            if(this.Order > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value less than or equal to 2147483647.", new [] { "Order" });
            }

            // Order (int?) minimum
            if(this.Order < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value greater than or equal to 0.", new [] { "Order" });
            }

            yield break;
        }
    }

}
