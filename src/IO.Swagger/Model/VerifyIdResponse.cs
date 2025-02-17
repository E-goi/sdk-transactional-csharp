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
    /// VerifyIdResponse
    /// </summary>
    [DataContract]
        public partial class VerifyIdResponse :  IEquatable<VerifyIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyIdResponse" /> class.
        /// </summary>
        /// <param name="verifyId">The Id of the new Template..</param>
        public VerifyIdResponse(string verifyId = default(string))
        {
            this.VerifyId = verifyId;
        }
        
        /// <summary>
        /// The Id of the new Template.
        /// </summary>
        /// <value>The Id of the new Template.</value>
        [DataMember(Name="verifyId", EmitDefaultValue=false)]
        public string VerifyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyIdResponse {\n");
            sb.Append("  VerifyId: ").Append(VerifyId).Append("\n");
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
            return this.Equals(input as VerifyIdResponse);
        }

        /// <summary>
        /// Returns true if VerifyIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerifyId == input.VerifyId ||
                    (this.VerifyId != null &&
                    this.VerifyId.Equals(input.VerifyId))
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
                if (this.VerifyId != null)
                    hashCode = hashCode * 59 + this.VerifyId.GetHashCode();
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
