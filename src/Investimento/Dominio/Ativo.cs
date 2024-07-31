using Dominio.Enums;

namespace Dominio;

public class Ativo : Entidade
{
    public string Codigo { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public TipoAtivo TipoAtivo { get; set; }
}