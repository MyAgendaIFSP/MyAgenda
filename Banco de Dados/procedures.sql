USE my_agenda
GO

create
procedure GetModeloUsuario @user_id int
as 
begin
	
	select usuario.id, usuario.nome, usuario.data_nascimento
	from usuario
	inner join matriz_tempo on usuario.matriz_tempo = matriz_tempo.id
	and usuario.id = @user_id;
	
end
go

create
procedure GetUsuarioItensMatriz @user_id int
as 
begin

	select item_matriz.id, item_matriz.quadrante, item_matriz.titulo, item_matriz.descricao, item_matriz.ativo,item_matriz.data_adicao
	from item_matriz
	inner join matriz_tempo on item_matriz.matriz = matriz_tempo.id
	inner join usuario on usuario.matriz_tempo = matriz_tempo.id
	where usuario.id = @user_id;
	
end
go

create
procedure GetItensMatriz @matriz_id int
as 
begin

	select item_matriz.id, item_matriz.quadrante, item_matriz.titulo, item_matriz.descricao, item_matriz.ativo,item_matriz.data_adicao
	from item_matriz
	inner join matriz_tempo on item_matriz.matriz = matriz_tempo.id
	where matriz_tempo.id = @matriz_id;
	
end
go

create
procedure NovoItemMatriz @mat_id int, @quadrante int, @titulo varchar(50), @descricao varchar(100)
as
begin

	declare @id int;

	insert into item_matriz (matriz, quadrante, titulo, descricao, ativo, data_adicao)
	values(@mat_id, @quadrante, @titulo, @descricao, 1, getdate());

	select @id = max(id) from item_matriz;

	return @id;

end
go

create
procedure GetContatos @usuario_id int
as
begin

	SELECT usuario.nome, usuario.email, usuario.id, usuario.estado
	FROM(
			SELECT contato.usuario AS uid
			FROM contato
			inner join lista_contatos on lista_contatos.id = contato.lista_contato
			WHERE lista_contatos.usuario = @usuario_id
		) as contatos, usuario
	WHERE usuario.id = contatos.uid;
end
go

create
procedure BuscaContato @usuario_id int, @busca varchar(255)
as
begin

	select id, nome, email, estado
	from usuario
	where (usuario.nome like concat('%', @busca, '%') or email like concat('%', @busca, '%'))
	and id <> @usuario_id
	and id not in (select contato.usuario
					from contato
					inner join lista_contatos
					on contato.lista_contato = lista_contatos.id
					where lista_contatos.usuario = @usuario_id);

end
go

create
procedure NovoContato @contato int, @usuario int
as
begin

	declare @lista_contato int;

	select @lista_contato = id
	from lista_contatos
	where lista_contatos.usuario = @usuario;

	insert into contato values(@lista_contato, @contato);

	return @@rowcount;

end
go

create
procedure NovaConversa @usuario int, @contato int
as
begin

	declare @id int;

	insert into conversa (usuario_criador, usuario_dest, [data])
	values(@usuario, @contato, getdate());

	select @id = max(id) from conversa;

	return @id;

end
go