select * from solicitacao;
select idSolicitacao, dataSolicitacao, dataPrecisa, severidade, detalhe, idProduto from Solicitacao;

select * from Stat;
select detalheStatus, dataStatus, statusSolicitacao, idSolicitacao, idUsuario from Stat;

select * from Usuario;

--insert into Stat(detalheStatus, dataStatus, statusSolicitacao, idSolicitacao, idUsuario) values
--('rafa', '2016-11-19', 'rafa', 1009, 1032);

--delete from Solicitacao;


select top 1 s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, st.detalheStatus, st.dataStatus, st.statusSolicitacao, u.idUsuario, u.nome, p.descProduto From Solicitacao s
inner join Stat as st
	on s.idSolicitacao = st.idSolicitacao
inner join Usuario as u
	on st.idUsuario = u.idUsuario
inner join Produto as p
	on s.idProduto = p.idProduto
where u.idUsuario = 1032 and st.statusSolicitacao = 'Aberto' order by s.idSolicitacao desc;
	   

select distinct s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, s.dataPrevistaFim, s.situacao,
p.descProduto, u.idUsuario, u.nome, pf.descPerfil From Solicitacao as s 
inner join Produto as p
	on s.idProduto = p.idProduto
inner join Stat as st
	on s.idSolicitacao = st.idSolicitacao
inner join Usuario as u
	on st.idUsuario = u.idUsuario
inner join Perfil as pf
	on u.idPerfil = pf.idPerfil
where s.idSolicitacao = s.idSolicitacao and s.dataSolicitacao between '2016-11-23' and '2016-11-23' and st.statusSolicitacao = 'Abertura';

select top 1 * from Stat where idSolicitacao = 1002 order by idStatus desc;

select * from Stat;
select * from Solicitacao;

--select distinct s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, s.dataPrevistaFim, s.situacao, p.descProduto, u.idUsuario, u.nome, pf.descPerfil From Solicitacao as s inner join Produto as p on s.idProduto = p.idProduto inner join Stat as st on s.idSolicitacao = st.idSolicitacao inner join Usuario as u on st.idUsuario = u.idUsuario inner join Perfil as pf on u.idPerfil = pf.idPerfil where s.idSolicitacao = s.idSolicitacao  and st.idUsuario = 1000 and s.dataSolicitacao between '2016-11-23' and '2016-11-23'

alter table Stat add idStatus integer identity(1000,1) PRIMARY KEY;