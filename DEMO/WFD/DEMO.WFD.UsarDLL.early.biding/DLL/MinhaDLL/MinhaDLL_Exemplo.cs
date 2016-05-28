using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaDLL
{
   public class MinhaDLL_Exemplo
    {
        /// <summary>
        /// Metodo Construtor
        /// </summary>
        public MinhaDLL_Exemplo()
        {
            //
        }

        /// <summary>
        /// Metodo GetNome - Retorna Nome
        /// </summary>
        /// <param name="nome"> Parametro Nome </param>
        /// <returns></returns>
        public string GetNome(string nome)
        {
            nome = ("Meu Nome é: " + nome);
            return nome;
        }
    }
}
