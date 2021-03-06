﻿using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using BibliotecaClasses.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfGCIN
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /* ------------------------------- Usuario ------------------------------------------- */
        public void UsuarioCadastrar(Usuario usuario)
        {
            new NUsuario().NCadastrarUsuario(usuario);
        }

        public List<Usuario> UsuarioListar(Usuario usuario)
        {
            return new NUsuario().NListarUsuario(usuario);
        }

        public void UsuarioAlterar(Usuario usuario)
        {
            new NUsuario().NAlterarUsuario(usuario);
        }

        public void UsuarioDeletar(Usuario usuario)
        {
            new NUsuario().NDeletarUsuario(usuario);
        }

        public void UsuarioLogin(Usuario usuario)
        {
            new NUsuario().NLogin(usuario);
        }
        /* ------------------------------- Perfil -------------------------------------------- */
        public List<Perfil> PerfilListar()
        {
            return new NPerfil().NListarPerfil();
        }

        public void PerfilCadastrarAlterar(Perfil perfil)
        {
            new NPerfil().NCadastrarAlterarPerfil(perfil);
        }

        public void PerfilDeletar(Perfil perfil)
        {
            new NPerfil().NDeletarPerfil(perfil);
        }
        /* ------------------------------- Produto ------------------------------------------- */
        public List<Produto> ProdutoListar(Produto produto)
        {
            return new NProduto().NListarProduto(produto);
        }

        public Produto ProdutoCadastrarAlterar(Produto produto)
        {
            return new NProduto().NCadastrarAlterarProduto(produto);
        }

        public void ProdutoDeletar(Produto produto)
        {
            new NProduto().NDeletarProduto(produto);
        }
        /* ------------------------------- Tipo de Fornecimento ------------------------------ */
        public List<TipoFornecimento> TipoFornecimentoListar()
        {
            return new NTipoFornecimento().NListarTipoFornecimento();
        }

        public void TipoFornecimentoCadastrarAlterar(TipoFornecimento tipoFornecimento)
        {
            new NTipoFornecimento().NCadastrarAlterarTipoFornecimento(tipoFornecimento);
        }

        public void TipoFornecimentoDeletar(TipoFornecimento tipoFornecimento)
        {
            new NTipoFornecimento().NDeletarTipoFornecimento(tipoFornecimento);
        }
        /* ------------------------------- Solicitação --------------------------------------- */
        public Solicitacao SolicitacaoCadastrar(Solicitacao solicitacao)
        {
            return new NSolicitacao().NCadastrarSolicitacao(solicitacao);
        }
        public List<Solicitacao> SolicitacaoListar(Solicitacao solicitacao, string dataInicial, string dataFinal)
        {
            return new NSolicitacao().NListarSolicitacao(solicitacao, dataInicial, dataFinal);
        }
        public Solicitacao SolicitacaoAlterar(Solicitacao solicitacao)
        {
            return new NSolicitacao().NAlterarSolicitacao(solicitacao);
        }
        public void SolicitacaoGerarXml(Solicitacao solicitacao)
        {
            new NSolicitacao().NGerarXmlSolicitacao(solicitacao);
        }
    }
}