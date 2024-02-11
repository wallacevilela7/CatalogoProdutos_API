CREATE DATABASE CATALOGO_PRODUTOS;

USE CATALOGO_PRODUTOS;

CREATE TABLE Produto (
id int not null primary key identity(1,1),
nome varchar(50) not null,
descricao varchar(100) not null,
categoria varchar(50) not null,
quantidadeEstoque int not null,
preco decimal not null,
dataCricao date not null
);

INSERT INTO Produto (nome, descricao, categoria, quantidadeEstoque, preco, dataCricao)
VALUES ('Lanterna Solar de Aventura', 
        'Lanterna Solar 30 chars', 
        'Equipamento de Camping/Aventura', 
        50, 
        39.99, 
        '2024-02-10');

SELECT * FROM Produto;

