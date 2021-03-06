USE [LabTestsResults]
GO
/****** Object:  StoredProcedure [dbo].[spCarbohydrateMetabolismTestResult]    Script Date: 16.10.2016 21:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 14.10.2016
-- Description:	Insert Carbohydrate Metabolism Test Result 
-- =============================================
CREATE PROCEDURE [dbo].[spCarbohydrateMetabolismTestResult] 
	-- Add the parameters for the stored procedure here
	@id_patient int, 
	@name_of_test nvarchar(30),  
	@date_of_result nvarchar(20), 
	@glucose float, 
	@sial_acid float, 
	@lactic_acid float
	AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO CarbohydrateMetabolismTestResult
	(id_patient, name_of_test, date_of_result, glucose, sial_acid, lactic_acid)
	VALUES
	(@id_patient, @name_of_test, @date_of_result, @glucose, @sial_acid, @lactic_acid)
END


-- =============================================
-- Author:		Kupranets
-- Create date: 16.10.2016
-- Description:	Delete Patient By Id
-- =============================================
CREATE PROCEDURE [dbo].[spDeletePatientById] 
	-- Add the parameters for the stored procedure here
	@id_patient int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Patient
	WHERE id_patient = @id_patient;
END


-- =============================================
-- Author:		Ivan Kupranets 
-- Create date: 16.10.2016
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGeneralBloodTestResultInfo] 
	-- Add the parameters for the stored procedure here
	@id_patient int, 
	@name_of_test nvarchar(30), 
	@date_of_result nvarchar(30), 
	@erythrocytes float, 
	@hemoglobin float, 
	@hematocrit float, 
	@color_indicator float,
	@mch float, 
	@mchc float, 
	@mcv float, 
	@rdw float, 
	@average_size_erythrocytes float, 
	@platelets float, 
	@white_blood_cells float, 
	@eosinophils float,
	@lymphocytes float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO GeneralBloodTestResult
	(id_patient, name_of_test, date_of_result, erythrocytes, hemoglobin, hematocrit, color_indicator,
		mch, mchc, mcv, rdw, average_size_erythrocytes, platelets, white_blood_cells, eosinophils,
		lymphocytes)
	VALUES
	(@id_patient, @name_of_test, @date_of_result, @erythrocytes, @hemoglobin, @hematocrit, @color_indicator,
		@mch, @mchc, @mcv, @rdw, @average_size_erythrocytes, @platelets, @white_blood_cells, @eosinophils,
		@lymphocytes)
END


-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 13.10.2016
-- Description:	Get All Patients Grouped By Id
-- =============================================
CREATE PROCEDURE [dbo].[spGetAllPatients] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Patient.id_patient, Patient.name, Patient.last_name, gender, date_of_birth, place_of_residence, blood_type, 
		   Patient.email_adress, Patient.phone_number,name_of_test, date_of_registration,
		   Asistant.name_of_asistent, Asistant.last_name_of_asistent, Asistant.id_asistant 
	FROM Patient 
	INNER JOIN PatientRegistration
	ON Patient.id_patient = PatientRegistration.id_patient
	INNER JOIN Asistant
	ON PatientRegistration.id_asistant = Asistant.id_asistant;
END


-- =============================================
-- Author:		Kupranets Ivan
-- Create date: 11.10.2016
-- Description:	Get Patient Results by Name of Test
-- =============================================
CREATE PROCEDURE [dbo].[spGetPatientResultByNameOfTest] 
	-- Add the parameters for the stored procedure here
	@test_name nvarchar(35)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF(@test_name = 'General Blood Test')
	BEGIN 
			SELECT * 
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN GeneralBloodTestResult
			ON Patient.id_patient = GeneralBloodTestResult.id_patient 
			WHERE PatientRegistration.name_of_test = @test_name
	END
	IF(@test_name = 'Urina Test')
	BEGIN
			SELECT *
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN UrinaTestResult
			ON Patient.id_patient = UrinaTestResult.id_patient 
			WHERE PatientRegistration.name_of_test = @test_name
	END
	IF(@test_name = 'Carbohydrate Metabolism Test')
	BEGIN
			SELECT *
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN CarbohydrateMetabolismTestResult
			ON Patient.id_patient = CarbohydrateMetabolismTestResult.id_patient
			WHERE PatientRegistration.name_of_test = @test_name
	END
	IF(@test_name = 'Protein Metabolism Test')
	BEGIN
			SELECT * 
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN ProteinMetabolismTestResult
			ON Patient.id_patient = ProteinMetabolismTestResult.id_patient
			WHERE PatientRegistration.name_of_test = @test_name
	END
	IF(@test_name = 'Vitamins Test')
	BEGIN
			SELECT *
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN VitaminsTestResult
			ON Patient.id_patient = VitaminsTestResult.id_patient
			WHERE PatientRegistration.name_of_test = @test_name
	END
END



-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 12.10.2016
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[spGetPatientResultsByName] 
	-- Add the parameters for the stored procedure here
	@name_patient nvarchar(20),
	@last_name nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @test_name nvarchar(30);
	SET @test_name = (SELECT name_of_test 
	FROM PatientRegistration
	WHERE id_patient = (SELECT id_patient 
						FROM Patient
						WHERE name = @name_patient AND last_name = @last_name));
	PRINT @test_name;
	IF(@test_name = 'General Blood Test')
	BEGIN 
			SELECT * FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN GeneralBloodTestResult
			ON Patient.id_patient = GeneralBloodTestResult.id_patient
			WHERE Patient.name = @name_patient 
	END
	IF(@test_name = 'Urina Test')
	BEGIN
			SELECT * FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN UrinaTestResult
			ON Patient.id_patient = UrinaTestResult.id_patient
			WHERE Patient.name = @name_patient; 
	END
	IF(@test_name = 'Carbohydrate Metabolism Test')
	BEGIN
			SELECT * FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN CarbohydrateMetabolismTestResult
			ON Patient.id_patient = CarbohydrateMetabolismTestResult.id_patient
			WHERE Patient.name = @name_patient; 
	END
	IF(@test_name = 'Protein Metabolism Test')
	BEGIN
			SELECT * FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN ProteinMetabolismTestResult
			ON Patient.id_patient = ProteinMetabolismTestResult.id_patient
			WHERE Patient.name = @name_patient; 
	END
	IF(@test_name = 'Vitamins Test')
	BEGIN
			SELECT * FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			LEFT OUTER JOIN VitaminsTestResult
			ON Patient.id_patient = VitaminsTestResult.id_patient
			WHERE Patient.name = @name_patient; 
	END

END

-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 16.10.2016
-- Description:	Get All Patients By Name Of Asiatant
-- =============================================
CREATE PROCEDURE [dbo].[spGetPatientsByNameOfAsistant] 
	-- Add the parameters for the stored procedure here
	@name_of_asistent nvarchar(30),
	@last_name_of_asistent nvarchar(30) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT * 
			FROM Patient
			INNER JOIN PatientRegistration
			ON  Patient.id_patient = PatientRegistration.id_patient
			INNER JOIN Asistant 
			ON PatientRegistration.id_asistant = Asistant.id_asistant
			WHERE Asistant.name_of_asistent = @name_of_asistent
			AND Asistant.last_name_of_asistent = @last_name_of_asistent;
END


-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 14.10.2016
-- Description:	Insert Asistant Information
-- =============================================
CREATE PROCEDURE [dbo].[spInsertAsistantInfo] 
	-- Add the parameters for the stored procedure here
	@name_of_asistent nvarchar(15), 
	@last_name_of_asistent nvarchar(20), 
	@email_adress nvarchar(25), 
	@phone_number nvarchar(12)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	INSERT INTO Asistant
	(name_of_asistent, last_name_of_asistent, email_adress, phone_number)
	VALUES
	(@name_of_asistent, @last_name_of_asistent, @email_adress, @phone_number)

END


-- =============================================
-- Author:		Ivan Kupranets
-- Create date: <14.10.2016>
-- Description:	Insert Patients
-- =============================================
CREATE PROCEDURE [dbo].[spInsertPatientInfo]

	@name nvarchar(15),
	@last_name nvarchar(20),
	@gender nvarchar(10),
	@date_of_birth nvarchar(20),
	@place_of_residence nvarchar(30),
	@blood_type nvarchar(2),
	@email_adress nvarchar(25),
	@phone_number nvarchar(12) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Patient
	(name, last_name, gender, date_of_birth, place_of_residence, blood_type, email_adress, phone_number)
	VALUES
	(@name, @last_name, @gender, @date_of_birth, @place_of_residence, @blood_type, @email_adress, @phone_number)
END


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertProteinMetabolismTestResultInfo]
	-- Add the parameters for the stored procedure here
	@id_patient int, 
	@name_of_test nvarchar(30), 
	@date_of_result nvarchar(20), 
	@general_protein float, 
	@albumin float, 
	@globulin float, 
	@fibrinogen float, 
	@creatinine float,
	@creatine_kinase float, 
	@urea float, 
	@urea_acid float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO ProteinMetabolismTestResult
	(id_patient, name_of_test, date_of_result, general_protein, albumin, globulin, fibrinogen, creatinine,
	 creatine_kinase, urea, urea_acid)
	VALUES
	(@id_patient, @name_of_test, @date_of_result, @general_protein, @albumin, @globulin, @fibrinogen, @creatinine,
	 @creatine_kinase, @urea, @urea_acid)
END


-- =============================================
-- Author:		Ivan Kupranets
-- Create date: 14.10.2016
-- Description:	Insert Registration
-- =============================================
CREATE PROCEDURE [dbo].[spInsertRegistration] 
	-- Add the parameters for the stored procedure here 
	@name_of_test nvarchar(30),
	@name_of_asistent nvarchar(20),
	@last_name_of_asistent nvarchar(30),
	@name nvarchar(20),
	@last_name nvarchar(30)
	AS
BEGIN
	SET NOCOUNT ON;
	
	-- Insert statements for procedure here
	DECLARE @id_patient int;
	SET @id_patient = (SELECT id_patient 
					   FROM Patient
					   WHERE name = @name
					   AND last_name = @last_name);
	DECLARE @id_asistent int;
	SET @id_asistEnt = (SELECT id_asistant
						FROM Asistant
						WHERE name_of_asistent = @name_of_asistent
						AND last_name_of_asistent = @last_name_of_asistent);

	INSERT INTO PatientRegistration
	(id_patient, id_asistant, name_of_test, date_of_registration)
	VALUES
	(@id_patient, @id_asistent, @name_of_test, GETDATE())

END


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertUrinaTestResultInfo] 
	-- Add the parameters for the stored procedure here
	@id_patient int, 
	@name_of_test nvarchar(30),
	@date_of_result nvarchar(30), 
	@pH_value float,
	@protein float, 
	@sugar float, 
	@nitrite float,
    @ketone float, 
	@bilirubin float,
	@urobilinogen float, 
	@red_blood_cells float, 
	@white_blood_cells float
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO UrinaTestResult
	(id_patient, name_of_test, date_of_result, pH_value, protein, sugar, nitrite, ketone, bilirubin,
	 urobilinogen, red_blood_cells, white_blood_cells)
	VALUES
	(@id_patient, @name_of_test, @date_of_result, @pH_value, @protein, @sugar, @nitrite, @ketone, @bilirubin,
	 @urobilinogen, @red_blood_cells, @white_blood_cells)

END

-- =============================================
-- Author:	Ivan Kupranets
-- Create date: 14.10.2016
-- Description:	Insert Vitamins Ttest Result
-- =============================================
CREATE PROCEDURE [dbo].[spInsertVitaminsTestResultInfo] 
	-- Add the parameters for the stored procedure here
	@id_patient int, 
	@name_of_test nvarchar(30), 
	@date_of_result nvarchar(20), 
	@kaltsydol float, 
	@cobalamin float, 
	@folic_acid float, 
	@pyridoxine float, 
	@retinol float, 
	@tocopherol float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO VitaminsTestResult
	(id_patient, name_of_test, date_of_result, kaltsydol, cobalamin, folic_acid, pyridoxine, retinol, tocopherol)
	VALUES
	(@id_patient, @name_of_test, @date_of_result, @kaltsydol, @cobalamin, @folic_acid, @pyridoxine, @retinol, @tocopherol)
END


CREATE PROCEDURE  [dbo].[spGetUserByLogin] 
	-- Add the parameters for the stored procedure here
	@login varchar(50),
	@password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT id, first_name, sur_name, [login], [disabled] 
	FROM UserLogin
	WHERE [login] = @login	AND [password] = @password;
END