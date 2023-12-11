CREATE DEFINER=`sql10669452`@`%` PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_alteraLivro`(idlivro int, titulo varchar(45), autor varchar(45), paginas int, genero int)
BEGIN
UPDATE `livros`
SET
`titulo` = titulo,
`autor` = autor,
`paginas` = paginas,
`fk_genero` = genero
WHERE idlivro = idlivros;

END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_insereGenero`(nomeGenero varchar(45))
BEGIN
 INSERT INTO `generos`
 (`genero`)
 VALUES
 (nomeGenero);
END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_insereLivro`(titulo varchar(45), autor varchar(45), paginas int, genero int)
BEGIN
INSERT INTO livros
(`titulo`,
`autor`,
`paginas`,
`fk_genero`)
VALUES
(titulo,
autor,
paginas,
genero);
END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_listaGeneros`()
BEGIN
	Select * from generos;
END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_listaLivros`()
BEGIN
	Select idlivros, titulo, autor, generos.genero, paginas
    from livros
    INNER JOIN generos 
		on livros.fk_genero = generos.idgenero;
END

CREATE DEFINER=`sql10669452`@`%` PROCEDURE `sp_removeLivro`(idlivro int)
BEGIN
	delete from livros where idlivros = idlivro;
END