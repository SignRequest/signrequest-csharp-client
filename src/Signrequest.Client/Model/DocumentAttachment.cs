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
    /// DocumentAttachment
    /// </summary>
    [DataContract]
    public partial class DocumentAttachment :  IEquatable<DocumentAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentAttachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttachment" /> class.
        /// </summary>
        /// <param name="FileFromContent">Base64 encoded document content.</param>
        /// <param name="FileFromContentName">Filename, including extension. Required when using &#x60;file_from_content&#x60;..</param>
        /// <param name="FileFromUrl">Publicly accessible URL of document to be downloaded by SignRequest.</param>
        /// <param name="Document">Document (required).</param>
        public DocumentAttachment(string FileFromContent = default(string), string FileFromContentName = default(string), string FileFromUrl = default(string), string Document = default(string))
        {
            // to ensure "Document" is required (not null)
            if (Document == null)
            {
                throw new InvalidDataException("Document is a required property for DocumentAttachment and cannot be null");
            }
            else
            {
                this.Document = Document;
            }
            this.FileFromContent = FileFromContent;
            this.FileFromContentName = FileFromContentName;
            this.FileFromUrl = FileFromUrl;
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
        /// Defaults to filename
        /// </summary>
        /// <value>Defaults to filename</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Temporary URL to document attachment, expires in five minutes
        /// </summary>
        /// <value>Temporary URL to document attachment, expires in five minutes</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; private set; }

        /// <summary>
        /// Base64 encoded document content
        /// </summary>
        /// <value>Base64 encoded document content</value>
        [DataMember(Name="file_from_content", EmitDefaultValue=false)]
        public string FileFromContent { get; set; }

        /// <summary>
        /// Filename, including extension. Required when using &#x60;file_from_content&#x60;.
        /// </summary>
        /// <value>Filename, including extension. Required when using &#x60;file_from_content&#x60;.</value>
        [DataMember(Name="file_from_content_name", EmitDefaultValue=false)]
        public string FileFromContentName { get; set; }

        /// <summary>
        /// Publicly accessible URL of document to be downloaded by SignRequest
        /// </summary>
        /// <value>Publicly accessible URL of document to be downloaded by SignRequest</value>
        [DataMember(Name="file_from_url", EmitDefaultValue=false)]
        public string FileFromUrl { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public string Document { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentAttachment {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileFromContent: ").Append(FileFromContent).Append("\n");
            sb.Append("  FileFromContentName: ").Append(FileFromContentName).Append("\n");
            sb.Append("  FileFromUrl: ").Append(FileFromUrl).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
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
            return this.Equals(input as DocumentAttachment);
        }

        /// <summary>
        /// Returns true if DocumentAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentAttachment input)
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
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.FileFromContent == input.FileFromContent ||
                    (this.FileFromContent != null &&
                    this.FileFromContent.Equals(input.FileFromContent))
                ) && 
                (
                    this.FileFromContentName == input.FileFromContentName ||
                    (this.FileFromContentName != null &&
                    this.FileFromContentName.Equals(input.FileFromContentName))
                ) && 
                (
                    this.FileFromUrl == input.FileFromUrl ||
                    (this.FileFromUrl != null &&
                    this.FileFromUrl.Equals(input.FileFromUrl))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.FileFromContent != null)
                    hashCode = hashCode * 59 + this.FileFromContent.GetHashCode();
                if (this.FileFromContentName != null)
                    hashCode = hashCode * 59 + this.FileFromContentName.GetHashCode();
                if (this.FileFromUrl != null)
                    hashCode = hashCode * 59 + this.FileFromUrl.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
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

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // FileFromUrl (string) maxLength
            if(this.FileFromUrl != null && this.FileFromUrl.Length > 2100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileFromUrl, length must be less than 2100.", new [] { "FileFromUrl" });
            }

            yield break;
        }
    }

}
