CREATE DATABASE GCIN;
GO
USE GCIN;
GO

CREATE TABLE Perfil(idPerfil integer identity(1000,1) PRIMARY KEY ,
					 descPerfil varchar(30)
);

CREATE TABLE Usuario(idUsuario integer identity(1000,1) PRIMARY KEY ,
					 nome varchar(35),
					 cpf varchar(14),
					 usuario varchar(15),
					 senha varchar(30),
					 bloqueio varchar(3),
					 idPerfil integer references Perfil(idPerfil)
);

CREATE TABLE Produto( idProduto integer identity(1000,1) PRIMARY KEY ,
					  dataCadastro date,
					  descProduto varchar(50)
);

CREATE TABLE Solicitacao(idSolicitacao integer identity(1000,1) PRIMARY KEY ,
					 dataSolicitacao date,
					 dataPrecisa date,
					 severidade varchar(50),
					 detalhe varchar(50),
					 dataPrevistaFim date,
					 idProduto integer references Produto(idProduto)
);

CREATE TABLE Stat( detalheStatus varchar(50),
				   dataStatus date,
				   statusSolicitacao varchar(50),
				   idSolicitacao integer references Solicitacao(idSolicitacao),
				   idUsuario integer references Usuario(idUsuario)
);

CREATE TABLE Fornecedor(idFornecedor integer identity(1000,1) PRIMARY KEY ,
						bloqueio varchar(3),
						nomeFornecedor varchar(35),
						telefone varchar(15),
						cidade varchar(50),
						cep varchar(9),
						endereco varchar(50),
						bairro varchar(50),
						uf varchar(2),
						email varchar(50)
);

CREATE TABLE Cotacao(idCotacao integer identity(1000,1) PRIMARY KEY ,
					 dataCotacao date,
					 statusCotacao varchar(50),
					 dataValidadeCotacao date,
					 idFornecedor integer references Fornecedor(idFornecedor)
);

CREATE TABLE Cotação_Produto(
					 valorCotado numeric(10,2),
					 venceu varchar(3),
					 idProduto integer references Produto(idProduto),
					 idSolicitacao integer references Solicitacao(idSolicitacao),
					 idCotacao integer references Cotacao(idCotacao)
);

CREATE TABLE TipoFornecimento(idTipoFornecimento integer identity(1000,1) PRIMARY KEY ,
							  descTipoFornecimento varchar(30)
);

CREATE TABLE ProduTipo(
			 idTipoFornecimento integer references TipoFornecimento(idTipoFornecimento),
			 idProduto integer references Produto(idProduto)
);

CREATE TABLE ForneceTipo(
			 idTipoFornecimento integer references TipoFornecimento(idTipoFornecimento),
			 idFornecedor integer references Fornecedor(idFornecedor)
);


select idUsuario, nome, cpf, usuario, senha, bloqueio, idPerfil from Usuario where idUsuario = idUsuario;