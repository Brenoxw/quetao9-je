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

    public Produto() { }
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
        Numero = new Random().NextDouble() * 10000; // número aleatório só pra exemplo
    }

    public void AdicionaProduto(Produto produto)
    {
        Produtos.Add(produto);
    }
}

