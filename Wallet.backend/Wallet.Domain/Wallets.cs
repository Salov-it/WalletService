namespace Wallet.Domain
{
    public class Wallets
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public decimal balance { get; set; }
        public string? createdAt { get; set; }
        public string? updatedAt { get; set; }
    }
}
