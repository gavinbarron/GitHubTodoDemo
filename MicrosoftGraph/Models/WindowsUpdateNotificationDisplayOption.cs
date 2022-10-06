namespace GithubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public enum WindowsUpdateNotificationDisplayOption {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Use the default Windows Update notifications.</summary>
        DefaultNotifications,
        /// <summary>Turn off all notifications, excluding restart warnings.</summary>
        RestartWarningsOnly,
        /// <summary>Turn off all notifications, including restart warnings.</summary>
        DisableAllNotifications,
        /// <summary>Evolvable enum member</summary>
        UnknownFutureValue,
    }
}
