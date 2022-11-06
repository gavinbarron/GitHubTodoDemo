namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public enum ManagedAppClipboardSharingLevel {
        /// <summary>Sharing is allowed between all apps, managed or not</summary>
        AllApps,
        /// <summary>Sharing is allowed between all managed apps with paste in enabled</summary>
        ManagedAppsWithPasteIn,
        /// <summary>Sharing is allowed between all managed apps</summary>
        ManagedApps,
        /// <summary>Sharing between apps is disabled</summary>
        Blocked,
    }
}
