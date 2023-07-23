ApprovalProcessorWithoutCOR approvalProcessor = new ApprovalProcessorWithoutCOR();

PurchaseRequest request1 = new PurchaseRequest(10000);
PurchaseRequest request2 = new PurchaseRequest(40000);
PurchaseRequest request3 = new PurchaseRequest(400000);
PurchaseRequest request4 = new PurchaseRequest(1000000);


Console.WriteLine("Request 1");
approvalProcessor.ProcessRequest(request1);
Console.WriteLine();

Console.WriteLine("Request 2");
approvalProcessor.ProcessRequest(request2);
Console.WriteLine();

Console.WriteLine("Request 3");
approvalProcessor.ProcessRequest(request3);
Console.WriteLine();

Console.WriteLine("Request 4");
approvalProcessor.ProcessRequest(request4);
Console.WriteLine();