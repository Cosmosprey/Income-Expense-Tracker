using GelirGiderClass;

public class GelirGider
{

    public string Tur { get; set; } //gelir mi gider mi olduğu
    public decimal Miktar { get; private set; } //gelir veya giderin miktarı
    public DateTime Tarih { get; set; } //gelir veya giderin tarihi
    public string Kaynak { get; set; } //gelir veya giderin kaynağı (örnek: kira ödemesi)

    public GelirGider(string Tur, decimal Miktar, DateTime Tarih, string Kaynak)
    {
        this.Tur = Tur;
        this.Tarih = Tarih;
        this.Kaynak = Kaynak;
       this.Miktar = Miktar;
    }

}
