create database my_agenda;

use my_agenda;

create table matriz_tempo(
	id int primary key identity(1,1) not null,
	ultima_utilizacao datetime null,
	inicializacao datetime null
);

create table pomodoro(
	id int primary key identity(1,1) not null,
	ultima_utilizacao datetime null,
	inicializacao datetime null
);

create table item_matriz(
	id int primary key identity(1,1) not null,
	matriz int not null,
	quadrante int not null,
	titulo varchar(50) not null,
	descricao varchar(100) null,
	ativo bit not null default 1,
	data_adicao datetime not null,
	constraint item_matriz_fk foreign key(matriz) references matriz_tempo(id)
	on delete cascade
	on update cascade
);

create table secao_pomodoro(
	pomodoro int not null,
	qtde_secoes_trab int null,
	mdata datetime null,
	duracao_secao_trab int null,
	duracao_pausa_curta int null,
	qtde_pausas int null,
	duracao_pausa_longa int null,
	constraint secao_pomodoro_fk foreign key(pomodoro) references pomodoro(id)
	on delete cascade
	on update cascade
);

create table lista_contatos(
	 id int primary key identity(1,1) not null,
	 usuario int not null
);

create table usuario (
	id int primary key identity(1,1) not null,
	matriz_tempo int null,
	pomodoro int null,
	estado int not null,
	nome varchar(100) not null,
	email varchar(50) not null,
	senha varchar(256) not null,
	salt varchar(256) not null,
	lembrar int not null,
	data_nascimento date not null,
	constraint usuario_pomodoro_fk foreign key(pomodoro) references pomodoro(id)
	on delete cascade
	on update cascade,
	constraint usuario_matriz_fk foreign key(matriz_tempo) references matriz_tempo(id)
	on delete cascade
	on update cascade,
	constraint usuario_lista_contatos_fk foreign key(lista_contatos) references lista_contatos(id)
	on delete cascade
	on update cascade
);

alter table lista_contatos add 
constraint lista_contatos_usuario_fk foreign key(usuario) references usuario(id)
on delete no action
on update no action;

create table contato(
	lista_contato int not null,
	usuario int not null,
	constraint contato_lista_fk foreign key(lista_contato) references lista_contatos(id)
	on delete cascade
	on update cascade,
	constraint contato_usuario_fk foreign key(usuario) references usuario(id)
	on delete no action
	on update no action
);

create table conversa(
	id int primary key identity(1,1) not null,
	usuario_criador int not null,
	usuario_dest int not null,
	data datetime not null,
	constraint conversa_criador_fk foreign key(usuario_criador) references usuario(id)
	on delete cascade
	on update cascade,
	constraint conversa_dest_fk foreign key(usuario_dest) references usuario(id)
	on delete no action
	on update no action
);

create table mensagem(
	conversa int not null,
	destinatario int not null,
	texto varchar(1024) not null,
	estado int not null,
	data datetime not null
);

create table evento(
	id int primary key identity(1,1) not null,
	usuario int not null,
	titulo varchar(50) not null,
	descricao varchar (255) null,
	inicio datetime not null,
	final datetime null,
	constraint evento_fk foreign key(usuario) references usuario(id)
	on delete cascade
	on update cascade
);

create table lista_afazeres(
	titulo varchar(50) not null,
	usuario int not null,
	criacao datetime not null,
	constraint lista_afazeres_id primary key(titulo, usuario),
	constraint lista_afazeres_fk foreign key(usuario) references usuario(id)
	on delete cascade
	on update cascade
);

create table tarefa(
	lista varchar(50) not null,
	usuario int not null,
	titulo varchar(50) not null,
	mdata datetime null,
	descricao varchar(100) null,
	constraint tarefa_id primary key(lista, titulo),
	constraint tarefa_fk foreign key(lista, usuario) references lista_afazeres(titulo, usuario)
	on delete cascade
	on update cascade
);