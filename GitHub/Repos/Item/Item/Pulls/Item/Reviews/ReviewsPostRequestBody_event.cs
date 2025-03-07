namespace GitHubTodoDemo.GitHub.Repos.Item.Item.Pulls.Item.Reviews {
    /// <summary>The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/reference/pulls#submit-a-review-for-a-pull-request) when you are ready.</summary>
    public enum ReviewsPostRequestBody_event {
        APPROVE,
        REQUEST_CHANGES,
        COMMENT,
    }
}
