CREATE TABLE [dbo].[Vehicle] (
    [VehicleId] INT  IDENTITY (1, 1) NOT NULL,
    [MakeId]    INT  NOT NULL,
    [ModelId]   INT  NOT NULL,
    [Year]      INT  NOT NULL,
    [Price]     REAL NOT NULL,
    [Cost]      REAL NOT NULL,
    [SoldDate]  DATE NOT NULL,
    [Sold] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([VehicleId] ASC),
    FOREIGN KEY ([MakeId]) REFERENCES [dbo].[Make] ([MakeId]),
    FOREIGN KEY ([ModelId]) REFERENCES [dbo].[VehicleModel] ([ModelId])
);

