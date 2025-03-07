namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Type of start menu app list visibility.</summary>
    public enum WindowsStartMenuAppListVisibilityType {
        /// <summary>User defined. Default value.</summary>
        UserDefined,
        /// <summary>Collapse the app list on the start menu.</summary>
        Collapse,
        /// <summary>Removes the app list entirely from the start menu.</summary>
        Remove,
        /// <summary>Disables the corresponding toggle (Collapse or Remove) in the Settings app.</summary>
        DisableSettingsApp,
    }
}
