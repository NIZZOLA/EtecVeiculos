CREATE TABLE Veiculos
(
    Id INT IDENTITY(1,1) PRIMARY KEY, -- Coluna de chave primária com auto incremento
    Titulo NVARCHAR(100) NOT NULL,     -- Título do veículo (ex. nome do modelo)
    Marca NVARCHAR(50) NOT NULL,       -- Marca do veículo
    Modelo NVARCHAR(50) NOT NULL,      -- Modelo do veículo
    Cor NVARCHAR(30),                  -- Cor do veículo
    AnoFab INT NOT NULL,               -- Ano de fabricação
    Placa NVARCHAR(10) NOT NULL,       -- Placa do veículo
    Valor DECIMAL(18, 2) NOT NULL      -- Valor do veículo com 2 casas decimais
);