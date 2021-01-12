CREATE DATABASE produtosdb;

USE produtosdb;

DROP TABLE IF EXISTS `Produtos`;

CREATE TABLE `Produtos`(
  `ProdutoId` INT AUTO_INCREMENT,
  `Nome` VARCHAR(80) NOT NULL,
  `Categoria` VARCHAR(50) NOT NULL,
  `Preco` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY(`ProdutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `Produtos` VALUES (1, 'Caneta', 'Material Escolar', 5.25);
INSERT INTO `Produtos` VALUES (2, 'Lapis', 'Material Escolar', 1.40);
INSERT INTO `Produtos` VALUES (3, 'Estojo', 'Material Escolar', 15);
INSERT INTO `Produtos` VALUES (4, 'Caderno', 'Material Escolar', 8.50);