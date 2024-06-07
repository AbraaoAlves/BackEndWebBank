namespace BackendSharp.Users
{
    public class Card
    {
        public Guid Id { get; init; }
        public string NumberCard { get; private set; }
        public string CVC { get; private set; }
        public string Validity { get; private set; }
        public string PasswordCard { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }

      
                public Card()
    {
        NumberCard = string.Empty;
    }

        public Card(string numberCard, string cvc, string validity, string passwordCard,Guid userId)
        {
            Id = Guid.NewGuid();
            NumberCard = numberCard;
            CVC = cvc;
            Validity = validity;
            PasswordCard = passwordCard;
            UserId = userId;
        }

        public void AtualizarCartao(string numbercard, string cvc, string validity, string passwordcard)
        {
            NumberCard = numbercard;
            CVC = cvc;
            Validity = validity;
            PasswordCard = passwordcard;
        }
    }
}