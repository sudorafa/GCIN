using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfGCIN
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // TODO: Add your service operations here

        /* -------------------------------  Usuário -------------------------------------------- */
        [OperationContract]
        void UsuarioCadastrar(Usuario usuario);
        
        [OperationContract]
        List<Usuario> UsuarioListar(Usuario usuario);

        [OperationContract]
        void UsuarioAlterar(Usuario usuario);

        [OperationContract]
        void UsuarioDeletar(Usuario usuario);

        [OperationContract]
        void UsuarioLogin(Usuario usuario);
        /* -------------------------------  Perfil -------------------------------------------- */
        [OperationContract]
        List<Perfil> PerfilListar();

        [OperationContract]
        void PerfilCadastrarAlterar(Perfil perfil);

        [OperationContract]
        void PerfilDeletar(Perfil perfil);
        /* -------------------------------  Produto ------------------------------------------- */
        [OperationContract]
        List<Produto> ProdutoListar(Produto produto);

        [OperationContract]
        void ProdutoCadastrarAlterar(Produto produto);

        [OperationContract]
        void ProdutoDeletar(Produto produto);
        /* ------------------------------- Tipo de Fornecimento ------------------------------ */
        [OperationContract]
        List<TipoFornecimento> TipoFornecimentoListar();

        [OperationContract]
        void TipoFornecimentoCadastrarAlterar(TipoFornecimento tipoFornecimento);

        [OperationContract]
        void TipoFornecimentoDeletar(TipoFornecimento tipoFornecimento);
    }
}
