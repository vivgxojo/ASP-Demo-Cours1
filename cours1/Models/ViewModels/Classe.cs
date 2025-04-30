namespace cours1.Models.ViewModels
{
    public class Classe
    {
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
        public string? Enseignant { get; set; }

        public string Cours { get; set; }
    }
}
