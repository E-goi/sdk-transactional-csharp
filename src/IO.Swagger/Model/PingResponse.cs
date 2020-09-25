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
    /// PingResponse
    /// </summary>
    [DataContract]
        public partial class PingResponse :  IEquatable<PingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PingResponse" /> class.
        /// </summary>
        /// <param name="apiStatus">The current status of the Api..</param>
        /// <param name="date">The date of the request..</param>
        public PingResponse(string apiStatus = default(string), string date = default(string))
        {
            this.ApiStatus = apiStatus;
            this.Date = date;
        }
        
        /// <summary>
        /// The current status of the Api.
        /// </summary>
        /// <value>The current status of the Api.</value>
        [DataMember(Name="apiStatus", EmitDefaultValue=false)]
        public string ApiStatus { get; set; }

        /// <summary>
        /// The date of the request.
        /// </summary>
        /// <value>The date of the request.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PingResponse {\n");
            sb.Append("  ApiStatus: ").Append(ApiStatus).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as PingResponse);
        }

        /// <summary>
        /// Returns true if PingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiStatus == input.ApiStatus ||
                    (this.ApiStatus != null &&
                    this.ApiStatus.Equals(input.ApiStatus))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.ApiStatus != null)
                    hashCode = hashCode * 59 + this.ApiStatus.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
