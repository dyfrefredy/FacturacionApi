CREATE PROCEDURE [prv].[SP_Dian166Insert]  
(  
      @pDian166 UTT_Dian1166 readonly  
)  
AS 
BEGIN
BEGIN TRANSACTION SP_Dian166Insert
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRY
		INSERT INTO [prv].[Dian1166] (										
										[NumDian1166], 
										[AirlineId], 
										[UserId],
										[StationId], 
										[CreatedDate]
									)
	SELECT
				dn.NumDian1166, 
				dn.AirlineId,				
				dn.UserId,				
				st.id,
				getdate() AS UploadDate										
		FROM  @pDian166 dn left join Dian1166 di on
			dn.NumDian1166  = di.NumDian1166 inner join [User] usr			
			ON usr.id = dn.UserId inner join Station st 
			ON usr.StationId = st.id			
		WHERE di.NumDian1166 is null

		 COMMIT TRANSACTION SP_Dian166Insert
    END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION SP_Dian166Insert
    END CATCH

END;