CREATE TABLE [dbo].[VehicleModel] (
    [ModelId]       INT          IDENTITY (1, 1) NOT NULL,
	[Name]          VARCHAR (50) NOT NULL,
    [EngineSize]    INT          NOT NULL,
    [NumberOfDoors] INT          NOT NULL,
    [Colour]        VARCHAR (50) NOT NULL,
    [VehicleTypeId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ModelId] ASC),
    FOREIGN KEY ([VehicleTypeId]) REFERENCES [dbo].[VehicleType] ([VehicleTypeId])
);

