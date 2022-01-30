-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.27 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para funcad
CREATE DATABASE IF NOT EXISTS `funcad` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `funcad`;

-- Copiando estrutura para procedure funcad.altera_funcionario
DELIMITER //
CREATE PROCEDURE `altera_funcionario`(
	IN `codFuncionario` INT,
	IN `cargo` VARCHAR(25),
	IN `dataAdmissao` DATE,
	IN `nome` VARCHAR(50),
	IN `dataNascimento` DATE,
	IN `nacionalidade` VARCHAR(25),
	IN `naturalidade` VARCHAR(25),
	IN `numCTPS` VARCHAR(25),
	IN `remuneracao` DECIMAL(20,2)
)
BEGIN
UPDATE funcad.funcionarios AS f SET
f.cargo = cargo,
f.dataAdmissao = dataAdmissao,
f.nome = nome,
f.dataNascimento = dataNascimento,
f.nacionalidade = nacionalidade,
f.naturalidade = naturalidade,
f.numCTPS = numCTPS,
f.remuneracao = remuneracao
WHERE f.codFuncionario = codFuncionario;
END//
DELIMITER ;

-- Copiando estrutura para procedure funcad.deleta_funcionario
DELIMITER //
CREATE PROCEDURE `deleta_funcionario`(
	IN `codFuncionario` INT
)
BEGIN
DELETE FROM funcad.funcionarios
WHERE funcionarios.codFuncionario = codFuncionario;
END//
DELIMITER ;

-- Copiando estrutura para tabela funcad.funcionarios
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `codFuncionario` int NOT NULL AUTO_INCREMENT,
  `cargo` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dataAdmissao` date NOT NULL,
  `nome` varchar(50) NOT NULL,
  `dataNascimento` date NOT NULL,
  `nacionalidade` varchar(25) NOT NULL,
  `naturalidade` varchar(25) NOT NULL,
  `numCTPS` varchar(25) NOT NULL,
  `remuneracao` decimal(20,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`codFuncionario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela funcad.funcionarios: 0 rows
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` (`codFuncionario`, `cargo`, `dataAdmissao`, `nome`, `dataNascimento`, `nacionalidade`, `naturalidade`, `numCTPS`, `remuneracao`) VALUES
	(1, 'Cafeicultor', '2022-01-29', 'Joaquim da Silva', '1984-04-15', 'Brasileiro', 'Machado - MG', '856.98998.62-5', 1250.50),
	(2, 'Cafeicultor', '2022-01-28', 'Renato Fialcci', '1994-05-02', 'Brasileiro', 'Alfenas - MG', '880.78732.97-6', 1250.50),
	(3, 'Cafeicultor', '2022-01-28', 'Marcelo Caixeta', '2003-05-04', 'Brasileiro', 'Machado - MG', '702.73890.24-8', 1250.50);
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;

-- Copiando estrutura para procedure funcad.insere_funcionario
DELIMITER //
CREATE PROCEDURE `insere_funcionario`(
	IN `cargo` VARCHAR(25),
	IN `dataAdmissao` DATE,
	IN `nome` VARCHAR(50),
	IN `dataNascimento` DATE,
	IN `nacionalidade` VARCHAR(25),
	IN `naturalidade` VARCHAR(25),
	IN `numCTPS` VARCHAR(25),
	IN `remuneracao` DECIMAL(20,2)
)
BEGIN
INSERT INTO funcad.funcionarios
(cargo, dataAdmissao, nome, dataNascimento, nacionalidade, naturalidade, numCTPS, remuneracao)
VALUES
(cargo, dataAdmissao, nome, dataNascimento, nacionalidade, naturalidade, numCTPS, remuneracao);
END//
DELIMITER ;

-- Copiando estrutura para procedure funcad.lista_funcionarios
DELIMITER //
CREATE PROCEDURE `lista_funcionarios`()
BEGIN
SELECT * FROM funcad.funcionarios;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
