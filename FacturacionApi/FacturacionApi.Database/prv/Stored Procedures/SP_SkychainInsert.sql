
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [prv].[SP_SkychainInsert] 
	-- Add the parameters for the stored procedure here
	  (@pSkychain [UTT_Skychain] READONLY)
AS
BEGIN
BEGIN TRANSACTION SP_SkychainInsert
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRY
		INSERT INTO [prv].[Skychain] (										
										[AWB],
										[FlightDate],
										[AirlineId],
										[FlightNumber],
										[Piece],
										[Weight], 
										[CityOriginId], 
										[CityDestinationId], 
										[SenderName],
										[SenderAddress],
										[ConsigneeName], 
										[ConsigneeAddress], 
										[NatureGoods], 
										[Active], 
										[UserSkychain],
										[UserId], 
										[StationId],
										[CreatedDate]
									)
		SELECT
				uts.[AWB], 
				uts.[FlightDate],
				arn.Id,
				uts.[FlighNumber],
				uts.[Piece], 
				uts.[Weight], 
				cty2.Id as CityIniId,
				cty1.Id as CityOrgId,
				uts.[SenderName], 
				uts.[SenderAddress], 
				uts.[ConsigneeName], 
				uts.[ConsigneeAddress], 
				uts.[NatureGoods], 		
				0 AS Active,
				uts.[UserSkychain],
				usr.Id AS UserId,
				st.Id,
				getdate() AS UploadDate										
		FROM  @pSkychain uts left join [Skychain] sch			
			ON sch.[AWB] = uts.[AWB] left join [AirlineCross] arl 
			ON uts.[Airline] = arl.[SKAirlineCode]
			inner join Airline arn 
			on arn.IataCod = uts.[Airline]
			inner join City cty1
			ON cty1.CityIata = uts.[Origin]
			inner join City cty2			
			ON cty2.CityIata = uts.[Destination]
			inner join [user] usr on 
			usr.Id = uts.UserId 
			inner join [Station] st on
			st.Id = usr.StationId
		WHERE sch.[AWB] is null

		 COMMIT TRANSACTION SP_SkychainInsert
    END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION SP_SkychainInsert
    END CATCH

END;