using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Sobrenome;
    public string Telefone;
    public string Celular;
    public string Email;


    public Pessoa() //Método construtor
    {

    }

    public void DefinirNome(string nome)
    {
        this.Nome = nome;
    }

    public void DefinirSobrenome(string sobrenome)
    {
        this.Sobrenome = sobrenome;
    }

    public void DefinirIdade(int idade)
    {
        this.Idade = idade;
    }

    public void DefinirTelefone(string telefone)
    {
        this.Telefone = telefone;
    }

    public void DefinirCelular(string celular)
    {
        this.Celular = celular;
    }

    public void DefinirEmail(string email)
    {
        this.Email = email;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome} {Sobrenome}", this.Nome, this.Sobrenome);
        Console.WriteLine($"Idade: {Idade}", this.Idade);
        Console.WriteLine($"Telefone: {Telefone}", this.Telefone);
        Console.WriteLine($"Celular: {Celular}", this.Celular);
        Console.WriteLine($"Email: {Email}", this.Email);
    }
}

