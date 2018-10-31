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
    /// SignerInputs
    /// </summary>
    [DataContract]
    public partial class SignerInputs :  IEquatable<SignerInputs>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum S for value: s
            /// </summary>
            [EnumMember(Value = "s")]
            S = 1,
            
            /// <summary>
            /// Enum I for value: i
            /// </summary>
            [EnumMember(Value = "i")]
            I = 2,
            
            /// <summary>
            /// Enum N for value: n
            /// </summary>
            [EnumMember(Value = "n")]
            N = 3,
            
            /// <summary>
            /// Enum D for value: d
            /// </summary>
            [EnumMember(Value = "d")]
            D = 4,
            
            /// <summary>
            /// Enum T for value: t
            /// </summary>
            [EnumMember(Value = "t")]
            T = 5,
            
            /// <summary>
            /// Enum C for value: c
            /// </summary>
            [EnumMember(Value = "c")]
            C = 6
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignerInputs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignerInputs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignerInputs" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="PageIndex">PageIndex (required).</param>
        /// <param name="Text">Text.</param>
        /// <param name="CheckboxValue">CheckboxValue.</param>
        /// <param name="DateValue">DateValue.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="PlaceholderUuid">PlaceholderUuid.</param>
        public SignerInputs(TypeEnum? Type = default(TypeEnum?), int? PageIndex = default(int?), string Text = default(string), bool? CheckboxValue = default(bool?), DateTime? DateValue = default(DateTime?), string ExternalId = default(string), string PlaceholderUuid = default(string))
        {
            // to ensure "PageIndex" is required (not null)
            if (PageIndex == null)
            {
                throw new InvalidDataException("PageIndex is a required property for SignerInputs and cannot be null");
            }
            else
            {
                this.PageIndex = PageIndex;
            }
            this.Type = Type;
            this.Text = Text;
            this.CheckboxValue = CheckboxValue;
            this.DateValue = DateValue;
            this.ExternalId = ExternalId;
            this.PlaceholderUuid = PlaceholderUuid;
        }
        

        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name="page_index", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

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
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets PlaceholderUuid
        /// </summary>
        [DataMember(Name="placeholder_uuid", EmitDefaultValue=false)]
        public string PlaceholderUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignerInputs {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  CheckboxValue: ").Append(CheckboxValue).Append("\n");
            sb.Append("  DateValue: ").Append(DateValue).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  PlaceholderUuid: ").Append(PlaceholderUuid).Append("\n");
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
            return this.Equals(input as SignerInputs);
        }

        /// <summary>
        /// Returns true if SignerInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of SignerInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerInputs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    (this.PageIndex != null &&
                    this.PageIndex.Equals(input.PageIndex))
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
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.PlaceholderUuid == input.PlaceholderUuid ||
                    (this.PlaceholderUuid != null &&
                    this.PlaceholderUuid.Equals(input.PlaceholderUuid))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PageIndex != null)
                    hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.CheckboxValue != null)
                    hashCode = hashCode * 59 + this.CheckboxValue.GetHashCode();
                if (this.DateValue != null)
                    hashCode = hashCode * 59 + this.DateValue.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.PlaceholderUuid != null)
                    hashCode = hashCode * 59 + this.PlaceholderUuid.GetHashCode();
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

            // PlaceholderUuid (string) maxLength
            if(this.PlaceholderUuid != null && this.PlaceholderUuid.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlaceholderUuid, length must be less than 36.", new [] { "PlaceholderUuid" });
            }

            yield break;
        }
    }

}