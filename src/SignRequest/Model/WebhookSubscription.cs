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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = SignRequest.Client.SwaggerDateConverter;

namespace SignRequest.Model
{
    /// <summary>
    /// WebhookSubscription
    /// </summary>
    [DataContract]
    public partial class WebhookSubscription :  IEquatable<WebhookSubscription>
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum Converterror for value: convert_error
            /// </summary>
            [EnumMember(Value = "convert_error")]
            Converterror = 1,
            
            /// <summary>
            /// Enum Converted for value: converted
            /// </summary>
            [EnumMember(Value = "converted")]
            Converted = 2,
            
            /// <summary>
            /// Enum Sendingerror for value: sending_error
            /// </summary>
            [EnumMember(Value = "sending_error")]
            Sendingerror = 3,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 4,
            
            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 5,
            
            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 6,
            
            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 7,
            
            /// <summary>
            /// Enum Signed for value: signed
            /// </summary>
            [EnumMember(Value = "signed")]
            Signed = 8,
            
            /// <summary>
            /// Enum Viewed for value: viewed
            /// </summary>
            [EnumMember(Value = "viewed")]
            Viewed = 9,
            
            /// <summary>
            /// Enum Downloaded for value: downloaded
            /// </summary>
            [EnumMember(Value = "downloaded")]
            Downloaded = 10,
            
            /// <summary>
            /// Enum Signersigned for value: signer_signed
            /// </summary>
            [EnumMember(Value = "signer_signed")]
            Signersigned = 11,
            
            /// <summary>
            /// Enum Signeremailbounced for value: signer_email_bounced
            /// </summary>
            [EnumMember(Value = "signer_email_bounced")]
            Signeremailbounced = 12,
            
            /// <summary>
            /// Enum Signerviewedemail for value: signer_viewed_email
            /// </summary>
            [EnumMember(Value = "signer_viewed_email")]
            Signerviewedemail = 13,
            
            /// <summary>
            /// Enum Signerviewed for value: signer_viewed
            /// </summary>
            [EnumMember(Value = "signer_viewed")]
            Signerviewed = 14,
            
            /// <summary>
            /// Enum Signerforwarded for value: signer_forwarded
            /// </summary>
            [EnumMember(Value = "signer_forwarded")]
            Signerforwarded = 15,
            
            /// <summary>
            /// Enum Signerdownloaded for value: signer_downloaded
            /// </summary>
            [EnumMember(Value = "signer_downloaded")]
            Signerdownloaded = 16,
            
            /// <summary>
            /// Enum Signrequestreceived for value: signrequest_received
            /// </summary>
            [EnumMember(Value = "signrequest_received")]
            Signrequestreceived = 17
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Defines Integration
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntegrationEnum
        {
            
            /// <summary>
            /// Enum Mfiles for value: mfiles
            /// </summary>
            [EnumMember(Value = "mfiles")]
            Mfiles = 1,
            
            /// <summary>
            /// Enum Salesforce for value: salesforce
            /// </summary>
            [EnumMember(Value = "salesforce")]
            Salesforce = 2,
            
            /// <summary>
            /// Enum Formdesk for value: formdesk
            /// </summary>
            [EnumMember(Value = "formdesk")]
            Formdesk = 3,
            
            /// <summary>
            /// Enum Zapier for value: zapier
            /// </summary>
            [EnumMember(Value = "zapier")]
            Zapier = 4,
            
            /// <summary>
            /// Enum Txhash for value: txhash
            /// </summary>
            [EnumMember(Value = "txhash")]
            Txhash = 5
        }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public IntegrationEnum? Integration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscription" /> class.
        /// </summary>
        /// <param name="name">Optional name to easily identify what webhook is used for.</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="callbackUrl">callbackUrl (required).</param>
        /// <param name="integration">integration.</param>
        /// <param name="team">team.</param>
        public WebhookSubscription(string name = default(string), EventTypeEnum eventType = default(EventTypeEnum), string callbackUrl = default(string), IntegrationEnum? integration = default(IntegrationEnum?), DocumentTeam team = default(DocumentTeam))
        {
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for WebhookSubscription and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new InvalidDataException("callbackUrl is a required property for WebhookSubscription and cannot be null");
            }
            else
            {
                this.CallbackUrl = callbackUrl;
            }
            this.Name = name;
            this.Integration = integration;
            this.Team = team;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Optional name to easily identify what webhook is used for
        /// </summary>
        /// <value>Optional name to easily identify what webhook is used for</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }


        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public DocumentTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSubscription {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as WebhookSubscription);
        }

        /// <summary>
        /// Returns true if WebhookSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                return hashCode;
            }
        }
    }

}
