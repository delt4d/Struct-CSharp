using System.Globalization;

public struct EquipeEsportes
{
    private int numeroCampeonatosVencidos = 0;
    private int valorDePremiacoes = 0;
    private DateOnly dataEstreia;

    public EquipeEsportes(int dia, int mes, int ano) {
        dataEstreia = new DateOnly(ano, mes, dia);
    }

    public void registrarCampeonatoVencido(int valorPremio) {
        numeroCampeonatosVencidos++;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    private void atualizarValorTotalPremiacoes(int valor) {
        valorDePremiacoes += valor;
    }

    public bool verificarAnoEstreia() {
        var dataAtual = DateTime.Now;
        var mesmaData = dataAtual.Year.Equals(this.dataEstreia.Year);
        return mesmaData;        
    }

    private string retornaNovataOuVeterana() {
        return verificarAnoEstreia() ? "novata" : "veterana";
    }

    private string retornaValorPremiacoesLocalmente() {
        CultureInfo cultura = new CultureInfo("pt-BR");
        return this.valorDePremiacoes.ToString("C", cultura);
    }

    public void imprimir() {
        Console.WriteLine(@$"
Número de campeonatos vencidos: {this.numeroCampeonatosVencidos}
Valor de premiações: {this.retornaValorPremiacoesLocalmente()}
Data de Estreia: {this.dataEstreia.ToString("dd/MM/yyyy")}
Nível da Equipe: {this.retornaNovataOuVeterana()}
        ");
    }
}