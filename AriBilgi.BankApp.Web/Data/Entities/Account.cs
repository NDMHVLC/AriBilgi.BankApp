namespace AriBilgi.BankApp.Web.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } //bakiye
        public int AccountNo { get; set; } //heap no

        public int ApplicationUserId { get; set; } 


        //Navigate Property
        public ApplicationUser ApplicationUser { get; set; }
    }
}
