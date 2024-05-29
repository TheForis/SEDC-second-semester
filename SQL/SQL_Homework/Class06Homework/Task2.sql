CREATE PROCEDURE sp_CreateGradeDetail (
	@GradeId INT
	,@AchievementId INT
	,@AchievementPoints INT
	)
AS
BEGIN
	INSERT INTO [dbo].[GradeDetails] (
		[GradeID]
		,[AchievementTypeID]
		,[AchievementPoints]
		,[AchievementMaxPoints]
		,[AchievementDate]
		)
	VALUES (
		@GradeId
		,@AchievementId
		,@AchievementPoints
		,100
		,GETDATE()
		)

	SELECT gd.GradeID
		,(SUM(Cast(gd.AchievementPoints AS DECIMAL(10, 2))) / max(gd.AchievementMaxPoints) * Sum(at.ParticipationRate)) AS GradePoints
	FROM GradeDetails gd
	INNER JOIN AchievementType at ON gd.AchievementTypeID = at.ID
	WHERE gd.GradeID = @GradeId
	GROUP BY gd.GradeID
END
