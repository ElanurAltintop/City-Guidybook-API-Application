Create Table [dbo].[Users](
[Id] int identity(1,1) not null,
[PasswordHash] varbinary(max) null,
[PasswordSalt]  varbinary(max) null,
[Username] nvarchar(max) null
);
Create Table [dbo].[Cities](
[Id] int identity(1,1) not null,
[Description]  nvarchar(max) null,
[Name]   nvarchar(max) null,
[UserId] int not null
);
Create Table [dbo].[Photos](
[Id] int identity(1,1) not null,
[CityId] int not null,
[DateAdded] Datetime2 (7) not null,
[Description] nvarchar(max) null,
[IsMain] Bit not null,
[Url] nvarchar(max) null,
[PublicId] nvarchar(250) null
);