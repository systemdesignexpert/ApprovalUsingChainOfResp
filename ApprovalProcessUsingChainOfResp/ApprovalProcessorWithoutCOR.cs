using System;

// Approval Processor class without Chain of Responsibility
public class ApprovalProcessorWithoutCOR
{
    public bool ProcessRequest(PurchaseRequest request)
    {
        
        Console.WriteLine("Manager approved the purchase request.");
        // manager checks for request raised by employee till date, and that sum should be below his teams budget
        if (request.Amount > 10000 && request.Amount <= Constants.MAX_LIMIT)
        {
            Console.WriteLine("Director approved the purchase request.");

            // director shouls approve if it fits his annual budget, and also validates that expenses are approvable
        }
        if (request.Amount > 50000 && request.Amount <= Constants.MAX_LIMIT)
        {
            Console.WriteLine("Vice President approved the purchase request.");
            // VP ensures that the request was not forged, and the cross-checks the bills
        }
        if (request.Amount > 500000 && request.Amount <= Constants.MAX_LIMIT)
        {
            Console.WriteLine("CEO approved the purchase request.");
            // CEO seeks a written reason for expense letter from the person for approval.
        }
        if(request.Amount > Constants.MAX_LIMIT)
        {
            Console.WriteLine("Rejected!!");
            return false;
        }

        return true;
    }
}
