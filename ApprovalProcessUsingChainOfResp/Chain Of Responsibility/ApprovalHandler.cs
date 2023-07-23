using System;

// Handler interface
public abstract partial class ApprovalHandler
{
    protected double ApprovalLimit;
    protected ApprovalHandler NextHandler;

    public void SetNextHandler(ApprovalHandler nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract bool ProcessRequest(PurchaseRequest request);
}
