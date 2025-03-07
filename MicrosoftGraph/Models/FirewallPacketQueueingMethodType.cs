namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Possible values for firewallPacketQueueingMethod</summary>
    public enum FirewallPacketQueueingMethodType {
        /// <summary>No value configured by Intune, do not override the user-configured device default value</summary>
        DeviceDefault,
        /// <summary>Disable packet queuing</summary>
        Disabled,
        /// <summary>Queue inbound encrypted packets</summary>
        QueueInbound,
        /// <summary>Queue decrypted outbound packets for forwarding</summary>
        QueueOutbound,
        /// <summary>Queue both inbound and outbound packets</summary>
        QueueBoth,
    }
}
