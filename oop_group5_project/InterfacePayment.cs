namespace oop_group5_project
{
    public interface InterfacePayment
    {
         int Cost { get; set; }
        
         void BeginningPayment();
         void CashPayment();
         void SeveralTimesPayment();
    }
}