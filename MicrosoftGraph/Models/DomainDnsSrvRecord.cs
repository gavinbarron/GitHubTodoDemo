using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class DomainDnsSrvRecord : DomainDnsRecord, IParsable {
        /// <summary>Value to use when configuring the Target property of the SRV record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NameTarget { get; set; }
#nullable restore
#else
        public string NameTarget { get; set; }
#endif
        /// <summary>Value to use when configuring the port property of the SRV record at the DNS host.</summary>
        public int? Port { get; set; }
        /// <summary>Value to use when configuring the priority property of the SRV record at the DNS host.</summary>
        public int? Priority { get; set; }
        /// <summary>Value to use when configuring the protocol property of the SRV record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Protocol { get; set; }
#nullable restore
#else
        public string Protocol { get; set; }
#endif
        /// <summary>Value to use when configuring the service property of the SRV record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service { get; set; }
#nullable restore
#else
        public string Service { get; set; }
#endif
        /// <summary>Value to use when configuring the weight property of the SRV record at the DNS host.</summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DomainDnsSrvRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainDnsSrvRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"nameTarget", n => { NameTarget = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"protocol", n => { Protocol = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"weight", n => { Weight = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("nameTarget", NameTarget);
            writer.WriteIntValue("port", Port);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("protocol", Protocol);
            writer.WriteStringValue("service", Service);
            writer.WriteIntValue("weight", Weight);
        }
    }
}
