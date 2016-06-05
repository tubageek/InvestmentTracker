CREATE TABLE [dbo].[MutualFundReturnType](
	[MutualFundReturnTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MutualFundReturnType] PRIMARY KEY CLUSTERED 
(
	[MutualFundReturnTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT MutualFundReturnType (MutualFundReturnTypeName)
SELECT 'Dividend'

INSERT MutualFundReturnType (MutualFundReturnTypeName)
SELECT 'Long-term Capital Gain'

INSERT MutualFundReturnType (MutualFundReturnTypeName)
SELECT 'Short-term Capital Gain'

CREATE TABLE [dbo].[MutualFundTransactionType](
	[MutualFundTransactionTypeID] [int] NOT NULL,
	[MutualFundTransactionTypeText] [varchar](50) NOT NULL,
	[CameFromCash] [bit] NOT NULL,
	[IsEmployerMatch] [bit] NOT NULL,
 CONSTRAINT [PK_MutualFundTransactionType] PRIMARY KEY CLUSTERED 
(
	[MutualFundTransactionTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT MutualFundTransactionType (MutualFundTransactionTypeID, MutualFundTransactionTypeText, CameFromCash, IsEmployerMatch)
VALUES (1, 'Cash Investment', 1, 0)

INSERT MutualFundTransactionType (MutualFundTransactionTypeID, MutualFundTransactionTypeText, CameFromCash, IsEmployerMatch)
VALUES (2, 'Pre-tax Contribution', 0, 0)

INSERT MutualFundTransactionType (MutualFundTransactionTypeID, MutualFundTransactionTypeText, CameFromCash, IsEmployerMatch)
VALUES (3, 'Employer Match', 0, 1)

CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [nvarchar](50) NOT NULL,
	[AccountCash] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[MutualFund](
	[MutualFundID] [int] NOT NULL,
	[MutualFundSymbol] [nvarchar](10) NOT NULL,
	[MutualFundDescription] [nvarchar](50) NOT NULL,
	[AccountID] [int] NOT NULL,
	[NumberOfShares] [decimal](15, 5) NOT NULL,
	[LastKnownValue] [decimal](9, 3) NOT NULL,
	[DateValueRecorded] [datetime] NULL,
	[HasBalance] [bit] NOT NULL,
	[IsRetirementFund] [bit] NOT NULL,
	[IsGoogleTracked] [bit] NOT NULL,
 CONSTRAINT [PK_MutualFund] PRIMARY KEY CLUSTERED 
(
	[MutualFundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MutualFund] ADD  CONSTRAINT [DF_MutualFund_MutualFundDescription]  DEFAULT ('') FOR [MutualFundDescription]
GO

ALTER TABLE [dbo].[MutualFund] ADD  CONSTRAINT [DF_MutualFund_HasBalance]  DEFAULT ((1)) FOR [HasBalance]
GO

ALTER TABLE [dbo].[MutualFund] ADD  CONSTRAINT [DF_MutualFund_IsRetirementFund]  DEFAULT ((0)) FOR [IsRetirementFund]
GO

ALTER TABLE [dbo].[MutualFund] ADD  CONSTRAINT [DF_MutualFund_IsGoogleTracked]  DEFAULT ((1)) FOR [IsGoogleTracked]
GO

ALTER TABLE [dbo].[MutualFund]  WITH CHECK ADD  CONSTRAINT [FK_MutualFund_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([AccountID])
GO

ALTER TABLE [dbo].[MutualFund] CHECK CONSTRAINT [FK_MutualFund_Account]
GO

CREATE TABLE [dbo].[MutualFundPriceHistory](
	[MutualFundSymbol] [char](5) NOT NULL,
	[QuoteDate] [date] NOT NULL,
	[DayPrice] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_MutualFundPriceHistory] PRIMARY KEY CLUSTERED 
(
	[MutualFundSymbol] ASC,
	[QuoteDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

CREATE TABLE [dbo].[MutualFundReturn](
	[MutualFundReturnID] [int] IDENTITY(1,1) NOT NULL,
	[MutualFundID] [int] NOT NULL,
	[MutualFundReturnTypeName] [nvarchar](50) NOT NULL,
	[Amount] [decimal](12, 3) NOT NULL,
	[NumberOfShares] [decimal](15, 5) NOT NULL,
	[PricePerShare] [decimal](12, 3) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Destination] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MutualFundReturn] PRIMARY KEY CLUSTERED 
(
	[MutualFundReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MutualFundReturn]  WITH CHECK ADD  CONSTRAINT [FK_MutualFundReturn_MutualFund] FOREIGN KEY([MutualFundID])
REFERENCES [dbo].[MutualFund] ([MutualFundID])
GO

ALTER TABLE [dbo].[MutualFundReturn] CHECK CONSTRAINT [FK_MutualFundReturn_MutualFund]
GO

ALTER TABLE [dbo].[MutualFundReturn]  WITH CHECK ADD  CONSTRAINT [FK_MutualFundReturn_MutualFundReturnType] FOREIGN KEY([MutualFundReturnTypeName])
REFERENCES [dbo].[MutualFundReturnType] ([MutualFundReturnTypeName])
GO

ALTER TABLE [dbo].[MutualFundReturn] CHECK CONSTRAINT [FK_MutualFundReturn_MutualFundReturnType]
GO

ALTER TABLE [dbo].[MutualFundReturn]  WITH CHECK ADD  CONSTRAINT [CK_MutualFundReturn_Destination] CHECK  (([Destination]='Reinvest' OR [Destination]='Cash'))
GO

ALTER TABLE [dbo].[MutualFundReturn] CHECK CONSTRAINT [CK_MutualFundReturn_Destination]
GO

CREATE TABLE [dbo].[MutualFundTransaction](
	[MutualFundTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[MutualFundID] [int] NOT NULL,
	[NumberOfShares] [decimal](15, 5) NOT NULL,
	[PricePerShare] [decimal](12, 3) NOT NULL,
	[ActualAmount] [decimal](12, 3) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Note] [nvarchar](1000) NOT NULL,
	[TransactionType] [int] NULL,
 CONSTRAINT [PK_MutualFundTransaction] PRIMARY KEY CLUSTERED 
(
	[MutualFundTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MutualFundTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MutualFundTransaction_MutualFund] FOREIGN KEY([MutualFundID])
REFERENCES [dbo].[MutualFund] ([MutualFundID])
GO

ALTER TABLE [dbo].[MutualFundTransaction] CHECK CONSTRAINT [FK_MutualFundTransaction_MutualFund]
GO

ALTER TABLE [dbo].[MutualFundTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MutualFundTransaction_MutualFundTransactionType] FOREIGN KEY([TransactionType])
REFERENCES [dbo].[MutualFundTransactionType] ([MutualFundTransactionTypeID])
GO

ALTER TABLE [dbo].[MutualFundTransaction] CHECK CONSTRAINT [FK_MutualFundTransaction_MutualFundTransactionType]
GO

CREATE VIEW [dbo].[MutualFundView]
AS
SELECT    dbo.MutualFund.MutualFundID, dbo.MutualFund.MutualFundSymbol, dbo.MutualFundReturn.Amount, dbo.MutualFundReturn.TransactionDate, dbo.MutualFundReturn.PricePerShare, 
                      dbo.MutualFundReturn.NumberOfShares, dbo.MutualFundReturn.MutualFundReturnTypeName AS ReturnType, dbo.MutualFund.MutualFundDescription, dbo.MutualFund.HasBalance,
					  dbo.MutualFund.IsRetirementFund
FROM         dbo.MutualFund INNER JOIN
                      dbo.MutualFundReturn ON dbo.MutualFund.MutualFundID = dbo.MutualFundReturn.MutualFundID
UNION ALL
SELECT    dbo.MutualFund.MutualFundID, dbo.MutualFund.MutualFundSymbol, dbo.MutualFundTransaction.ActualAmount, dbo.MutualFundTransaction.TransactionDate, dbo.MutualFundTransaction.PricePerShare, 
                      dbo.MutualFundTransaction.NumberOfShares, 'Investment' AS ReturnType, dbo.MutualFund.MutualFundDescription, dbo.MutualFund.HasBalance,
					  dbo.MutualFund.IsRetirementFund
FROM         dbo.MutualFund INNER JOIN
                      dbo.MutualFundTransaction ON dbo.MutualFund.MutualFundID = dbo.MutualFundTransaction.MutualFundID
GO

-- =============================================
-- Author:		Scott Norberg
-- Create date: 3/9/2014
-- =============================================
CREATE PROCEDURE [dbo].[GetLast12StartDate]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @IterationDate DATE
    DECLARE @ReturnDate DATE

	SET @IterationDate = CAST(GETDATE() AS DATE)
	SET @IterationDate = DATEADD(DAY, 1, @IterationDate)
	SET @IterationDate = DATEADD(YEAR, -1, @IterationDate)

	WHILE @ReturnDate IS NULL
	BEGIN
		SELECT @ReturnDate = MAX(QuoteDate) FROM dbo.MutualFundPriceHistory WHERE QuoteDate = @IterationDate
		SET @IterationDate = DATEADD(DAY, 1, @IterationDate)

		IF @IterationDate > GETDATE()
			BREAK
	END

	SELECT @ReturnDate
END

GO