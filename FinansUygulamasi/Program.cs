namespace FinansUygulamasiProjesi
{
    static class Program
    {
        public static Giris GirisForm = new();
        public static GelirGiderEkle GelirGiderForm = new();
        public static GelirGiderTablosu GelirGiderTabloForm = new();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware); // Sistem DPI'sýna uyum (bulanýk görüntü sorunu yaþamýþtým)
            Application.Run(GirisForm);
        }
    }
}