using System;
using System.Collections.Generic;

public class Pessoa
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Logradouro { get; set; }
    public string Email { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }
}

public class Cliente : Pessoa
{
    public string Cpf { get; set; }
    public string Cgj { get; set; }

    public Cliente(string cpf, string cgj, string nome)
    {
        Cpf = cpf;
        Cgj = cgj;
        Nome = nome;
    }
}

public class Fornecedor
{
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }

    public Fornecedor(string nome, string cnpj)
    {
        RazaoSocial = nome;
        Cnpj = cnpj;
    }
}

public class Produto
{
    public string Descricao { get; set; }
    public double Valor { get; set; }

    public Produto(string descricao, double valor)
    {
        Descricao = descricao;
        Valor = valor;
    }
}

public class NotaFiscal
{
    public double Numero { get; set; }
    public Cliente Cliente { get; set; }
    public Fornecedor Fornecedor { get; set; }
    public List<Produto> Produtos { get; set; } = new List<Produto>();

    public NotaFiscal(Cliente cliente, Fornecedor fornecedor)
    {
        Cliente = cliente;
        Fornecedor = fornecedor;
        Numero = new Random().Next(1000, 9999); // número aleatório
    }

    public void AdicionaProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void ImprimirNota()
    {
        Console.WriteLine("===== NOTA FISCAL =====");
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Cliente: {Cliente.Nome} | CPF: {Cliente.Cpf}");
        Console.WriteLine($"Fornecedor: {Fornecedor.RazaoSocial} | CNPJ: {Fornecedor.Cnpj}");
        Console.WriteLine("Produtos:");
        double total = 0;
        foreach (var p in Produtos)
        {
            Console.WriteLine($"- {p.Descricao} - R$ {p.Valor}");
            total += p.Valor;
        }
        Console.WriteLine($"Total: R$ {total}");
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Criando cliente
        Cliente cliente = new Cliente("123.456.789-00", "001", "Maria Silva");

        // Criando fornecedor
        Fornecedor fornecedor = new Fornecedor("Loja Tech", "11.222.333/0001-44");

        // Criando produtos
        Produto produto1 = new Produto("Mouse Gamer", 150.00);
        Produto produto2 = new Produto("Teclado Mecânico", 300.00);

        // Criando nota fiscal
        NotaFiscal nota = new NotaFiscal(cliente, fornecedor);
        nota.AdicionaProduto(produto1);
        nota.AdicionaProduto(produto2);

        // Imprimindo nota fiscal
        nota.ImprimirNota();
    }
}

