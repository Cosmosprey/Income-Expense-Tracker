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
            Application.SetHighDpiMode(HighDpiMode.SystemAware); // Sistem DPI's�na uyum (bulan�k g�r�nt� sorunu ya�am��t�m)
            Application.Run(GirisForm);
        }
    }
}