create database Calculadora_Precificacao;
use Calculadora_Precificacao;

CREATE TABLE Empresa (
    id_empresa int primary key auto_increment,
    cnpj varchar(18) UNIQUE NOT NULL,
    Custo_empresa  double NOT NULL,
    Frete_saida double,
    Ir_social_venda double
);

CREATE TABLE Tipo_Tributacao (
    id_tributacao int PRIMARY KEY auto_increment,
    descricao varchar(40),
    icms_interno double NOT NULL,
    pis_interno double NOT NULL,
    cofins_interno doublE NOT NULL
);
CREATE TABLE Estado (
    id_estado int PRIMARY KEY auto_increment,
    nome varchar (80) UNIQUE ,
    sigla varchar(2) UNIQUE
);
CREATE TABLE Fornecedor (
    id_fornecedor int AUTO_INCREMENT primary KEY,
    cnpj varchar(18) UNIQUE NOT NULL,
    nome_fantasia varchar(100),
    suframa bool,
    credito bool,
    
    fk_Estado_id_estado int NOT NULL,
    foreign key (fk_estado_id_estado) REFERENCES estado(id_estado)
);

CREATE TABLE Precificacao (
    id_precificacao int PRIMARY KEY auto_increment,
    custo_compra double NOT NULL,
    Frete_compra double,
    icms_barreira_compra double,
    outros_compra double,
    frete_venda double,
    comissao_venda double,
    lucro_liquido double NOT NULL,
    preco_venda_final double NOT NULL,
    Formula_venda double NOT NULL,
    Descricao varchar(100) NOT NULL,
    
    fk_Empresa_id_empresa int NOT NULL,
    foreign key (fk_empresa_id_empresa) REFERENCES empresa(id_empresa),
    fk_Tipo_Tributacao_id_tributacao int NOT NULL,
    foreign key (fk_Tipo_Tributacao_id_tributacao) REFERENCES tipo_tributacao(id_tributacao),
    fk_Fornecedor_id_fornecedor int NOT NULL,
    foreign key (fk_fornecedor_id_fornecedor) REFERENCES fornecedor(id_fornecedor)
);

CREATE TABLE Tributacao_Estado (
    id_Tributacao_Estado int PRIMARY KEY auto_increment,
    icms_credito double,
    pis_credito double,
    cofins_credito double,
    
    fk_Estado_id_estado int NOT NULL,
    FOREIGN KEY (fk_estado_id_estado) REFERENCES estado(id_estado),
    fk_Tipo_Tributacao_id_tributacao int,
    FOREIGN KEY (fk_tipo_tributacao_id_tributacao) REFERENCES tipo_tributacao(id_tributacao)
);

INSERT INTO Estado (nome, sigla) VALUES
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amapá', 'AP'),
('Amazonas', 'AM'),
('Bahia', 'BA'),
('Ceará', 'CE'),
('Distrito Federal', 'DF'),
('Espírito Santo', 'ES'),
('Goiás', 'GO'),
('Maranhão', 'MA'),
('Mato Grosso', 'MT'),
('Mato Grosso do Sul', 'MS'),
('Minas Gerais', 'MG'),
('Pará', 'PA'),
('Paraíba', 'PB'),
('Paraná', 'PR'),
('Pernambuco', 'PE'),
('Piauí', 'PI'),
('Rio de Janeiro', 'RJ'),
('Rio Grande do Norte', 'RN'),
('Rio Grande do Sul', 'RS'),
('Rondônia', 'RO'),
('Roraima', 'RR'),
('Santa Catarina', 'SC'),
('São Paulo', 'SP'),
('Sergipe', 'SE'),
('Tocantins', 'TO');




 