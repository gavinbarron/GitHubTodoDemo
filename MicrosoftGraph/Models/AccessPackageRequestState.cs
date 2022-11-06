namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public enum AccessPackageRequestState {
        Submitted,
        PendingApproval,
        Delivering,
        Delivered,
        DeliveryFailed,
        Denied,
        Scheduled,
        Canceled,
        PartiallyDelivered,
        UnknownFutureValue,
    }
}
