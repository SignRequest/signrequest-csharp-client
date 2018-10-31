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
    /// SigningLog
    /// </summary>
    [DataContract]
    public partial class SigningLog :  IEquatable<SigningLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SigningLog()
        {
        }
        
        /// <summary>
        /// Temporary URL to signing log, expires in five minutes
        /// </summary>
        /// <value>Temporary URL to signing log, expires in five minutes</value>
        [DataMember(Name="pdf", EmitDefaultValue=false)]
        public string Pdf { get; private set; }

        /// <summary>
        /// SHA256 hash of PDF contents
        /// </summary>
        /// <value>SHA256 hash of PDF contents</value>
        [DataMember(Name="security_hash", EmitDefaultValue=false)]
        public string SecurityHash { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningLog {\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  SecurityHash: ").Append(SecurityHash).Append("\n");
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
            return this.Equals(input as SigningLog);
        }

        /// <summary>
        /// Returns true if SigningLog instances are equal
        /// </summary>
        /// <param name="input">Instance of SigningLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pdf == input.Pdf ||
                    (this.Pdf != null &&
                    this.Pdf.Equals(input.Pdf))
                ) && 
                (
                    this.SecurityHash == input.SecurityHash ||
                    (this.SecurityHash != null &&
                    this.SecurityHash.Equals(input.SecurityHash))
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
                if (this.Pdf != null)
                    hashCode = hashCode * 59 + this.Pdf.GetHashCode();
                if (this.SecurityHash != null)
                    hashCode = hashCode * 59 + this.SecurityHash.GetHashCode();
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
            // SecurityHash (string) minLength
            if(this.SecurityHash != null && this.SecurityHash.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityHash, length must be greater than 1.", new [] { "SecurityHash" });
            }

            yield break;
        }
    }

}