namespace cours1.Models
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }

        public Etudiant() { }
        public Etudiant(int numeroEtudiant, string nom)
        {
            NumeroEtudiant = numeroEtudiant;
            Nom = nom;
        }
    }
}
