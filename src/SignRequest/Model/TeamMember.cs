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
    /// TeamMember
    /// </summary>
    [DataContract]
    public partial class TeamMember :  IEquatable<TeamMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Team">Team.</param>
        /// <param name="IsAdmin">IsAdmin.</param>
        /// <param name="IsActive">IsActive.</param>
        /// <param name="IsOwner">IsOwner.</param>
        public TeamMember(User User = default(User), DocumentTeam Team = default(DocumentTeam), bool? IsAdmin = default(bool?), bool? IsActive = default(bool?), bool? IsOwner = default(bool?))
        {
            this.User = User;
            this.Team = Team;
            this.IsAdmin = IsAdmin;
            this.IsActive = IsActive;
            this.IsOwner = IsOwner;
        }
        
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public DocumentTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="is_admin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="is_owner", EmitDefaultValue=false)]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMember {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
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
            return this.Equals(input as TeamMember);
        }

        /// <summary>
        /// Returns true if TeamMember instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsOwner == input.IsOwner ||
                    (this.IsOwner != null &&
                    this.IsOwner.Equals(input.IsOwner))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsOwner != null)
                    hashCode = hashCode * 59 + this.IsOwner.GetHashCode();
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
            // Uuid (string) minLength
            if(this.Uuid != null && this.Uuid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uuid, length must be greater than 1.", new [] { "Uuid" });
            }

            yield break;
        }
    }

}