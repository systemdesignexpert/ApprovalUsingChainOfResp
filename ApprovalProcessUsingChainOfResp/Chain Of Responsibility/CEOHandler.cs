public class CEOHandler : ApprovalHandler
{
    public CEOHandler()
    {
        ApprovalLimit = Constants.MAX_LIMIT;
    }

    public override bool ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount > Constants.MAX_LIMIT)
        {
            Console.WriteLine("CEO rejected the request, higher than max limit.");
            return false;
        }
        if (request.Amount <= ApprovalLimit)
        {
            Console.WriteLine("CEO approved the purchase request.");
            return true;
        }
        if (NextHandler != null)
        {
            Console.WriteLine("CEO approved the request, but it requires further approval.");
            return NextHandler.ProcessRequest(request);
        }

        Console.WriteLine("CEO rejected the request.");
        return false;
    }
}
