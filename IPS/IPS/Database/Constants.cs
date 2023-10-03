namespace IPS.Database
{
    public class Constants
    {

        public static readonly string DbconnectionString  = "server=ESEN\\SQLEXPRESS;database=TechSolutions;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public static readonly string InsertCustomer = "Insert into Customer " +
                        "(CustomerName,Email,Phone) " +
                        "Values(@CustomerName,@Email,@Phone)";
    }
}
