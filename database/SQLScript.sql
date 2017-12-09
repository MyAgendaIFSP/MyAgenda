create database BD_IFALJ

use BD_IFALJ

create table usuario(
	id_usuario int primary key identity(1,1),
	email_usuario varchar(255) unique,
	nome_usuario varchar(255) not null,
	sobrenome_usuario varchar(255) not null,	
	senha_usuario varchar(255) not null
)

create table pomodoro(
	id_sessao int primary key identity(1,1),
	id_usuario int references usuario(id_usuario),
	tipo_sessao int check (tipo_sessao > 0 and tipo_sessao < 4), --sessao tipo 1 = Pomodoro; sessao tipo 2 = ShortBreak; sessao tipo 3 = LongBreak.
	duracao_sessao int not null,
	data_sessao datetime not null,
)

go
create view vw_relatorio_pomodoro as
select u.nome_usuario, p.duracao_sessao, p.data_sessao, tipo
from usuario as u
inner join 
 (select case when tipo_sessao = 1 then 'Pomodoro'
			when tipo_sessao = 2 then 'Short Break' 
			when tipo_sessao = 3 then 'Long Break' 
			ELSE CONVERT(VARCHAR, tipo_sessao)
			end as tipo, data_sessao, duracao_sessao, id_usuario from pomodoro)
			as p
on u.id_usuario = p.id_usuario

go


 create view vw_pomodoro as
    select tipo_sessao = (SELECT CASE
          WHEN tipo_sessao = 1 THEN 'Pomodoro'
          WHEN tipo_sessao = 2 THEN 'Short Break'
          WHEN tipo_sessao = 3 THEN 'Long Break'
          ELSE CONVERT(VARCHAR, tipo_sessao)
       END), duracao_sessao
  FROM pomodoro

  go


--  create table usuario(
--	id_usuario int primary key identity(1,1),
--	matriz_tempo int references matriz_tempo(id),
--	email_usuario varchar(255) unique,
--	nome_usuario varchar(255) not null,
--	senha_usuario varchar(255) not null,
--	salt varchar(256) not null,
--	constraint usuario_matriz_fk foreign key(matriz_tempo) references matriz_tempo(id)
--	on delete cascade
--	on update cascade
--)
