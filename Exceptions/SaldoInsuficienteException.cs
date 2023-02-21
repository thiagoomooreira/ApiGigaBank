using System;

namespace GigaBank.Exceptions
{
    public class SaldoInsuficienteException: Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem) { }
    }
}