namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Possible values for prompting user for samples submission.</summary>
    public enum DefenderPromptForSampleSubmission {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Always prompt.</summary>
        AlwaysPrompt,
        /// <summary>Send safe samples automatically.</summary>
        PromptBeforeSendingPersonalData,
        /// <summary>Never send data.</summary>
        NeverSendData,
        /// <summary>Send all data without prompting.</summary>
        SendAllDataWithoutPrompting,
    }
}
