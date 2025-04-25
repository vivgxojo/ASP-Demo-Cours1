namespace cours1.Models
{
    public static class Groupe
    {
        public static List<Etudiant> Etudiants { get; set; } 
            = new List<Etudiant>() 
        {
            new Etudiant(1, "Alex"),
            new Etudiant(2, "Ines"),
            new Etudiant(3, "Daniella"),
            new Etudiant(4, "Philippe"),
            new Etudiant(5, "Francis"),
            new Etudiant(6, "Philippe")
        };
    }
}
