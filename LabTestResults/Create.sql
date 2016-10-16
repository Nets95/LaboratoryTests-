USE LabTestsResults
GO

CREATE TABLE  UserLogin
(
	id int not null IDENTITY (1,1),
	first_name nvarchar(50) not null,
	sur_name nvarchar(50) not null,
	[login] varchar(50) not null,
	[password] varchar(50) not null,
	[disabled] bit not null,
	CONSTRAINT PK_tblUser_Id PRIMARY KEY(id),
	CONSTRAINT UQ_tblUser_Login UNIQUE ([login])
);

CREATE TABLE Asistant
	(
		id_asistant int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		name_of_asistent nvarchar(15) NOT NULL,
		last_name_of_asistent nvarchar(20),
		email_adress nvarchar(35),
		phone_number numeric(12),  
	)
	GO
	
CREATE TABLE Patient
	(
		id_patient int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		name nvarchar(15) NOT NULL,
		last_name nvarchar(20) NOT NULL,
		gender nvarchar(10),
		date_of_birth nvarchar(20),
		place_of_residence nvarchar(25),
		blood_type nvarchar(1) NOT NULL,
		email_adress nvarchar(35),
		phone_number nvarchar(12) 
	)
	GO
CREATE TABLE PatientRegistration
	(
		id_patient int NOT NULL,
		id_asistant int NOT NULL,
		name_of_test nvarchar(30),
		date_of_registration nvarchar(30), 
		FOREIGN KEY(id_patient)	REFERENCES Patient(id_patient)
		 ON DELETE CASCADE ON UPDATE CASCADE,
		FOREIGN KEY(id_asistant) REFERENCES Asistant(id_asistant)
		 ON DELETE CASCADE ON UPDATE CASCADE,
		CONSTRAINT PK_CONSTRAINT PRIMARY KEY(id_patient, id_asistant),
		 
		

	)
	GO
CREATE TABLE UrinaTestResult
	(
		id_urina_result int NOT NULL IDENTITY(1,1) PRIMARY KEY,
		id_patient int NOT NULL,
		name_of_test nvarchar(30),
		date_of_result datetime,
		pH_value float DEFAULT NULL,
		protein float DEFAULT NULL,
		sugar float DEFAULT NULL,
		nitrite float DEFAULT NULL,
		ketone float DEFAULT NULL,
		bilirubin float DEFAULT NULL,
		urobilinogen float DEFAULT NULL,
		red_blood_cells float DEFAULT NULL,
		white_blood_cells float DEFAULT NULL,
		FOREIGN KEY (id_patient) REFERENCES Patient(id_patient) 
		ON DELETE CASCADE ON UPDATE CASCADE 
	)
	GO
	CREATE TABLE GeneralBloodTestResult 
	(
		id_blood_result int NOT NULL IDENTITY(1,1) PRIMARY KEY,
		id_patient int NOT NULL,
		name_of_test nvarchar(30),
		date_of_result datetime,
		erythrocytes float DEFAULT NULL,
		hemoglobin float DEFAULT NULL,
		hematocrit float DEFAULT NULL,
		color_indicator float DEFAULT NULL,
		mch int DEFAULT NULL,
		mchc int DEFAULT NULL,
		mcv	int DEFAULT NULL,
		rdw int DEFAULT NULL,
		average_size_erythrocytes float DEFAULT NULL,
		platelets float DEFAULT NULL,
		white_blood_cells float DEFAULT NULL,
		eosinophils float DEFAULT NULL,
		lymphocytes float DEFAULT NULL,
		FOREIGN KEY (id_patient) REFERENCES Patient(id_patient) 
		ON DELETE CASCADE ON UPDATE CASCADE
	)
	GO
	CREATE TABLE ProteinMetabolismTestResult
	(
		id_protein_metabolism_result int NOT NULL IDENTITY(1,1) PRIMARY KEY,
		id_patient int NOT NULL,
		name_of_test nvarchar(30),
		date_of_result datetime,
		general_protein float DEFAULT NULL,
		albumin float DEFAULT NULL,
		globulin float DEFAULT NULL,
		fibrinogen float DEFAULT NULL,
		creatinine float DEFAULT NULL,
		creatine_kinase float DEFAULT NULL,
		urea float DEFAULT NULL,
		urea_acid float DEFAULT NUll,
		FOREIGN KEY (id_patient) REFERENCES Patient(id_patient) 
		ON DELETE CASCADE ON UPDATE CASCADE
	)
	GO
	CREATE TABLE CarbohydrateMetabolismTestResult
	(
		id_carbohydrate_metabolism_result int NOT NULL IDENTITY(1,1) PRIMARY KEY,
		id_patient int NOT NULL,
		name_of_test nvarchar(30),
		date_of_result datetime,
		glucose float DEFAULT NULL,
		sial_acid float DEFAULT NULL,
		lactic_acid float DEFAULT NULL,
		FOREIGN KEY (id_patient) REFERENCES Patient(id_patient)
		ON DELETE CASCADE ON UPDATE CASCADE
	)
	GO
	CREATE TABLE VitaminsTestResult
	(
		id_vitamins_result int NOT NULL IDENTITY(1,1) PRIMARY KEY,	
		id_patient int NOT NULL,
		name_of_test nvarchar(30),
		date_of_result datetime,
		kaltsydol float DEFAULT NULL,
		cobalamin float DEFAULT NULL,
		folic_acid float DEFAULT NULL,
		pyridoxine float DEFAULT NULL,
		retinol float DEFAULT NULL,
		tocopherol float DEFAULT NULL,
		FOREIGN KEY (id_patient) REFERENCES Patient(id_patient)
		ON DELETE CASCADE ON UPDATE CASCADE
	)
	GO


