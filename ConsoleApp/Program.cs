using ConsoleApp;
using System;

public class Program
{
    public static void Main()
    {
        var finalInv = new FinalInvoice();
        var proposedInv = new ProposedInvoice();
        var testInv = new TestInvoice();
        var finalAmount = finalInv.GetInvoiceDiscount(1000);
        var proposedAmount = proposedInv.GetInvoiceDiscount(1000);
        var testAmount = testInv.GetInvoiceDiscount(1000);

        Console.WriteLine($"finalAmount : {finalAmount} | proposedAmount : {proposedAmount} | testAmount : {testAmount}");
        Console.ReadLine();
    }
}
