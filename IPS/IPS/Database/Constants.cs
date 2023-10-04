namespace IPS.Database
{
    public class Constants
    {

        public static readonly string DbconnectionString  = "server=ESEN\\SQLEXPRESS;database=TechSolutions;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public static readonly string InsertCustomer = "Insert into Customer " +
                        "(CustomerName,Email,Phone) " +
                        "Values(@CustomerName,@Email,@Phone)";
        public static readonly string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
        public static readonly string phonePattern = @"^[\s()-]*\d{3}[\s()-]*\d{3}[\s()-]*\d{4}[\s()-]*$";
        public static readonly string UpdateCustomer =" Update  Customer "+" Set CustomerName=@name, Email=@email, Phone=@phone "+" Where CustomerId=@Id";
        public static readonly string GetCustomer = "Select * from Customer where CustomerId=@Id";
        public static readonly string DeleteCustomer = "Delete From Customer where CustomerId=@Id";
    }
}
