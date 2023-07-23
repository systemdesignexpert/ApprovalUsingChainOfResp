
public class ManagerHandler : ApprovalHandler
{
    public ManagerHandler()
    {
        ApprovalLimit = 10000;
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
            Console.WriteLine("Manager approved the purchase request.");
            return true;
        }
        if (NextHandler != null)
        {
            Console.WriteLine("Manager approved the request, but it requires further approval.");
            return NextHandler.ProcessRequest(request);
        }

        Console.WriteLine("Manager rejected the request.");
        return false;
    }
}

