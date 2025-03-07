using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SimulationReport : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Overview of an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimulationReportOverview? Overview { get; set; }
#nullable restore
#else
        public SimulationReportOverview Overview { get; set; }
#endif
        /// <summary>The tenant users and their online actions in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSimulationDetails>? SimulationUsers { get; set; }
#nullable restore
#else
        public List<UserSimulationDetails> SimulationUsers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new simulationReport and sets the default values.
        /// </summary>
        public SimulationReport() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimulationReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"overview", n => { Overview = n.GetObjectValue<SimulationReportOverview>(SimulationReportOverview.CreateFromDiscriminatorValue); } },
                {"simulationUsers", n => { SimulationUsers = n.GetCollectionOfObjectValues<UserSimulationDetails>(UserSimulationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SimulationReportOverview>("overview", Overview);
            writer.WriteCollectionOfObjectValues<UserSimulationDetails>("simulationUsers", SimulationUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
