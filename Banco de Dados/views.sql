use my_agenda
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

create view vw_relatorio_pomodoro as
select u.nome, p.duracao_sessao, p.data_sessao, tipo
from usuario as u
inner join 
 (select case when tipo_sessao = 1 then 'Pomodoro'
			when tipo_sessao = 2 then 'Short Break' 
			when tipo_sessao = 3 then 'Long Break' 
			ELSE CONVERT(VARCHAR, tipo_sessao)
			end as tipo, data_sessao, duracao_sessao, id_usuario from pomodoro)
			as p
on u.id = p.id_usuario

go