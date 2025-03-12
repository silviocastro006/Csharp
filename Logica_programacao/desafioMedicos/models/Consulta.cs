
using System.Globalization;

namespace DesafioConsulta.Consulta;

public class Consulta{

    public DateTime DataConsulta { get; protected set; }
    public string HoraDaConsulta { get; protected set; }
    public string NomePaciente { get; protected set; }
    public string NumeroTelefone { get; protected set; }
    public long Cpf { get; protected set; }
    public string Rua { get; protected set; }
    public string Cidade { get; protected set; }
    public string Estado { get; protected set; }
    public string Especialidade { get; protected set; }
    public string NomeMedico { get; protected set; }
    public bool Particular { get; protected set; }
    public long NumeroDaCarteirinha { get; protected set; }
    public double ValorConsulta { get; protected set; }

    public Consulta(DateTime dataConsulta, string horaDaConsulta, string nomePaciente, string numeroTelefone, long cpf, string rua, string cidade, string estado, string especialidade, string nomeMedico, bool particular, long numeroDaCarteirinha, double valorConsulta)
    {
        SetDataConsulta(dataConsulta);
        SetHoraDaConsulta(horaDaConsulta);
        SetNomePaciente(nomePaciente);
        SetNumeroTelefone(numeroTelefone);
        SetCpf(cpf);
        SetRua(rua);
        SetCidade(cidade);
        SetEstado(estado);
        SetEspecialidade(especialidade);
        SetNomeMedico(nomeMedico);
        SetParticular(particular);
        SetNumeroDaCarteirinha(numeroDaCarteirinha);
        SetValorConsulta(valorConsulta);
    }
    
    public void SetDataConsulta(DateTime data)
    {
        if(string.IsNullOrEmpty(data.ToString())){
            throw new Exception("Data não pode ser nula.");
        }

        if(data <= DateTime.MinValue || data >= DateTime.MaxValue)
        {
            throw new Exception("Data não pode ser menor ou igual a mínima nem mais ou igual ao máximo.");
        }

        DataConsulta = data;
    }

    public void SetHoraDaConsulta(string hora)
    {
        if(string.IsNullOrEmpty(hora))
        {
            throw new Exception("Hora não pode ser nula");
        }
        
        if(DateTime.TryParseExact(hora,"HH:mm",CultureInfo.InvariantCulture,DateTimeStyles.NoCurrentDateDefault, out DateTime HoraNova))
        {
            HoraDaConsulta = HoraNova.ToString("HH:mm");
        } else 
        {
            throw new Exception("A hora não é válida!");
        }

        HoraDaConsulta = hora;
    }

    public void SetNomePaciente(string nome)
    {

        if(string.IsNullOrEmpty(nome))
        {
            throw new Exception("O nome do paciente não pode ser nulo");
        }

        NomePaciente = nome;
    }

    public void SetNumeroTelefone(string numero)
    {
        if(string.IsNullOrEmpty(numero))
        {
            NumeroTelefone = "Não informado";
        }

        NumeroTelefone = numero;
    }

    public void SetCpf(long cpf)
    {
        if(string.IsNullOrEmpty(cpf.ToString()))
        {
            throw new Exception("O CPF não pode ser nulo!");
        }

        if(cpf <= 0 || cpf.ToString().Length > 11)
        {
            throw new ArgumentException("CPF precisa ter 11 dígitos!");
        }

        Cpf = cpf;
    }

    public void SetRua(string rua)
    {
        if(string.IsNullOrEmpty(rua.ToString()))
        {
            throw new ArgumentException("A rua não pode ser nula!");
        }

        Rua = rua;
    }

    public void SetCidade(string cidade)
    {
        if(string.IsNullOrEmpty(cidade.ToString()))
        {
            throw new ArgumentException("A cidade não pode ser nula!");
        }

        Cidade = cidade;
    }

    public void SetEstado(string estado)
    {
        if(string.IsNullOrEmpty(estado))
        {
            throw new ArgumentException("O Estado não pode ser nulo!");
        }

        Estado = estado;
    }

    public void SetEspecialidade(string especialidade)
    {
        if(string.IsNullOrEmpty(especialidade))
        {
            throw new ArgumentException("A especialidade não pode ser nula!");
        }

        Especialidade = especialidade;
    }

    public void SetNomeMedico(string nomeMedico)
    {
        if(string.IsNullOrEmpty(nomeMedico))
        {
            throw new ArgumentException("O nome do médico não pode ser nulo!");
        }

        NomeMedico = nomeMedico;
    }

    public void SetParticular(bool particular)
    {
        Particular = particular.ToString().Equals("Sim")?true:false;
    }

    public void SetNumeroDaCarteirinha(long carteirinha)
    {
        if(string.IsNullOrEmpty(carteirinha.ToString()))
        {
            throw new ArgumentException("A carteirinha não pode ser nula!");
        }

        NumeroDaCarteirinha = carteirinha;
    }
    
    public void SetValorConsulta(double valorConsulta)
    {
        if(valorConsulta <= 0)
        {
            throw new ArgumentException("Valor da consulta não pode ser menor ou igual a 0");
        }

        ValorConsulta = valorConsulta;
    }

    public string GetValorCPF(){

        return this.Cpf.ToString("D11");

    }

}