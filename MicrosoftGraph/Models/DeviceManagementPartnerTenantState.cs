namespace GithubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public enum DeviceManagementPartnerTenantState {
        /// <summary>Partner state is unknown.</summary>
        Unknown,
        /// <summary>Partner is unavailable.</summary>
        Unavailable,
        /// <summary>Partner is enabled.</summary>
        Enabled,
        /// <summary>Partner connection is terminated.</summary>
        Terminated,
        /// <summary>Partner messages are rejected.</summary>
        Rejected,
        /// <summary>Partner is unresponsive.</summary>
        Unresponsive,
    }
}
