-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 10-Jun-2015 às 00:07
-- Versão do servidor: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dewolfviagens`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `autorizacao`
--

CREATE TABLE IF NOT EXISTS `autorizacao` (
  `idautorizacao` int(11) NOT NULL,
  `nomeResponsavel` varchar(60) NOT NULL,
  `data` datetime NOT NULL,
  `numDocResponsavel` varchar(45) NOT NULL,
  `telefoneContato` varchar(15) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `autorizacao`
--

INSERT INTO `autorizacao` (`idautorizacao`, `nomeResponsavel`, `data`, `numDocResponsavel`, `telefoneContato`) VALUES
(12, 'Victor', '2015-06-09 16:57:25', 'mg47', '(32) 9999-9999'),
(13, 'A', '2015-06-09 16:59:05', 'FG', '(22) 2222-2222');

-- --------------------------------------------------------

--
-- Estrutura da tabela `passageiro`
--

CREATE TABLE IF NOT EXISTS `passageiro` (
  `idpassageiro` int(11) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `idade` int(11) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `autorizacao` int(11) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `passageiro`
--

INSERT INTO `passageiro` (`idpassageiro`, `nome`, `idade`, `cpf`, `rg`, `autorizacao`) VALUES
(9, 'Victor Alexsande', 20, '123.884.726-95', 'MG18635158', NULL),
(10, 'Victor', 11, '123.456.789-10', 'mg123', NULL),
(11, 'Joazin', 12, '123.884.726-95', 'mg45', NULL),
(12, 'A', 11, '111.111.111-11', 'ffff', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `passagem`
--

CREATE TABLE IF NOT EXISTS `passagem` (
  `idpassagem` int(11) NOT NULL,
  `viagem` int(11) NOT NULL,
  `passageiro` int(11) NOT NULL,
  `numPoltrona` int(11) NOT NULL,
  `vrDistancia` decimal(15,2) NOT NULL,
  `vrPedagio` decimal(15,2) NOT NULL,
  `vrTotal` decimal(15,2) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=115 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `viagem`
--

CREATE TABLE IF NOT EXISTS `viagem` (
  `idviagem` int(11) NOT NULL,
  `origem` varchar(45) NOT NULL,
  `destino` varchar(45) NOT NULL,
  `distancia` int(11) NOT NULL,
  `dataHorario` datetime NOT NULL,
  `motorista` varchar(45) NOT NULL,
  `qtdePedagio` int(11) NOT NULL,
  `vrUnitarioPedagio` decimal(15,2) NOT NULL,
  `vrUnitarioKM` decimal(15,2) NOT NULL,
  `qtdeLugares` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `viagem`
--

INSERT INTO `viagem` (`idviagem`, `origem`, `destino`, `distancia`, `dataHorario`, `motorista`, `qtdePedagio`, `vrUnitarioPedagio`, `vrUnitarioKM`, `qtdeLugares`) VALUES
(22, 'Rio de Janeiro', 'Juiz de Fora', 100, '2015-06-18 17:37:56', 'Victor', 3, '1.00', '1.00', 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autorizacao`
--
ALTER TABLE `autorizacao`
  ADD PRIMARY KEY (`idautorizacao`);

--
-- Indexes for table `passageiro`
--
ALTER TABLE `passageiro`
  ADD PRIMARY KEY (`idpassageiro`), ADD KEY `fk_autorizacao_idx` (`autorizacao`);

--
-- Indexes for table `passagem`
--
ALTER TABLE `passagem`
  ADD PRIMARY KEY (`idpassagem`), ADD KEY `pk_viagem_idx` (`viagem`), ADD KEY `fk_passageiro_idx` (`passageiro`);

--
-- Indexes for table `viagem`
--
ALTER TABLE `viagem`
  ADD PRIMARY KEY (`idviagem`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autorizacao`
--
ALTER TABLE `autorizacao`
  MODIFY `idautorizacao` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `passageiro`
--
ALTER TABLE `passageiro`
  MODIFY `idpassageiro` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `passagem`
--
ALTER TABLE `passagem`
  MODIFY `idpassagem` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=115;
--
-- AUTO_INCREMENT for table `viagem`
--
ALTER TABLE `viagem`
  MODIFY `idviagem` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=23;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `passageiro`
--
ALTER TABLE `passageiro`
ADD CONSTRAINT `fk_autorizacao` FOREIGN KEY (`autorizacao`) REFERENCES `autorizacao` (`idautorizacao`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `passagem`
--
ALTER TABLE `passagem`
ADD CONSTRAINT `fk_passageiro` FOREIGN KEY (`passageiro`) REFERENCES `passageiro` (`idpassageiro`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `fk_viagem` FOREIGN KEY (`viagem`) REFERENCES `viagem` (`idviagem`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
