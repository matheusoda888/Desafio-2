
create table produto(
id int identity,
nome varchar(30) not null,
idFornecedor int not null,
primary key(id),
foreign key(idFornecedor)
references fornecedor(id));


create table fornecedor(
id int identity,
nome varchar(30) not null,
primary key(id));



create table cliente(
id int identity,
nome varchar(20) not null,
primary key(id));

create table clientesProdutos(
id int identity,
idCliente int not null,
idProduto int not null,

foreign key(idCliente) references cliente(id),
foreign key(idProduto) references produto(id));

select * from fornecedor
select * from produto
select * from cliente
select * from clientesProdutos


SELECT produto.nome FROM clientesProdutos
INNER JOIN cliente ON cliente.id = clientesProdutos.idCliente
INNER JOIN produto ON produto.id = clientesProdutos.idProduto
where cliente.id=1

DELETE w from clientesProdutos w
inner join cliente c on c.id = w.idCliente where c.id=1



DBCC CHECKIDENT ('cliente', reseed, 0 )
DBCC CHECKIDENT ('fornecedor', reseed, 0 )
DBCC CHECKIDENT ('produto', reseed, 0 )
DBCC CHECKIDENT ('clientesprodutos', reseed, 0 )

DELETE FROM cliente;
DELETE FROM produto; 
DELETE FROM fornecedor;
DELETE from clientesProdutos