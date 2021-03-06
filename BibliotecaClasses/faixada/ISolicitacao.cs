﻿using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.faixada
{
    interface ISolicitacao
    {
        Solicitacao CadastrarSolicitacao(Solicitacao solicitacao);
        List<Solicitacao> ListarSolicitacao(Solicitacao solicitacao, string dataInicial, string dataFinal);
        Solicitacao AtualizarSolicitacao(Solicitacao solicitacao);
    }
}
