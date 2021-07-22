USE project_klbf
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceHeader](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvNo] [varchar](40) NOT NULL,
	[Language] [varchar](255) NOT NULL,
	[Currency] [varchar](255) NOT NULL,
	[FromAddress] [varchar](255) NOT NULL,
	[NameTo] [varchar](255) NOT NULL,
	[AddressTo] [varchar](255) NOT NULL,
	[DueDate] DATETIME NOT NULL,
	[InvDue] [varchar](255) NOT NULL,
	[PrchNo] [varchar](255) NOT NULL,
	[SubTotal] [decimal](15,2) NOT NULL,
	[Disc] [decimal](3,2) NOT NULL,
	[GrandTotal] [decimal](16,2) NOT NULL,
 CONSTRAINT [PK_InvoiceHeader_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


