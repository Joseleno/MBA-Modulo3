namespace Common;

public class Entity
{
    public Guid Id { get; set; }
    public string UsuarioCriacao { get; set; }
    public string UsuarioModificacao{ get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataModificacao { get; set; }

    public void Update(string usuario)
    {
        UsuarioModificacao = usuario;
        DataModificacao = DateTime.Now;
    }

    protected Entity(string usuarioCriacao)
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
        DataModificacao = DateTime.UtcNow;
        UsuarioCriacao = usuarioCriacao;
        UsuarioModificacao = usuarioCriacao;
    }

}
