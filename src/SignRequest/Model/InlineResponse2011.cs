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
    /// InlineResponse2011
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011 :  IEquatable<InlineResponse2011>, IValidatableObject
    {
        /// <summary>
        /// Defines Detail
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DetailEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1
        }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public DetailEnum Detail { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2011() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011" /> class.
        /// </summary>
        /// <param name="Detail">Detail (required).</param>
        public InlineResponse2011(DetailEnum Detail = default(DetailEnum))
        {
            // to ensure "Detail" is required (not null)
            if (Detail == null)
            {
                throw new InvalidDataException("Detail is a required property for InlineResponse2011 and cannot be null");
            }
            else
            {
                this.Detail = Detail;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011 {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as InlineResponse2011);
        }

        /// <summary>
        /// Returns true if InlineResponse2011 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2011 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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