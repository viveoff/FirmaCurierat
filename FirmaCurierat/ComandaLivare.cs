using System;

namespace ProiectClase
{
    public class ComandaLivrare
    {
        public int ID { get; set; }
        public string NumeClient { get; set; }
        public string AdresaLivrare { get; set; }
        public string DescriereColet { get; set; }
        public double Greutate { get; set; }
        public string Dimensiuni { get; set; }
        public DateTime DataLivrare { get; set; }
        public string StareComanda { get; set; }

        // Constructor fara parametri
        public ComandaLivrare()
        {
            ID = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DescriereColet = string.Empty;
            Greutate = 0;
            Dimensiuni = string.Empty;
            DataLivrare = DateTime.Now;
            StareComanda = "În așteptare";
        }

        // Constructor cu parametri
        public ComandaLivrare(int id, string numeClient, string adresaLivrare, string descriereColet, double greutate, string dimensiuni, DateTime dataLivrare)
        {
            ID = id;
            NumeClient = numeClient;
            AdresaLivrare = adresaLivrare;
            DescriereColet = descriereColet;
            Greutate = greutate;
            Dimensiuni = dimensiuni;
            DataLivrare = dataLivrare;
            StareComanda = "În așteptare";
        }

        public string Info()
        {
            return $"ID: {ID}, Nume Client: {NumeClient}, Adresa: {AdresaLivrare}, Descriere: {DescriereColet}, Greutate: {Greutate}kg, Dimensiuni: {Dimensiuni}, Data Livrare: {DataLivrare}, Stare: {StareComanda}";
        }
    }
}
