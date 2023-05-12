public struct JogadorFutebol
{
    private int qtdCartoesAmarelos = 0;
    private int qtdCartoesVermelhos = 0;
    private bool possuiVinculoClube = false;
    
    public JogadorFutebol() {}

    public JogadorFutebol(bool possuiVinculoClube) {
        this.possuiVinculoClube = possuiVinculoClube;
    }

    public void registrarNumeroCartoesAmarelos() {
        this.qtdCartoesAmarelos++;
    }
    public void registrarNumerosCartoesVermelhos() {
        this.qtdCartoesVermelhos++;
    }

    public bool verificarVinculoClube() {
        return this.possuiVinculoClube;
    }

    public void imprimir() {
        var possuiVinculoClube = this.possuiVinculoClube;

        Console.WriteLine(@$"
Quantidade de cartões amarelos: {this.qtdCartoesAmarelos}
Quantidade de cartões vermelhos: {this.qtdCartoesVermelhos}
Possui vinculo com clube: {(possuiVinculoClube ? "SIM" : "NÃO")}
        ");
    }
}