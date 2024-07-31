using Dominio.Enums;

namespace Dominio;

public class Investimento : Entidade
{
    public DateTime DataCompra { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }
    public decimal TotalSemTaxas { get; set; }
    public decimal Porcentagem { get; set; }
    public decimal TaxaRateio { get; set; }
    public decimal TotalComTaxas { get; set; }
    public decimal PrecoMedio { get; set; }
    public CompraVenda CompraVenda { get; set; }
    public long TaxaId { get; set; }
    public long AtivoId { get; set; }
    public long CarteiraId { get; set; }
    public Carteira Carteira { get; set; } = null!;
}