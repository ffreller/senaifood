using System.Collections.Generic;

namespace Senai.Ifood.Domain.Contracts
{
    public interface IBaseRepository<T> where T: class 
    {
        IEnumerable<T> Listar(string [] Includes=null);
        int Atualizar(T dados);
        int Inserir(T dados);
        int Deletar(T dados);
        T BuscarPorId(int id);
    }
}