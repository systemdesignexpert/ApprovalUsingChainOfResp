// Approval Processor class
public class ApprovalProcessor
{
    private ApprovalHandler approvalChain;

    public ApprovalProcessor()
    {
        CreateChain();
    }

    private void CreateChain()
    {
        ApprovalHandler manager = new ManagerHandler();
        ApprovalHandler director = new DirectorHandler();
        ApprovalHandler vicePresident = new VicePresidentHandler();
        ApprovalHandler ceo = new CEOHandler();

        manager.SetNextHandler(director);
        director.SetNextHandler(vicePresident);
        vicePresident.SetNextHandler(ceo);

        approvalChain = manager;
    }

    public void ProcessRequest(PurchaseRequest request)
    {
        approvalChain.ProcessRequest(request);
    }
}
