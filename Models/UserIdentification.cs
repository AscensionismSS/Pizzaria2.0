namespace Pizzaria2._0.Models
{
    public class UserIdentification
    {
        public int Id { get; set; }
        public string Cpf{ get; set; }

        public int AccountID { get; set; }
        public virtual Account Account { get; set; }
    }
}

