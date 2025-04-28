namespace Common;

public class Entity
{
    public Guid Id { get; set; }
    public string UsuarioCriacao { get; set; }
    public string UsuarioModificacao{ get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataModificacao { get; set; }

}
