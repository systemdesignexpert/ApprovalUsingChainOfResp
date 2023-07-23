public class VicePresidentHandler : ApprovalHandler
{
    public VicePresidentHandler()
    {
        ApprovalLimit = 500000;
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
            Console.WriteLine("VP approved the purchase request.");
            return true;
        }
        if (NextHandler != null)
        {
            Console.WriteLine("VP approved the request, but it requires further approval.");
            return NextHandler.ProcessRequest(request);
        }

        Console.WriteLine("VP rejected the request.");
        return false;
    }
}
