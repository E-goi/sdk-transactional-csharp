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
    /// a list of recipients of the alert.
    /// </summary>
    [DataContract]
        public partial class ToSmsAlertObject :  IEquatable<ToSmsAlertObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToSmsAlertObject" /> class.
        /// </summary>
        /// <param name="phone">the email of the recipient. (required).</param>
        /// <param name="mergeTags">mergeTags.</param>
        public ToSmsAlertObject(string phone = default(string), List<string> mergeTags = default(List<string>))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for ToSmsAlertObject and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            this.MergeTags = mergeTags;
        }
        
        /// <summary>
        /// the email of the recipient.
        /// </summary>
        /// <value>the email of the recipient.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets MergeTags
        /// </summary>
        [DataMember(Name="mergeTags", EmitDefaultValue=false)]
        public List<string> MergeTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToSmsAlertObject {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  MergeTags: ").Append(MergeTags).Append("\n");
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
            return this.Equals(input as ToSmsAlertObject);
        }

        /// <summary>
        /// Returns true if ToSmsAlertObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ToSmsAlertObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToSmsAlertObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.MergeTags == input.MergeTags ||
                    this.MergeTags != null &&
                    input.MergeTags != null &&
                    this.MergeTags.SequenceEqual(input.MergeTags)
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.MergeTags != null)
                    hashCode = hashCode * 59 + this.MergeTags.GetHashCode();
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
