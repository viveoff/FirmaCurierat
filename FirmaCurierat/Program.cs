using System;

namespace ProiectClase
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionareComenzi gestiune = new GestionareComenzi();

            // Adăugarea unor comenzi de livrare
            var comanda1 = new ComandaLivrare(1, "Ion Popescu", "Strada Exemplu 123", "Telefon mobil", 0.5, "10x5x2", DateTime.Now.AddDays(2));
            gestiune.AdaugaComanda(comanda1);

            var comanda2 = new ComandaLivrare(2, "Maria Ionescu", "Strada Test 456", "Laptop", 2.5, "30x25x5", DateTime.Now.AddDays(3));
            gestiune.AdaugaComanda(comanda2);

            // Afișează toate comenzile
            gestiune.AfiseazaComenzi();

            // Modifică starea unei comenzi
            gestiune.ModificaComanda(1, "În livrare");

            // Căutare comandă după ID
            gestiune.CautaComanda(2);

            // Șterge o comandă
            gestiune.StergeComanda(1);

            // Afișează comenzile după ștergere
            gestiune.AfiseazaComenzi();

            Console.ReadKey();
        }
    }
}
