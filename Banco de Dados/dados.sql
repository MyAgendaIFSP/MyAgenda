USE my_agenda
GO

INSERT INTO dbo.matriz_tempo(ultima_utilizacao,inicializacao)
VALUES (getdate(), getdate())

INSERT INTO dbo.usuario(matriz_tempo,nome,email,senha,salt,data_nascimento, estado, [ip], lembrar)
VALUES (1,'Allex','allexxrodriguess@gmail.com','pWKzzvsyID3bW6eJ4gD6s5Xy2aaw4WrOIk8IC+Xm2AU=','XL2z3UkUhe4oh7FLu+Y43+ykQK5z+TdWr2HJ9pz1YlE=',cast('23/09/1998' as date),0,'177.188.60.14',0);

--Item matriz

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
