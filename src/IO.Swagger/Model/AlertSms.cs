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
    /// AlertSms
    /// </summary>
    [DataContract]
        public partial class AlertSms :  IEquatable<AlertSms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertSms" /> class.
        /// </summary>
        /// <param name="alertTemplateName">the name of the alert template to use. Already has to exist in the system. (required).</param>
        /// <param name="senderId">the id to identify the sender. (required).</param>
        /// <param name="to">a list of recipients of the alert. (required).</param>
        public AlertSms(string alertTemplateName = default(string), string senderId = default(string), List<ToSmsAlertObject> to = default(List<ToSmsAlertObject>))
        {
            // to ensure "alertTemplateName" is required (not null)
            if (alertTemplateName == null)
            {
                throw new InvalidDataException("alertTemplateName is a required property for AlertSms and cannot be null");
            }
            else
            {
                this.AlertTemplateName = alertTemplateName;
            }
            // to ensure "senderId" is required (not null)
            if (senderId == null)
            {
                throw new InvalidDataException("senderId is a required property for AlertSms and cannot be null");
            }
            else
            {
                this.SenderId = senderId;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for AlertSms and cannot be null");
            }
            else
            {
                this.To = to;
            }
        }
        
        /// <summary>
        /// the name of the alert template to use. Already has to exist in the system.
        /// </summary>
        /// <value>the name of the alert template to use. Already has to exist in the system.</value>
        [DataMember(Name="alertTemplateName", EmitDefaultValue=false)]
        public string AlertTemplateName { get; set; }

        /// <summary>
        /// the id to identify the sender.
        /// </summary>
        /// <value>the id to identify the sender.</value>
        [DataMember(Name="senderId", EmitDefaultValue=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// a list of recipients of the alert.
        /// </summary>
        /// <value>a list of recipients of the alert.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<ToSmsAlertObject> To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertSms {\n");
            sb.Append("  AlertTemplateName: ").Append(AlertTemplateName).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as AlertSms);
        }

        /// <summary>
        /// Returns true if AlertSms instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertSms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertSms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertTemplateName == input.AlertTemplateName ||
                    (this.AlertTemplateName != null &&
                    this.AlertTemplateName.Equals(input.AlertTemplateName))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
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
                if (this.AlertTemplateName != null)
                    hashCode = hashCode * 59 + this.AlertTemplateName.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
