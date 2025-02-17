/* 
 * Transactional API
 *
 * # Introduction    This API is a service provided by [E-goi](www.e-goi.com) to send transactional messages.    Transactional Messaging is a 1-to-1 communication channel, usually from an organization directed to a specific consumer.   They can be triggered by:    * __Actions__ - The consumer interacts with the organization (ie.: online shopping);  * __Time__ - The consumer's actions are time-bounded by the organization (ie.: period of inactivity).    Because of the nature of these messages,   it is expected that the consumer is interested in the content of these messages.   Therefore, they have a different treatment from marketing messages, and have a higher acceptance and opening rate.    >DISCLAIMER  >  >Please notice that this platform is more delicate in regards to the nature and processing of its messages.  >  >It should NOT be used as a mean of mass marketing, scams, phishing or overall unruly behaviour.   >  >Failure to comply may lead to limitation of use and even termination of account.    ***
 *
 * OpenAPI spec version: V2
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// EmailValidatorRequest
    /// </summary>
    [DataContract]
        public partial class EmailValidatorRequest :  IEquatable<EmailValidatorRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidatorRequest" /> class.
        /// </summary>
        /// <param name="email">Email Address (required).</param>
        /// <param name="isMx">Enable, disable MX validation.</param>
        /// <param name="isTemporaryEmail">Enable, disable MX validation.</param>
        public EmailValidatorRequest(string email = default(string), bool? isMx = default(bool?), bool? isTemporaryEmail = default(bool?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for EmailValidatorRequest and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.IsMx = isMx;
            this.IsTemporaryEmail = isTemporaryEmail;
        }
        
        /// <summary>
        /// Email Address
        /// </summary>
        /// <value>Email Address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Enable, disable MX validation
        /// </summary>
        /// <value>Enable, disable MX validation</value>
        [DataMember(Name="isMx", EmitDefaultValue=false)]
        public bool? IsMx { get; set; }

        /// <summary>
        /// Enable, disable MX validation
        /// </summary>
        /// <value>Enable, disable MX validation</value>
        [DataMember(Name="isTemporaryEmail", EmitDefaultValue=false)]
        public bool? IsTemporaryEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidatorRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsMx: ").Append(IsMx).Append("\n");
            sb.Append("  IsTemporaryEmail: ").Append(IsTemporaryEmail).Append("\n");
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
            return this.Equals(input as EmailValidatorRequest);
        }

        /// <summary>
        /// Returns true if EmailValidatorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailValidatorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailValidatorRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IsMx == input.IsMx ||
                    (this.IsMx != null &&
                    this.IsMx.Equals(input.IsMx))
                ) && 
                (
                    this.IsTemporaryEmail == input.IsTemporaryEmail ||
                    (this.IsTemporaryEmail != null &&
                    this.IsTemporaryEmail.Equals(input.IsTemporaryEmail))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.IsMx != null)
                    hashCode = hashCode * 59 + this.IsMx.GetHashCode();
                if (this.IsTemporaryEmail != null)
                    hashCode = hashCode * 59 + this.IsTemporaryEmail.GetHashCode();
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
