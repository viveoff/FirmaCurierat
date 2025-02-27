using System;
using System.Collections.Generic;
using System.Linq;

namespace ProiectClase
{
    public class GestionareComenzi
    {
        private List<ComandaLivrare> comenzi;

        // Constructor
        public GestionareComenzi()
        {
            comenzi = new List<ComandaLivrare>();
        }
        // new comment
        // Adaugă o comandă nouă
        public void AdaugaComanda(ComandaLivrare comanda)
        {
            comenzi.Add(comanda);
            Console.WriteLine("Comanda adăugată cu succes.");
        }

        // Modifică o comandă existentă
        public void ModificaComanda(int id, string nouaStare)
        {
            var comanda = comenzi.FirstOrDefault(c => c.ID == id);
            if (comanda != null)
            {
                comanda.StareComanda = nouaStare;
                Console.WriteLine($"Comanda cu ID-ul {id} a fost actualizată.");
            }
            else
            {
                Console.WriteLine("Comanda nu a fost găsită.");
            }
        }

        // Șterge o comandă
        public void StergeComanda(int id)
        {
            var comanda = comenzi.FirstOrDefault(c => c.ID == id);
            if (comanda != null)
            {
                comenzi.Remove(comanda);
                Console.WriteLine($"Comanda cu ID-ul {id} a fost ștearsă.");
            }
            else
            {
                Console.WriteLine("Comanda nu a fost găsită.");
            }
        }

        // Afișează toate comenzile
        public void AfiseazaComenzi()
        {
            if (comenzi.Any())
            {
                foreach (var comanda in comenzi)
                {
                    Console.WriteLine(comanda.Info());
                }
            }
            else
            {
                Console.WriteLine("Nu sunt comenzi de livrare.");
            }
        }

        // Căutare comandă după ID
        public void CautaComanda(int id)
        {
            var comanda = comenzi.FirstOrDefault(c => c.ID == id);
            if (comanda != null)
            {
                Console.WriteLine(comanda.Info());
            }
            else
            {
                Console.WriteLine("Comanda nu a fost găsită.");
            }
        }
    }
}
