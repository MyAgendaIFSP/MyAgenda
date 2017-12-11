USE my_agenda
GO

INSERT INTO dbo.matriz_tempo(ultima_utilizacao,inicializacao)
VALUES (getdate(), getdate())

INSERT INTO dbo.matriz_tempo(ultima_utilizacao,inicializacao)
VALUES (getdate(), getdate())

INSERT INTO dbo.matriz_tempo(ultima_utilizacao,inicializacao)
VALUES (getdate(), getdate())

INSERT INTO dbo.matriz_tempo(ultima_utilizacao,inicializacao)
VALUES (getdate(), getdate())

INSERT INTO dbo.usuario(matriz_tempo,nome,email,senha,salt)
VALUES (1,'Allex','allexxrodriguess@gmail.com','pWKzzvsyID3bW6eJ4gD6s5Xy2aaw4WrOIk8IC+Xm2AU=','XL2z3UkUhe4oh7FLu+Y43+ykQK5z+TdWr2HJ9pz1YlE=');

INSERT INTO dbo.usuario(matriz_tempo,nome,email,senha,salt)
VALUES (2,'Nilzete','nilzetdias@hotmail.com','pWKzzvsyID3bW6eJ4gD6s5Xy2aaw4WrOIk8IC+Xm2AU=','XL2z3UkUhe4oh7FLu+Y43+ykQK5z+TdWr2HJ9pz1YlE=');

INSERT INTO dbo.usuario(matriz_tempo,nome,email,senha,salt)
VALUES (3,'Noilson','noilsonamaral@gmail.com','pWKzzvsyID3bW6eJ4gD6s5Xy2aaw4WrOIk8IC+Xm2AU=','XL2z3UkUhe4oh7FLu+Y43+ykQK5z+TdWr2HJ9pz1YlE=');

INSERT INTO dbo.usuario(matriz_tempo,nome,email,senha,salt)
VALUES (4,'Petit','petiti_pidoga@gmail.com','pWKzzvsyID3bW6eJ4gD6s5Xy2aaw4WrOIk8IC+Xm2AU=','XL2z3UkUhe4oh7FLu+Y43+ykQK5z+TdWr2HJ9pz1YlE=');

--Item matriz
--MATRIZ 1
INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 01' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 02' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,2 ,'teste 03' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,3 ,'teste 04' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 05' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 06' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 07' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 08' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,3 ,'teste 09' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,2 ,'teste 10' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,2 ,'teste 11' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,3 ,'teste 12' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 13' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 14' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 15' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 16' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,3 ,'teste 17' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,1 ,'teste 18' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,2 ,'teste 19' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 20' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (1 ,4 ,'teste 21' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

--MATRIZ 2
INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 01' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,2 ,'teste 03' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 05' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 07' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,4 ,'teste 08' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,3 ,'teste 09' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,2 ,'teste 10' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,3 ,'teste 12' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 13' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,4 ,'teste 14' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 15' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,1 ,'teste 18' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,2 ,'teste 19' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,4 ,'teste 20' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (2 ,4 ,'teste 21' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

--MATRIZ 3
INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (3 ,1 ,'teste 01' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (3 ,2 ,'teste 03' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (3 ,1 ,'teste 05' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (3 ,1 ,'teste 07' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

--MATRIZ 4
INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (4 ,1 ,'teste 15' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (4 ,1 ,'teste 18' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (4 ,2 ,'teste 19' ,'Lorem ipsum dorem sit amet.' ,0,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (4 ,4 ,'teste 20' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

INSERT INTO dbo.item_matriz (matriz ,quadrante ,titulo ,descricao ,ativo ,data_adicao)
VALUES (4 ,4 ,'teste 21' ,'Lorem ipsum dorem sit amet.' ,1,getdate());

--CONTATOS
INSERT INTO lista_contatos(usuario)
VALUES (1);

INSERT INTO contato
VALUES (1, 2);

INSERT INTO contato
VALUES (1, 3);