namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>State of the action on the device</summary>
    public enum ActionState {
        /// <summary>Not a valid action state</summary>
        None,
        /// <summary>Action is pending</summary>
        Pending,
        /// <summary>Action has been cancelled.</summary>
        Canceled,
        /// <summary>Action is active.</summary>
        Active,
        /// <summary>Action completed without errors.</summary>
        Done,
        /// <summary>Action failed</summary>
        Failed,
        /// <summary>Action is not supported.</summary>
        NotSupported,
    }
}
