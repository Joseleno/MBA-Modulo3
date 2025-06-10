namespace Common;

public class Result<T> : ResultBase
{
    public T Value { get; set; }

    public static new Result<T> Error(string mensagem)
    {
        return new Result<T> { Resultado = false, Mensagem = mensagem };
    }

    public static Result<T> Sucess(T value, string mensagem = "Operação bem sucedida!")
    {
        return new Result<T> { Resultado = true, Mensagem = mensagem, Value = value };
    }
    
}

