--use gcin

--select * from Solicitacao;
--select * from Stat;
--select * from Produto;

select s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, s.statusSolicitacao, s.dataPrevistaFim,
	   p.descProduto, st.detalheStatus, st.dataStatus, u.idUsuario, u.nome From Solicitacao as s
inner join Produto as p
	on s.idProduto = p.idProduto
inner join Stat as st
	on s.idSolicitacao = st.idSolicitacao

--where s.idSolicitacao = 1000

--where st.idUsuario = 1000;

--where s.dataSolicitacao between '2016-11-12' and '2016-11-30'

--where s.statusSolicitacao = 'aberta'