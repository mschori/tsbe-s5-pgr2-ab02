namespace TSBE_S5_PRGII_MichaelSchori_AB02;

public class Lieferkosten
{
    public int ID { get; set; }
    public string NameZone { get; set; }
    public float Preis { get; set; }
    public ICollection<Kunde> Kunden { get; set; }
}   