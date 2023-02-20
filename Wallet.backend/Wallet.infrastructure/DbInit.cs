namespace WalletService.infrastructure
{
    public class DbInit
    {
        public static void init(WalletContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
