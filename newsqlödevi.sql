CREATE DATABASE DersProgramiDB;
GO
USE DersProgramiDB;
GO

CREATE TABLE Kullanicilar(
    KullaniciID INT PRIMARY KEY IDENTITY(1,1),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Sifre VARCHAR(255) NOT NULL,
    Rol VARCHAR(20) NOT NULL CHECK (Rol IN ('Ogrenci','Ogretmen'))
);

CREATE TABLE Ogrenciler (
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    KullaniciID INT NOT NULL UNIQUE,
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL,
    Bolum VARCHAR(100),
    FOREIGN KEY (KullaniciID) REFERENCES Kullanicilar(KullaniciID)
);

CREATE TABLE Ogretmenler (
    OgretmenID INT PRIMARY KEY IDENTITY(1,1),
    KullaniciID INT NOT NULL UNIQUE,
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL,
    FOREIGN KEY (KullaniciID) REFERENCES Kullanicilar(KullaniciID)
);

CREATE TABLE Dersler (
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersKodu VARCHAR(20) NOT NULL UNIQUE,
    DersAdi VARCHAR(100) NOT NULL
);

CREATE TABLE Siniflar (
    SinifID INT PRIMARY KEY IDENTITY(1,1),
    SinifAdi VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE DersProgrami (
    ProgramID INT PRIMARY KEY IDENTITY(1,1),
    DersID INT NOT NULL,
    OgretmenID INT NOT NULL,
    SinifID INT NOT NULL,
    Gun VARCHAR(15) NOT NULL,
    BaslangicSaat TIME NOT NULL,
    BitisSaat TIME NOT NULL,
    FOREIGN KEY (DersID) REFERENCES Dersler(DersID),
    FOREIGN KEY (OgretmenID) REFERENCES Ogretmenler(OgretmenID),
    FOREIGN KEY (SinifID) REFERENCES Siniflar(SinifID)
);

CREATE TABLE DersKayitlari (
    KayitID INT PRIMARY KEY IDENTITY(1,1),
    OgrenciID INT NOT NULL,
    DersID INT NOT NULL,
    FOREIGN KEY (OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY (DersID) REFERENCES Dersler(DersID),
    CONSTRAINT UQ_Ogrenci_Ders UNIQUE (OgrenciID, DersID)
);

-- Sýnýf çakýþma kontrol
GO
CREATE TRIGGER TR_Sinif_Cakisma
ON DersProgrami
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN DersProgrami dp
        ON i.SinifID = dp.SinifID
        AND i.Gun = dp.Gun
        AND i.ProgramID <> dp.ProgramID
        AND (
            i.BaslangicSaat < dp.BitisSaat AND
            i.BitisSaat > dp.BaslangicSaat
        )
    )
    BEGIN
        RAISERROR('Sinif saat cakismasi!',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

-- Öðretmen çakýþma kontrolü
GO
CREATE TRIGGER TR_Ogretmen_Cakisma
ON DersProgrami
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN DersProgrami dp
        ON i.OgretmenID = dp.OgretmenID
        AND i.Gun = dp.Gun
        AND i.ProgramID <> dp.ProgramID
        AND (
            i.BaslangicSaat < dp.BitisSaat AND
            i.BitisSaat > dp.BaslangicSaat
        )
    )
    BEGIN
        RAISERROR('Ogretmen saat cakismasi!',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--Öðrenci çakýþma kontrolü
GO
CREATE TRIGGER TR_Ogrenci_Cakisma
ON DersKayitlari
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN DersProgrami dp1 ON i.DersID = dp1.DersID
        JOIN DersKayitlari dk ON i.OgrenciID = dk.OgrenciID
        JOIN DersProgrami dp2 ON dk.DersID = dp2.DersID
        WHERE i.KayitID <> dk.KayitID
        AND dp1.Gun = dp2.Gun
        AND (
            dp1.BaslangicSaat < dp2.BitisSaat AND
            dp1.BitisSaat > dp2.BaslangicSaat
        )
    )
    BEGIN
        RAISERROR('Ogrenci saat cakismasi!',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--Test Verileri
INSERT INTO Kullanicilar VALUES
('ogr1@mail.com','123','Ogrenci'),
('ogr2@mail.com','123','Ogrenci'),
('ogrt1@mail.com','123','Ogretmen');

INSERT INTO Ogrenciler VALUES
(1,'Ali','Yilmaz','Bilgisayar'),
(2,'Ayse','Demir','Yazilim');

INSERT INTO Ogretmenler VALUES
(3,'Ahmet','Kaya');

INSERT INTO Dersler VALUES
('MAT101','Matematik'),
('FIZ101','Fizik');

INSERT INTO Siniflar VALUES
('A101'),('B202');

INSERT INTO DersProgrami VALUES
(1,1,1,'Pazartesi','09:00','11:00'),
(2,1,2,'Pazartesi','11:00','13:00');

INSERT INTO DersKayitlari VALUES
(1,1),
(1,2);


USE DersProgramiDB;
GO
-- Daha fazla test verisi ekleyerek veritabanýný zenginleþtirdik.

INSERT INTO Kullanicilar (Email, Sifre, Rol) VALUES 
('ogr3@mail.com', '123', 'Ogrenci'),
('ogr4@mail.com', '123', 'Ogrenci'),
('ogrt2@mail.com', '123', 'Ogretmen');


INSERT INTO Ogrenciler (KullaniciID, Ad, Soyad, Bolum) VALUES 
(4, 'Zeynep', 'Ak', 'Endustri Mühendisliði'),
(5, 'Can', 'Tekin', 'Mekatronik Mühendisliði');


INSERT INTO Ogretmenler (KullaniciID, Ad, Soyad) VALUES 
(6, 'Fatma', 'Sonmez');


INSERT INTO Dersler (DersKodu, DersAdi) VALUES 
('KIM101', 'Genel Kimya'),
('BIO101', 'Biyoloji');


INSERT INTO DersProgrami (DersID, OgretmenID, SinifID, Gun, BaslangicSaat, BitisSaat) VALUES 
(3, 2, 1, 'Pazartesi', '13:00', '15:00'), 
(4, 2, 2, 'Sali', '09:00', '11:00');      

INSERT INTO DersKayitlari (OgrenciID, DersID) VALUES 
(3, 3), 
(4, 1), 
(4, 4);

INSERT INTO DersKayitlari (OgrenciID, DersID) VALUES (2, 4)



--Procedure
GO
CREATE PROCEDURE sp_OgrenciDersleri
@OgrenciID INT
AS
SELECT d.DersAdi, dp.Gun, dp.BaslangicSaat, dp.BitisSaat
FROM DersKayitlari dk
JOIN Dersler d ON dk.DersID = d.DersID
JOIN DersProgrami dp ON d.DersID = dp.DersID
WHERE dk.OgrenciID = @OgrenciID;
GO

--Fonksiyonlar
GO
CREATE FUNCTION fn_GuneGoreDersler(@Gun VARCHAR(15))
RETURNS TABLE
AS
RETURN
SELECT d.DersAdi, dp.BaslangicSaat, dp.BitisSaat
FROM DersProgrami dp
JOIN Dersler d ON dp.DersID = d.DersID
WHERE dp.Gun = @Gun;
GO
--Kontrol Satýrlarý
select *from Kullanicilar
select *from Ogrenciler
select *from Ogretmenler
select *from Dersler
select *from DersKayitlari
select *from Siniflar
select * from DersProgrami
SELECT * FROM fn_GuneGoreDersler('Pazartesi');
INSERT INTO DersProgrami
VALUES (1,1,1,'Pazartesi','10:00','12:00');




USE DersProgramiDB;
GO
--yeni veriler ekleyerek veritabanýný zenginleþtirdik.

INSERT INTO Kullanicilar (Email, Sifre, Rol) VALUES 
('ogr3@mail.com', '123', 'Ogrenci'),
('ogr4@mail.com', '123', 'Ogrenci'),
('ogrt2@mail.com', '123', 'Ogretmen');


INSERT INTO Ogrenciler (KullaniciID, Ad, Soyad, Bolum) VALUES 
(4, 'Zeynep', 'Ak', 'Endustri Mühendisliði'),
(5, 'Can', 'Tekin', 'Mekatronik Mühendisliði');


INSERT INTO Ogretmenler (KullaniciID, Ad, Soyad) VALUES 
(6, 'Fatma', 'Sonmez');


INSERT INTO Dersler (DersKodu, DersAdi) VALUES 
('KIM101', 'Genel Kimya'),
('BIO101', 'Biyoloji');


INSERT INTO DersProgrami (DersID, OgretmenID, SinifID, Gun, BaslangicSaat, BitisSaat) VALUES 
(3, 2, 1, 'Pazartesi', '13:00', '15:00'), -- Kimya, Fatma Hoca, A101 (A101 boþaldýktan sonra)
(4, 2, 2, 'Sali', '09:00', '11:00');      -- Biyoloji, Fatma Hoca, B202 (Farklý gün)

INSERT INTO DersKayitlari (OgrenciID, DersID) VALUES 
(3, 3), 
(4, 1), 
(4, 4);

INSERT INTO DersKayitlari (OgrenciID, DersID) VALUES (2, 4);

