namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Which branch devices will receive their updates from</summary>
    public enum WindowsUpdateType {
        /// <summary>Allow the user to set.</summary>
        UserDefined,
        /// <summary>Semi-annual Channel (Targeted). Device gets all applicable feature updates from Semi-annual Channel (Targeted).</summary>
        All,
        /// <summary>Semi-annual Channel. Device gets feature updates from Semi-annual Channel.</summary>
        BusinessReadyOnly,
        /// <summary>Windows Insider build - Fast</summary>
        WindowsInsiderBuildFast,
        /// <summary>Windows Insider build - Slow</summary>
        WindowsInsiderBuildSlow,
        /// <summary>Release Windows Insider build</summary>
        WindowsInsiderBuildRelease,
    }
}
