USE SedcAcademyDb

Create table Students
(
	[ID][int] NOT NULL,
	[FirstName][nvarchar](50) NOT NULL,
	[LastName][nvarchar](50) NOT NULL,
	[DateOfBirth][datetime] NOT NULL,
	[EnrolledDate][datetime] NOT NULL,
	[Gender][nvarchar](10) NULL,
	[NationalIDNumber][nvarchar] NULL,
	[StudentCardNumber][int] NULL
)

Create table Teachers
(
	[ID][int] NOT NULL,
	[FirstName][nvarchar](50) NOT NULL,
	[LastName][nvarchar](50) NOT NULL,
	[DateOfBirth][datetime] NOT NULL,
	[AcademicRank][nvarchar] NULL,
	[HireDate][datetime] NOT NULL
)

Create Table Course
(
	[ID][int] NOT NULL,
	[Name][nvarchar](50) NOT NULL,
	[Credit][int]NOT NULL,
	[AcademicYear][int] NOT NULL,
	[Semester][int] NOT NULL
)
Create Table GradeDetails
(
	[ID][int] NOT NULL,
	[GradeID][int] NOT NULL,
	[AchivementTypeID][int] NOT NULL,
	[AchivementPoints][int] NOT NULL,
	[AchivementMaxPoints][int] NOT NULL,
	[AchivementDate][datetime] NOT NULL
)

Create Table AchievementType
(
	[ID][int] NOT NULL,
	[Name][nvarchar](50) NOT NULL,
	[Description][nvarchar](MAX) NULL,
	[ParticipationRate][int] NULL
)

Create Table Grade 
(
	[ID][int] NOT NULL,
	[StudentID][int] NOT NULL,
	[CourseID][int] NOT NULL,
	[TeacherID][int] NOT NULL,
	[Grade][int] NOT NULL,
	[Comment][nvarchar](MAX) NuLL,
	[CreatedDate][datetime] NOT NULL

)