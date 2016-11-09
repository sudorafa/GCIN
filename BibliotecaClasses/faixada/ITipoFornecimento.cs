using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.faixada
{
    interface ITipoFornecimento
    {
        List<TipoFornecimento> DListarTipoFornecimento();
        void DDeletarTipoFornecimento(TipoFornecimento tipoFornecimento);
        void DCadastrarTipoFornecimento(TipoFornecimento tipoFornecimento);
        void DAlterarTipoFornecimento(TipoFornecimento tipoFornecimento);
    }
}
