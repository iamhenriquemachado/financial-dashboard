namespace FinancialDashboard.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public DateTime CreatedAt = DateTime.Now;

        public DateTime UpdatedAt = DateTime.Now;


    }
}
