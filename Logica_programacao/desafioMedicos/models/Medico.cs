
namespace DesafioConsulta.Medico;

public class Medico{

    public string NomeMedico { get; set; }

    public List<string> Especialidades = new List<string>();

    public Medico(string nomeMedico, List<string> especialidades)
    {
        NomeMedico = nomeMedico;
        Especialidades = especialidades;
    }

    
}