namespace EDE_TPLOCAL1.Models
{
    public class EnteteMenuModel
    {
        public string Titre { get; set; }
        public List<RubriqueModel> Rubriques { get; set; }
    }

    public class RubriqueModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
