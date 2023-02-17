namespace TSBE_S5_PRGII_MichaelSchori_AB02;

public class Kunde
{
    public int ID { get; set; }
    public string Vorname { get; set; }
    public string Name { get; set; }
    public string Telefon { get; set; }
    public string Ortschaft { get; set; }
    public int LieferkostenID { get; set; }
    public Lieferkosten Lieferkosten { get; set; }
}