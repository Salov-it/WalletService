namespace WalletService.infrastructure
{
    static class DbInit
    {
        static void init(WalletContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
