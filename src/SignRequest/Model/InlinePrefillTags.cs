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
using SwaggerDateConverter = SignRequest.Client.SwaggerDateConverter;

namespace SignRequest.Model
{
    /// <summary>
    /// Prefill signer input data, see [prefill tags](#section/Preparing-a-document/Prefill-tags-templates)
    /// </summary>
    [DataContract]
    public partial class InlinePrefillTags :  IEquatable<InlinePrefillTags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlinePrefillTags" /> class.
        /// </summary>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="Text">Text.</param>
        /// <param name="CheckboxValue">CheckboxValue.</param>
        /// <param name="DateValue">DateValue.</param>
        public InlinePrefillTags(string ExternalId = default(string), string Text = default(string), bool? CheckboxValue = default(bool?), DateTime? DateValue = default(DateTime?))
        {
            this.ExternalId = ExternalId;
            this.Text = Text;
            this.CheckboxValue = CheckboxValue;
            this.DateValue = DateValue;
        }
        
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets CheckboxValue
        /// </summary>
        [DataMember(Name="checkbox_value", EmitDefaultValue=false)]
        public bool? CheckboxValue { get; set; }

        /// <summary>
        /// Gets or Sets DateValue
        /// </summary>
        [DataMember(Name="date_value", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlinePrefillTags {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  CheckboxValue: ").Append(CheckboxValue).Append("\n");
            sb.Append("  DateValue: ").Append(DateValue).Append("\n");
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
            return this.Equals(input as InlinePrefillTags);
        }

        /// <summary>
        /// Returns true if InlinePrefillTags instances are equal
        /// </summary>
        /// <param name="input">Instance of InlinePrefillTags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlinePrefillTags input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.CheckboxValue == input.CheckboxValue ||
                    (this.CheckboxValue != null &&
                    this.CheckboxValue.Equals(input.CheckboxValue))
                ) && 
                (
                    this.DateValue == input.DateValue ||
                    (this.DateValue != null &&
                    this.DateValue.Equals(input.DateValue))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.CheckboxValue != null)
                    hashCode = hashCode * 59 + this.CheckboxValue.GetHashCode();
                if (this.DateValue != null)
                    hashCode = hashCode * 59 + this.DateValue.GetHashCode();
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
            // ExternalId (string) maxLength
            if(this.ExternalId != null && this.ExternalId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, length must be less than 255.", new [] { "ExternalId" });
            }

            yield break;
        }
    }

}