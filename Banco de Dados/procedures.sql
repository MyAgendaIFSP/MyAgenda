USE my_agenda
GO

create
procedure GetModeloUsuario @user_id int
as 
begin
	
	select usuario.id, usuario.nome, usuario.data_nascimento,
		matriz_tempo.id as matriz, matriz_tempo.inicializacao as matriz_inicializacao, matriz_tempo.ultima_utilizacao as matriz_ulti_utilizacao
	from matriz_tempo, usuario
	where usuario.matriz_tempo = matriz_tempo.id
	and usuario.id = @user_id;
	
end
go

create
procedure GetUsuarioItensMatriz @user_id int
as 
begin

	select item_matriz.id, item_matriz.quadrante, item_matriz.titulo, item_matriz.descricao, item_matriz.ativo,item_matriz.data_adicao
	from item_matriz, matriz_tempo, usuario
	where usuario.id = @user_id
	and usuario.matriz_tempo = matriz_tempo.id
	and item_matriz.matriz = matriz_tempo.id;
	
end
go

create
procedure GetItensMatriz @matriz_id int
as 
begin

	select item_matriz.id, item_matriz.quadrante, item_matriz.titulo, item_matriz.descricao, item_matriz.ativo,item_matriz.data_adicao
	from item_matriz, matriz_tempo
	where matriz_tempo.id = @matriz_id
	and item_matriz.matriz = matriz_tempo.id;
	
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

	SELECT usuario.nome, usuario.email, usuario.ip, usuario.id, usuario.estado
	FROM(
			SELECT contato.usuario AS uid
			FROM usuario, contato, lista_contatos
			WHERE lista_contatos.usuario = @usuario_id
			AND contato.lista_contato = lista_contatos.id
			AND contato.usuario = usuario.id
		) contatos, usuario
	WHERE usuario.id = contatos.uid;

end
go

create
procedure BuscaContato @usuario_id int, @busca varchar(255)
as
begin

	select id, nome, email, estado, [ip]
	from usuario
	where (usuario.nome like concat('%', @busca, '%') or email like concat('%', @busca, '%'))
	and id <> @usuario_id
	and id not in (select contato.usuario
					from contato, lista_contatos, usuario
					where lista_contatos.usuario = @usuario_id
					and contato.lista_contato = lista_contatos.id);

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