namespace Dominio;

public class Carteira : Entidade
{
    public string Nome { get; set; } = string.Empty;
    public IEnumerable<Investimento> Investimentos { get; set; } = null!;
}