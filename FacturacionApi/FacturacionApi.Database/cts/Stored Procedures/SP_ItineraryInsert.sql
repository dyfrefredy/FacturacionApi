CREATE PROCEDURE [cts].[SP_ItineraryInsert] 
	-- Add the parameters for the stored procedure here
	  (@pItinerary [UTT_Itinerary] READONLY)
AS
BEGIN
BEGIN TRANSACTION SP_ItineraryInsert
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRY
		truncate table [cts].[Itinerary]
		INSERT INTO [cts].[Itinerary] (										
										[RouteDuration],
										[RouteId],
										[LegNo],
										[DepartureCityId],
										[ArrivalCityId],
										[FlightNumber],
										[CategoryId],
										[Ac],
										[Frequency],
										[DepartureDate],
										[DepartureTime],
										[ArrivalTime]
									)
		SELECT
				itn.[RouteDuration],
				itn.[RouteId],
				itn.[LegNo],
				cdp.[Id],
				car.[Id],
				itn.[FlightNumber],
				itn.[CategoryId],
				itn.[Ac],
				itn.[Frequency],
				itn.[DepartureDate],
				itn.[DepartureTime],
				itn.[ArrivalTime]									
		FROM  @pItinerary itn 
		inner join [adm].[City] cdp on itn.LegDeparture = cdp.CityIata
		inner join [adm].[City] car on itn.LegArrival =car.CityIata

		 COMMIT TRANSACTION SP_ItineraryInsert
    END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION SP_ItineraryInsert
    END CATCH

END;