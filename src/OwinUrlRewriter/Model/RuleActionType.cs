namespace OwinUrlRewriter.Model
{
    public enum RuleActionType
    {
        None,
        Rewrite,
        Redirect,
        AbortRequest,
        //CustomResponse
    }
}