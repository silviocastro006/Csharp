using System;

namespace Resolucao.Model;

    public class Funcionario{
    
    // Atributos
    public string Id { get; protected set; }
    public string Nome { get; protected set; }
    public string Cargo { get; protected set; }
    public string Departamento { get; protected set; }
    public DateTime DataAdmissao { get; protected set; }
    public decimal Salario { get; protected set; }
    public string Cidade { get; protected set; }
    public string Estado { get; protected set; }

    // Construtor
    public Funcionario(string id, string nome, string cargo, string departamento, DateTime dataAdmissao, decimal salario, string cidade, string estado)
    {
        SetId(id);
        SetNome(nome);
        SetCargo(cargo);
        SetDepartamento(departamento);
        SetDataAdmissao(dataAdmissao);
        SetSalario(salario);
        SetCidade(cidade);
        SetEstado(estado);
    }

    // Métodos
    public void SetId(string id){
        Id = id;
    }

    public void SetNome(string nome){

        if(string.IsNullOrWhiteSpace(nome)){
            throw new Exception("O nome deve ser preenchido!");
        }
        
        if(nome.Length > 255){
            throw new Exception("O nome pode conter no máximo 255 caracteres.");
        }

        Nome = nome;

    }

    public void SetCargo(string cargo){

        if(string.IsNullOrWhiteSpace(cargo)){
            throw new Exception("O Cargo deve ser preenchido!");
        }
        
        if(cargo.Length > 255){
            throw new Exception("O Cargo pode conter no máximo 255 caracteres.");
        }

        Cargo = cargo;

    }

    public void SetDepartamento(string departamento){

        if(string.IsNullOrWhiteSpace(departamento)){
            throw new Exception("O departamento deve ser preenchido!");
        }
        
        if(departamento.Length > 255){
            throw new Exception("O departamento pode conter no máximo 255 caracteres.");
        }

        Departamento = departamento;

    }

    public void SetDataAdmissao(DateTime dataAdmissao){

        if(dataAdmissao == DateTime.MinValue){
            throw new Exception("Data Inválida");
        }

        if(dataAdmissao > DateTime.Now){
            throw new Exception("A data de admissão não pode ser no futuro");
        }

        DataAdmissao = dataAdmissao;

    }

    public void SetSalario(decimal salario){
        
        if(salario <=0){
            throw new Exception("O salário não pode ser menor ou igual a zero");
        }

        Salario = salario;
    }

    public void SetCidade(string cidade){

        if(string.IsNullOrWhiteSpace(cidade)){
            throw new Exception("A cidade deve ser preenchido!");
        }
        
        if(cidade.Length > 255){
            throw new Exception("A cidade pode conter no máximo 255 caracteres.");
        }

        Cidade = cidade;

    }

    public void SetEstado(string estado){

        if(string.IsNullOrWhiteSpace(estado)){
            throw new Exception("O estado deve ser preenchido!");
        }
        
        if(estado.Length > 255){
            throw new Exception("O estado pode conter no máximo 255 caracteres.");
        }

        Estado = estado;

    }

    }

