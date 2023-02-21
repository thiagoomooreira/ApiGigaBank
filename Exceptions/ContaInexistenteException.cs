using System;

namespace GigaBank.Exceptions
{
    public class ContaInexistenteException : Exception
    {
        public ContaInexistenteException() { }

        public ContaInexistenteException(string numeroDaConta)
            : base($"Não foi encontrado nenhuma conta com o número igual a {numeroDaConta}")
        {
            
        }
    }
}