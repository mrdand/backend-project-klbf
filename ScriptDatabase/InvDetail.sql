USE project_klbf
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvHeaderID] [int] NOT NULL,
	[OrderName] [varchar](255) NOT NULL,
	[Qty] [decimal](16,2) NOT NULL,
	[Rate] [decimal](16,2) NOT NULL,
	[Amount] [decimal](16,2) NOT NULL,
 CONSTRAINT [PK_InvoiceDetail_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO