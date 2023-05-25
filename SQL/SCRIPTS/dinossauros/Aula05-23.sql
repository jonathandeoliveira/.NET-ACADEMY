-- AULA 23/05 --
create table java
(
    professor varchar(20) null
)
create table net
(
    professor varchar(20) null
)

insert into net
values ('Fabrício'),('Ricardo'),('Alexandre')


insert into java
values ('Fabrício'),('Lucas'),('Deivison')

select * from java
union
select * from net

-- INNER JOIN -- 
select * from java -- conjunto A (esquerda)
inner join net -- conjunto B (direita)
on java.professor = net.professor   -- coluna que queremos o  juntar

-- LEFT JOIN --
select * from java -- conjunto A (esquerda)
left join net -- conjunto B (direita)
on java.professor = net.professor   -- coluna que queremos o  juntar

-- LEFT JOIN  exclusivo --
select * from java -- conjunto A (esquerda)
left join net -- conjunto B (direita)
on java.professor = net.professor   -- coluna que queremos o  juntar
where net.professor is null

-- RIGHT JOIN -- 
select * from java -- conjunto A (esquerda)
right join net -- conjunto B (direita)
on java.professor = net.professor   -- coluna que queremos o  juntar

-- RIGHT JOIN exclusivo -- 
select * from java -- conjunto A (esquerda)
right join net -- conjunto B (direita)
on java.professor = net.professor   -- coluna que queremos o  juntar
where java.professor is null

-- FULL OUTER JOIN -- td de tudo
select * from java  -- conjunto A (esquerda)
full outer join net -- conjunto B (direita)
on java.professor = net.professor

-- OUTER JOIN EXCLUSIVO --
select * from java  -- conjunto A (esquerda)
full outer join net -- conjunto B (direita)
on java.professor = net.professor
where java.professor  is null 
	or net.professor is null


----- Exercicios  -----


--7. Crie uma consulta para relacionar todos os dados disponíveis de todos 
--		os livros existentes na biblioteca em alfabética de título;

select * FROM LIVRO
inner join EDITORA
on LIVRO.FK_EDITORA = EDITORA.ID
order by TITULO

--8. Crie uma consulta para relacionar todos os dados disponíveis de todos 
--		os livros existentes na biblioteca en alfabética de Autor;

SELECT * FROM LIVRO
FULL OUTER JOIN LIVROAUTOR ON LIVRO.ISBN = LIVROAUTOR.FK_LIVRO
FULL OUTER JOIN AUTOR ON LIVROAUTOR.FK_AUTOR = AUTOR.ID;


-- --9. Crie uma consulta para relacionar todos os dados disponíveis 
--		dos livros da categoria de literatura Juvenil e ordem de ano;
select * from CATEGORIA
inner join LIVRO
on CATEGORIA.ID = LIVRO.FK_CATEGORIA
order by ANO_PUBLICACAO ASC


--10. Crie uma consulta para relacionar todos os dados disponíveis
--	  dos livros de humor ou ficção científica con 2000 e 2010.
select * from LIVRO
inner join CATEGORIA on CATEGORIA.ID = LIVRO.FK_CATEGORIA
where CATEGORIA.id = 3 or  CATEGORIA.ID = 1 and  LIVRO.ANO_PUBLICACAO between YEAR(2000) and YEAR(2020)


--------- // TRIGGERS // -----------

create table log 
(
    id integer not null primary key identity,
    acao varchar(10) not null,
    descricao varchar(100),
    quando datetime not null
)

select * from java
select * from log
select * from net

delete from java where professor = 'Lucas'

create trigger primeira_trigger
on java
AFTER DELETE
as 
BEGIN
	insert into log values ('Exclusão','Um professor de Java foi excluído', GETDATE())
END

---------------------------- 

create trigger segunda_trigger on java after insert as
begin
	insert into log values ( 'Inserção', 'Adiciona professor de java', GETDATE());
	print('Dados Inseridos');
end

insert into java values('Lucas')
select * from java
select * from log

---------------------------- 

create trigger terceira_trigger on java after insert as
begin
	declare @contagem int
	select @contagem = (select count(professor) from java)
	print('Quantidade de professores:' + convert(varchar(10), @contagem)  );
	if @contagem < 4
		begin
			insert into log values ( 'Inserção', 'Adiciona professor de java', GETDATE());
			print('Dados Inseridos');
		end
	else
		begin
			rollback;
			insert into log values ( 'Inserção', 'Tentativa de inserção mal sucedida', GETDATE());
			raiserror('INVÁLIDO',14, 1);
			return;
			end
end

delete from java where professor = 'Deivison'
insert into java values('Lucas')
insert into java values('Deivison')
select * from java
select * from log

-------

drop trigger segunda_trigger
drop trigger terceira_trigger

-------

create trigger quarta_trigger on java after update as
begin
	declare @anterior varchar(20)
    declare @novo varchar(20)

    select @anterior = (select deleted.professor from deleted)
    select @novo = (select inserted.professor from inserted)

    IF(ROWCOUNT_BIG() = 0)
        return;

    IF @anterior= @novo
   		begin
       		raiserror('SEM ALTERAÇÕES', 14, 1);
       		rollback transaction;
       		insert into log values ('Update', 
           		'Tentativa de update mal sucedida!', GETDATE());
   		end
    ELSE
   		begin
       		insert into log values ('Update', 
           		'Alteração do professor, de ' + @anterior + 
           		' para o professor ' + @novo, GETDATE());
   		end
end

select * from java
select * from log
update java set professor = 'Deivison' 
where professor = 'Lucas'