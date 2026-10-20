using System.ComponentModel.DataAnnotations;

namespace EDE_TPLOCAL1.Models;


public class FormModel
{
    private const string MsgChampObligatoire = "Champ obligatoire";


    [Required(ErrorMessage = MsgChampObligatoire)] public string Nom { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)] public string Prenom { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)] public string Sexe { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)] public string Adresse { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)][RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Le code postal doit contenir exactement 5 chiffres")] public string CodePostal { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)] public string Ville { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)][EmailAddress(ErrorMessage = "L'adresse email est invalide")] public string AdresseMail { get; set; } = string.Empty;
    [Required(ErrorMessage = MsgChampObligatoire)] public DateTime? DateDebutFormation { get; set; } = null;
    [Required(ErrorMessage = MsgChampObligatoire)] public string FormationSuivie { get; set; } = string.Empty;
    public string? AvisFormationCobol { get; set; } = string.Empty;
    public string? AvisFormationCSharp { get; set; } = string.Empty;
}
