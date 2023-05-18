var produto1 = new Produto("produto 1", 100, 1000);
var produto2 = new Produto("produto 2", 20, 230);
var produto3 = new Produto("produto 3", 25, 502);

produto1.aplicarCupomDescontoPorcentagem(20);

produto2.aplicarCupomDescontoPorcentagem(5);
produto2.removerCupomDesconto();

produto3.aplicarCupomDescontoValor(10);
produto3.aplicarCupomDescontoValor(5);

produto1.imprimir();
produto2.imprimir();
produto3.imprimir();