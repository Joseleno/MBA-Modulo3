namespace Common;

public class ResultBase
{
    public string Mensagem { get; set; } = string.Empty;
    public bool Resultado { get; set; }

    public static ResultBase Error(string mensagem)
    {
        return new ResultBase { Resultado = false, Mensagem = mensagem };
    }

    public static ResultBase Sucess(string mensagem = "Operação realizada com sucesso.")
    {
        return new ResultBase { Resultado = true, Mensagem = mensagem };
    }
    
}
