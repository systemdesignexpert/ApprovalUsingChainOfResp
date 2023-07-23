public class DirectorHandler : ApprovalHandler
{
    public DirectorHandler()
    {
        ApprovalLimit = 50000;
    }

    public override bool ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount > Constants.MAX_LIMIT)
        {
            Console.WriteLine("Request amount higher than limit, REJECTED");
            return false;
        }
        if (request.Amount <= ApprovalLimit)
        {
            Console.WriteLine("Director approved the purchase request.");
            return true;
        }
        if (NextHandler != null)
        {
            Console.WriteLine("Director approved the request, but it requires further approval.");
            return NextHandler.ProcessRequest(request);
        }

        Console.WriteLine("Director rejected the request.");
        return false;
    }
}
