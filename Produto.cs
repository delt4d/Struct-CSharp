using System.Globalization;

public struct Produto
{
    private int quantidadeEstoque;
    private decimal valorProduto;
    private decimal cupomDesconto;
    private bool? cupomEhPorPorcentagem;
    private string nome;

    public Produto(string nome, decimal valorProduto, int quantidadeEstoque) {
        this.nome = nome;
        this.valorProduto = valorProduto;
        this.cupomDesconto = 0;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public void aplicarCupomDescontoValor(decimal valorCupomDesconto) {
        this.cupomDesconto = valorCupomDesconto;
        this.cupomEhPorPorcentagem = false;
    }

    public void aplicarCupomDescontoPorcentagem(decimal valorCupomDesconto) {
        this.cupomDesconto = valorCupomDesconto;
        this.cupomEhPorPorcentagem = true;
    }

    public void removerCupomDesconto() {
        this.cupomDesconto = 0;
        this.cupomEhPorPorcentagem = null;
    }

    public int verificarQuantidadeEmEstoque() {
        return this.quantidadeEstoque;
    }

    public void imprimir() {
        CultureInfo cultura = new CultureInfo("pt-BR");

        decimal valorDesconto = 0;

        if (this.cupomEhPorPorcentagem != null) {
            if (this.cupomEhPorPorcentagem == true) {
                valorDesconto = this.valorProduto * (this.cupomDesconto / 100);
            } else {
                valorDesconto = this.cupomDesconto;
            }
        }

        var valorProdutoComDesconto = valorProduto - valorDesconto;

        Console.WriteLine(@$"
Nome do Produto: {this.nome}
Desconto: {(this.cupomEhPorPorcentagem == null ? "Sem desconto" : (this.cupomEhPorPorcentagem == true ? this.cupomDesconto + "%" : this.cupomDesconto.ToString("C", cultura)))}
Valor do Produto: {this.valorProduto.ToString("C", cultura)}
Valor do Produto com desconto: {valorProdutoComDesconto.ToString("C", cultura)}
Quantidade em estoque: {this.verificarQuantidadeEmEstoque()}
        ");
    }
}