-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22/10/2025 às 13:31
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `medtrackdb`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `autorizacao`
--

CREATE TABLE `autorizacao` (
  `idAutorizacao` int(11) NOT NULL,
  `dataInicio` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `dadosvitais`
--

CREATE TABLE `dadosvitais` (
  `IdUsuario` int(11) NOT NULL,
  `Nome` longtext NOT NULL,
  `CPF` longtext NOT NULL,
  `DataNascimento` datetime(6) DEFAULT NULL,
  `Sexo` longtext NOT NULL,
  `Altura` longtext NOT NULL,
  `Peso` longtext NOT NULL,
  `TipoSanguineo` longtext NOT NULL,
  `SUS` longtext NOT NULL,
  `NomeContato` longtext NOT NULL,
  `TelefoneContato` longtext NOT NULL,
  `Relacionamento` longtext NOT NULL,
  `Medicamento` longtext NOT NULL,
  `Dosagem` longtext NOT NULL,
  `Frequencia` longtext NOT NULL,
  `Observacoes` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `dadosvitais`
--

INSERT INTO `dadosvitais` (`IdUsuario`, `Nome`, `CPF`, `DataNascimento`, `Sexo`, `Altura`, `Peso`, `TipoSanguineo`, `SUS`, `NomeContato`, `TelefoneContato`, `Relacionamento`, `Medicamento`, `Dosagem`, `Frequencia`, `Observacoes`) VALUES
(6, 'Carlos Oliveira', '222.222.222-22', '1988-12-12 00:00:00.000000', 'Masculino', '1.89', '78kg', 'B+', '111.111.111-12', 'Maria Oliveira', '(16) 97777-1234', 'Esposa', 'Ibuprofeno', '200mg', '12/12h', 'Alérgico a Dipirona');

-- --------------------------------------------------------

--
-- Estrutura para tabela `historico`
--

CREATE TABLE `historico` (
  `idHistorico` int(11) NOT NULL,
  `descricao` text DEFAULT NULL,
  `dataRegistro` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `perfil`
--

CREATE TABLE `perfil` (
  `idPerfil` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `profissional`
--

CREATE TABLE `profissional` (
  `idProfissional` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `especialidade` varchar(100) DEFAULT NULL,
  `registroCRM` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `IdUsuario` int(11) NOT NULL,
  `NomeUsuario` longtext NOT NULL,
  `EmailUsuario` longtext NOT NULL,
  `CpfUsuario` longtext NOT NULL,
  `SenhaUsuario` longtext NOT NULL,
  `ConfirmarSenhaUsuario` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`IdUsuario`, `NomeUsuario`, `EmailUsuario`, `CpfUsuario`, `SenhaUsuario`, `ConfirmarSenhaUsuario`) VALUES
(9, 'Bruna Santana', 'brunaSantana@email.com', '345.123.567-34', '12345', '12345'),
(10, 'Fernando Henrique ', 'FernandoHenrique@gmail.com ', '234.345.678-23', '12345', '12345');

-- --------------------------------------------------------

--
-- Estrutura para tabela `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20251018202342_InitialCreate', '9.0.10');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `autorizacao`
--
ALTER TABLE `autorizacao`
  ADD PRIMARY KEY (`idAutorizacao`);

--
-- Índices de tabela `dadosvitais`
--
ALTER TABLE `dadosvitais`
  ADD PRIMARY KEY (`IdUsuario`);

--
-- Índices de tabela `historico`
--
ALTER TABLE `historico`
  ADD PRIMARY KEY (`idHistorico`);

--
-- Índices de tabela `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`idPerfil`);

--
-- Índices de tabela `profissional`
--
ALTER TABLE `profissional`
  ADD PRIMARY KEY (`idProfissional`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`IdUsuario`);

--
-- Índices de tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `dadosvitais`
--
ALTER TABLE `dadosvitais`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
