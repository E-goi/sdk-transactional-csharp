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
    /// WebhookEmail
    /// </summary>
    [DataContract]
        public partial class WebhookEmail :  IEquatable<WebhookEmail>, IValidatableObject
    {
        /// <summary>
        /// The channel of the webhook.
        /// </summary>
        /// <value>The channel of the webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ChannelEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1        }
        /// <summary>
        /// The channel of the webhook.
        /// </summary>
        /// <value>The channel of the webhook.</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum Channel { get; set; }
        /// <summary>
        /// the action to capture.
        /// </summary>
        /// <value>the action to capture.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionsEnum
        {
            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 1,
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 2,
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 3,
            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 4,
            /// <summary>
            /// Enum Click for value: click
            /// </summary>
            [EnumMember(Value = "click")]
            Click = 5,
            /// <summary>
            /// Enum View for value: view
            /// </summary>
            [EnumMember(Value = "view")]
            View = 6,
            /// <summary>
            /// Enum Remove for value: remove
            /// </summary>
            [EnumMember(Value = "remove")]
            Remove = 7,
            /// <summary>
            /// Enum Bounce for value: bounce
            /// </summary>
            [EnumMember(Value = "bounce")]
            Bounce = 8,
            /// <summary>
            /// Enum Abuse for value: abuse
            /// </summary>
            [EnumMember(Value = "abuse")]
            Abuse = 9        }
        /// <summary>
        /// A list of the actions to capture.
        /// </summary>
        /// <value>A list of the actions to capture.</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEmail" /> class.
        /// </summary>
        /// <param name="url">The url to send the Events. (required).</param>
        /// <param name="channel">The channel of the webhook. (required).</param>
        /// <param name="actions">A list of the actions to capture..</param>
        public WebhookEmail(string url = default(string), ChannelEnum channel = default(ChannelEnum), List<ActionsEnum> actions = default(List<ActionsEnum>))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for WebhookEmail and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new InvalidDataException("channel is a required property for WebhookEmail and cannot be null");
            }
            else
            {
                this.Channel = channel;
            }
            this.Actions = actions;
        }
        
        /// <summary>
        /// The url to send the Events.
        /// </summary>
        /// <value>The url to send the Events.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEmail {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as WebhookEmail);
        }

        /// <summary>
        /// Returns true if WebhookEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEmail input)
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
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
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
