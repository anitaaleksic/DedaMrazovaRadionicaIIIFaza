--dodato update i promenjeno za nullable kod igracke I DODATI PK U N:M VEZE
--------------------------------------------------------
--DDL ZA BRISANJE TABELA
--------------------------------------------------------
DROP TABLE "DETE" cascade constraints;

DROP TABLE "PISMO" cascade constraints;

DROP TABLE "TOVAR" cascade constraints;

DROP TABLE "POKLON" cascade constraints;

DROP TABLE "IRVAS" cascade constraints;

DROP TABLE "PESMA" cascade constraints;

DROP TABLE "VILENJAK_IGRACKE" cascade constraints;

DROP TABLE "VILENJAK_POKLONI" cascade constraints;

DROP TABLE "VILENJAK_TOVAR" cascade constraints;

DROP TABLE "VILENJAK_IRVASI" cascade constraints;

DROP TABLE "DEO_RADIONICE" cascade constraints;

DROP TABLE "IGRACKA" cascade constraints;

DROP TABLE "ZELJA" cascade constraints;

DROP TABLE "TIM" cascade constraints;

DROP TABLE "JE_PAKOVAO" cascade constraints;

DROP TABLE "ISPORUCUJE" cascade constraints;

DROP TABLE "ZNA" cascade constraints;

DROP TABLE "MAGICNA_VESTINA" cascade constraints;

DROP TABLE "ZAHTEVA" cascade constraints;

DROP TABLE "POSEDUJE" cascade constraints;

DROP TABLE "IMA" cascade constraints;


----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--DDL ZA BRISANJE SEKVENCI
--------------------------------------------------------
DROP SEQUENCE "DETE_ID_SEQ";

DROP SEQUENCE "PISMO_ID_SEQ";

DROP SEQUENCE "TOVAR_SIFRA_SEQ";

DROP SEQUENCE "POKLON_SEQ";

DROP SEQUENCE "IRVAS_ID_SEQ";

DROP SEQUENCE "PESMA_ID_SEQ";

DROP SEQUENCE "VILENJAK_ID_SEQ";

DROP SEQUENCE "DEO_RADIONICE_ID_SEQ";

DROP SEQUENCE "IGRACKA_ID_SEQ";

DROP SEQUENCE "TIM_ID_SEQ";

--NOVO

DROP SEQUENCE "JE_PAKOVAO_ID_SEQ";

DROP SEQUENCE "ISPORUCUJE_ID_SEQ";

DROP SEQUENCE "ZNA_ID_SEQ";

DROP SEQUENCE "IMA_ID_SEQ";

DROP SEQUENCE "POSEDUJE_ID_SEQ";

DROP SEQUENCE "ZAHTEVA_ID_SEQ";

DROP SEQUENCE "ZELJA_ID_SEQ";

--DROP SEQUENCE "MAGICNA_VESTINA_ID_SEQ";


----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--DDL ZA BRISANJE TRIGERA
--------------------------------------------------------
DROP TRIGGER "DETE_AUTO_PK";

DROP TRIGGER "PISMO_AUTO_PK";

DROP TRIGGER "TOVAR_AUTO_PK";

DROP TRIGGER "POKLON_AUTO_PK";

DROP TRIGGER "IRVAS_AUTO_PK";

DROP TRIGGER "PESMA_AUTO_PK";

DROP TRIGGER "VILENJAK_I_AUTO_PK";

DROP TRIGGER "VILENJAK_P_AUTO_PK";

DROP TRIGGER "VILENJAK_T_AUTO_PK";

DROP TRIGGER "VILENJAK_IRV_AUTO_PK";

DROP TRIGGER "DEO_RADIONICE_AUTO_PK";

DROP TRIGGER "IGRACKA_AUTO_PK";

DROP TRIGGER "TIM_AUTO_PK";

--NOVO

DROP TRIGGER "JE_PAKOVAO_AUTO_PK";

DROP TRIGGER "ISPORUCUJE_AUTO_PK";

DROP TRIGGER "ZNA_AUTO_PK";

DROP TRIGGER "IMA_AUTO_PK";

DROP TRIGGER "POSEDUJE_AUTO_PK";

DROP TRIGGER "ZAHTEVA_AUTO_PK";

DROP TRIGGER "ZELJA_AUTO_PK";

--DROP TRIGGER "MAGICNA_VESTINA_AUTO_PK";


----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--DDL for Sequence DETE_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "DETE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence PISMO_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "PISMO_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence TOVAR_SIFRA_SEQ
--------------------------------------------------------
CREATE SEQUENCE "TOVAR_SIFRA_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence POKLON_SEQ
--------------------------------------------------------
CREATE SEQUENCE "POKLON_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence IRVAS_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "IRVAS_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence PESMA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "PESMA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence VILENJAK_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "VILENJAK_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence DEO_RADIONICE_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "DEO_RADIONICE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence IGRACKA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "IGRACKA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence TIM_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "TIM_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;

--NOVO 

--------------------------------------------------------
--DDL for Sequence JE_PAKOVAO_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "JE_PAKOVAO_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence ISPORUCUJE_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "ISPORUCUJE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence ZNA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "ZNA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence IMA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "IMA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence POSEDUJE_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "POSEDUJE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence ZAHTEVA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "ZAHTEVA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence ZELJA_ID_SEQ
--------------------------------------------------------
CREATE SEQUENCE "ZELJA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;
--------------------------------------------------------
--DDL for Sequence MAGICNA_VESTINA_ID_SEQ
--------------------------------------------------------
--CREATE SEQUENCE "MAGICNA_VESTINA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999999999999999999999 START WITH 1 INCREMENT BY 1;


----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--  DDL for Table DETE
--------------------------------------------------------
CREATE TABLE "DETE"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"PREZIME" VARCHAR2(30 BYTE),
	"DATUM_RODJENJA" DATE,
	"DRZAVA" VARCHAR2(30 BYTE),
	"GRAD" VARCHAR2(30 BYTE),
	"ADRESA" VARCHAR2(30 BYTE),
	"IME_MAJKE" VARCHAR2(30 BYTE),
	"IME_OCA" VARCHAR2(30 BYTE)	
);
--------------------------------------------------------
--  DDL for Table PISMO
--------------------------------------------------------
CREATE TABLE "PISMO" 
( 
	"ID" NUMBER(10,0),
	"DATUM_SLANJA" DATE,
	"DATUM_PRIJEMA" DATE,
	"INDEKS_DOBROTE" NUMBER(2,1),
	"TEKST" VARCHAR2(100 BYTE),
	"ID_DETE" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table TOVAR
--------------------------------------------------------
CREATE TABLE "TOVAR"
(
	"SIFRA" NUMBER(10,0),
	"GRAD" VARCHAR2(30 BYTE)
);
--------------------------------------------------------
--  DDL for Table POKLON
--------------------------------------------------------
CREATE TABLE "POKLON"
(
	"SIFRA" NUMBER(10,0),
	"BOJA" VARCHAR2(30 BYTE),
	"POSVETA" VARCHAR2(30 BYTE),
	"SIFRA_TOV" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table IRVAS
--------------------------------------------------------
CREATE TABLE "IRVAS"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"NADIMAK" VARCHAR2(30 BYTE),
	"POL" CHAR(1 BYTE),
	"DATUM_RODJENJA" DATE
);
--------------------------------------------------------
--  DDL for Table PESMA
--------------------------------------------------------
CREATE TABLE "PESMA"
(
	"ID" NUMBER(10,0),
	"NAZIV" VARCHAR2(30 BYTE),
	"TEKST" VARCHAR2(100 BYTE)
);
--------------------------------------------------------
--  DDL for Table VILENJAK_IGRACKE
--------------------------------------------------------
CREATE TABLE "VILENJAK_IGRACKE"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"ZEMLJA_POREKLA" VARCHAR2(30 BYTE),
	"RADNI_STAZ" VARCHAR2(30 BYTE),
	"OCENA" NUMBER(2,1),
	"TRAJANJE_OBUKE" VARCHAR2(30 BYTE),
	"SPECIJALIZOVAN_ZA" VARCHAR2(30 BYTE),
	"SEF" CHAR(2 BYTE),
	"MENTOR" CHAR(2 BYTE),
	"KOORDINATOR" CHAR(2 BYTE),
	"ID_TIM" NUMBER(10,0),
	"ID_MENT" NUMBER(10,0),
	"ID_RAD" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for VILENJAK_POKLONI
--------------------------------------------------------
CREATE TABLE "VILENJAK_POKLONI"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"ZEMLJA_POREKLA" VARCHAR2(30 BYTE),
	"RADNI_STAZ" VARCHAR2(30 BYTE)	
);
--------------------------------------------------------
--  DDL for Table VILENJAK_TOVAR
--------------------------------------------------------
CREATE TABLE "VILENJAK_TOVAR"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"ZEMLJA_POREKLA" VARCHAR2(30 BYTE),
	"RADNI_STAZ" VARCHAR2(30 BYTE),
	"TOVAR_SIFRA" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table VILENJAK_IRVASI
--------------------------------------------------------
CREATE TABLE "VILENJAK_IRVASI"
(
	"ID" NUMBER(10,0),
	"IME" VARCHAR2(30 BYTE),
	"ZEMLJA_POREKLA" VARCHAR2(30 BYTE),
	"RADNI_STAZ" VARCHAR2(30 BYTE),
	"ID_IRVAS" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table DEO_RADIONICE
--------------------------------------------------------
CREATE TABLE "DEO_RADIONICE"
(
	"ID" NUMBER(10,0),
	"NAZIV" VARCHAR2(30 BYTE),
	"BROJ_VILENJAKA" NUMBER(10,0),
	"TIP_IGRACAKA" VARCHAR2(30 BYTE),
	"ID_SEFA" NUMBER(10,0),
	"DATUM_POSTAVLJANJA" DATE
);
--------------------------------------------------------
--  DDL for IGRACKA
--------------------------------------------------------
CREATE TABLE "IGRACKA" 
(
	"ID" NUMBER(10,0),
	"REDNI_BROJ" NUMBER(10,0),
	"TIP" VARCHAR2(30 BYTE),
	"OPIS" VARCHAR2(30 BYTE),
	"ID_VILENJAK" NUMBER(10,0),
	"SIFRA_POKLONA" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table ZELJA
--------------------------------------------------------
CREATE TABLE "ZELJA"
(
	"ID" NUMBER(10,0),
	"NAZIV" VARCHAR2(30 BYTE),
	"ID_PISMA" NUMBER(10,0),
	"ID_IGRACKE" NUMBER(10,0),
	"SIFRA_POK" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table TIM
--------------------------------------------------------
CREATE TABLE "TIM"
(
	"ID" NUMBER(10,0),
	"ID_KOORD" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table JE_PAKOVAO
--------------------------------------------------------
CREATE TABLE "JE_PAKOVAO"
(
	"ID" NUMBER(10,0),
	"SIFRA_P" NUMBER(10,0),
	"ID_V" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table ISPORUCUJE
--------------------------------------------------------
CREATE TABLE "ISPORUCUJE"
(
	"ID" NUMBER(10,0),
	"SIFRA_T" NUMBER(10,0),
	"ID_IRV" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table ZNA
--------------------------------------------------------
CREATE TABLE "ZNA"
(
	"ID" NUMBER(10,0),
	"ID_PES" NUMBER(10,0),
	"ID_VIL" NUMBER(10,0)
);
--------------------------------------------------------
--  DDL for Table MAGICNA_VESTINA
--------------------------------------------------------
CREATE TABLE "MAGICNA_VESTINA"
(
	--"ID" NUMBER(10,0),
	"NAZIV" VARCHAR2(30 BYTE)
);
--------------------------------------------------------
--  DDL for Table ZAHTEVA
--------------------------------------------------------
CREATE TABLE "ZAHTEVA" 
(
	"ID" NUMBER(10,0),
	"RADIONICA_ID" NUMBER(10,0),
	"NAZIV_V" VARCHAR2(30 BYTE)
);
--------------------------------------------------------
--  DDL for Table POSEDUJE
--------------------------------------------------------
CREATE TABLE "POSEDUJE"
(
	"ID" NUMBER(10,0),
	"VILENJAK_ID" NUMBER(10,0),
	"NAZIV_VES" VARCHAR2(30 BYTE)
);

--------------------------------------------------------
--  DDL for Table IMA
--------------------------------------------------------
CREATE TABLE "IMA"
(
	"ID" NUMBER(10,0),
	"VIL_ID" NUMBER(10,0),
	"NAZIV_VESTINE" VARCHAR2(30 BYTE)
);




----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--  DDL for Index DETE_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "DETE_PK" ON "DETE" ("ID");
--------------------------------------------------------
--  DDL for Index PISMO_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "PISMO_PK" ON "PISMO" ("ID");
--------------------------------------------------------
--  DDL for Index TOVAR_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "TOVAR_PK" ON "TOVAR" ("SIFRA");
--------------------------------------------------------
--  DDL for Index POKLON_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "POKLON_PK" ON "POKLON" ("SIFRA");
--------------------------------------------------------
--  DDL for Index IRVAS_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "IRVAS_PK" ON "IRVAS" ("ID");
--------------------------------------------------------
--  DDL for Index PESMA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "PESMA_PK" ON "PESMA" ("ID");
--------------------------------------------------------
--  DDL for Index VILENJAK_IGRACKE_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "VILENJAK_IGRACKE_PK" ON "VILENJAK_IGRACKE" ("ID");
--------------------------------------------------------
--  DDL for Index VILENJAK_POKLONI_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "VILENJAK_POKLONI_PK" ON "VILENJAK_POKLONI" ("ID");
--------------------------------------------------------
--  DDL for Index VILENJAK_TOVAR_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "VILENJAK_TOVAR" ON "VILENJAK_TOVAR" ("ID");
--------------------------------------------------------
--  DDL for Index VILENJAK_IRVASI_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "VILENJAK_IRVASI_PK" ON "VILENJAK_IRVASI" ("ID");
--------------------------------------------------------
--  DDL for Index DEO_RADIONICE_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "DEO_RADIONICE_PK" ON "DEO_RADIONICE" ("ID");

CREATE UNIQUE INDEX "DEO_RADIONICE_SEF_ID" ON "DEO_RADIONICE" ("ID_SEFA");
--------------------------------------------------------
--  DDL for Index IGRACKA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "IGRACKA_PK" ON "IGRACKA" ("ID");
--------------------------------------------------------
--  DDL for Index ZELJA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "ZELJA_PK" ON "ZELJA" ("ID");
--------------------------------------------------------
--  DDL for Index TIM_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "TIM_PK" ON "TIM" ("ID");

CREATE UNIQUE INDEX "TIM_PK" ON "ID_KOORD" ("ID");
--------------------------------------------------------
--  DDL for Index JE_PAKOVAO_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "JE_PAKOVAO_PK" ON "JE_PAKOVAO" ("ID");
--------------------------------------------------------
--  DDL for Index ISPORUCUJE_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "ISPORUCUJE_PK" ON "ISPORUCUJE" ("ID");
--------------------------------------------------------
--  DDL for Index ZNA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "ZNA_PK" ON "ZNA" ("ID");
--------------------------------------------------------
--  DDL for Index MAGICNA_VESTINA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "MAGICNA_VESTINA_PK" ON "MAGICNA_VESTINA" ("NAZIV");
--------------------------------------------------------
--  DDL for Index ZAHTEVA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "ZAHTEVA_PK" ON "ZAHTEVA" ("ID");
--------------------------------------------------------
--  DDL for Index POSEDUJE_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "POSEDUJE_PK" ON "POSEDUJE" ("ID");

--------------------------------------------------------
--  DDL for Index IMA_PK
--------------------------------------------------------

CREATE UNIQUE INDEX "IMA_PK" ON "IMA" ("ID");
  
  
----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--  Constraints for Table DETE
--------------------------------------------------------
 
ALTER TABLE "DETE" ADD CONSTRAINT "DETE_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "DETE" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "DETE" MODIFY ("DRZAVA" NOT NULL ENABLE);

ALTER TABLE "DETE" MODIFY ("GRAD" NOT NULL ENABLE);

ALTER TABLE "DETE" MODIFY ("ADRESA" NOT NULL ENABLE);

ALTER TABLE "DETE" MODIFY ("IME" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table PISMO
--------------------------------------------------------

ALTER TABLE "PISMO" ADD CONSTRAINT "PISMO_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "PISMO" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "PISMO" MODIFY ("DATUM_SLANJA" NOT NULL ENABLE);

ALTER TABLE "PISMO" ADD CONSTRAINT "INDEKS_BOUNDS_CHK" CHECK (INDEKS_DOBROTE BETWEEN 1 AND 10) ENABLE;
--------------------------------------------------------
--  Constraints for Table TOVAR
--------------------------------------------------------

ALTER TABLE "TOVAR" ADD CONSTRAINT "TOVAR_PK" PRIMARY KEY ("SIFRA") ENABLE;
 
ALTER TABLE "TOVAR" MODIFY("SIFRA" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table POKLON
--------------------------------------------------------

ALTER TABLE "POKLON" ADD CONSTRAINT "POKLON_PK" PRIMARY KEY ("SIFRA") ENABLE;
 
ALTER TABLE "POKLON" MODIFY("SIFRA" NOT NULL ENABLE);
 
--------------------------------------------------------
--  Constraints for Table IRVAS
--------------------------------------------------------

ALTER TABLE "IRVAS" ADD CONSTRAINT "IRVAS_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "IRVAS" MODIFY("ID" NOT NULL ENABLE);

ALTER TABLE "IRVAS" ADD CONSTRAINT "IRVAS_POL_CHK" CHECK (POL IN ('M', 'Z')) ENABLE;

--------------------------------------------------------
--  Constraints for Table PESMA
--------------------------------------------------------

ALTER TABLE "PESMA" ADD CONSTRAINT "PESMA_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "PESMA" MODIFY("ID" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table VILENJAK_IGRACKE
--------------------------------------------------------

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "VILENJAK_IGRACKE" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "VILENJAK_IGRACKE" MODIFY ("IME" NOT NULL ENABLE);

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_SEF_CHK" CHECK (SEF IN ('Da', 'Ne')) ENABLE;

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_MENTOR_CHK" CHECK (MENTOR IN ('Da', 'Ne')) ENABLE;

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_KOORD_CHK" CHECK (KOORDINATOR IN ('Da', 'Ne')) ENABLE;

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "OCENA_BOUNDS_CHK" CHECK (OCENA BETWEEN 1 AND 10) ENABLE;

--------------------------------------------------------
--  Constraints for Table VILENJAK_POKLONI
--------------------------------------------------------

ALTER TABLE "VILENJAK_POKLONI" ADD CONSTRAINT "VILENJAK_POKLONI_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "VILENJAK_POKLONI" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "VILENJAK_POKLONI" MODIFY ("IME" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table VILENJAK_TOVAR
--------------------------------------------------------

ALTER TABLE "VILENJAK_TOVAR" ADD CONSTRAINT "VILENJAK_TOVAR_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "VILENJAK_TOVAR" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "VILENJAK_TOVAR" MODIFY ("IME" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table VILENJAK_IRVASI
--------------------------------------------------------

ALTER TABLE "VILENJAK_IRVASI" ADD CONSTRAINT "VILENJAK_IRVASI_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "VILENJAK_IRVASI" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "VILENJAK_IRVASI" MODIFY ("IME" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table DEO_RADIONICE
--------------------------------------------------------

ALTER TABLE "DEO_RADIONICE" ADD CONSTRAINT "DEO_RADIONICE_PK" PRIMARY KEY ("ID") ENABLE;
 
ALTER TABLE "DEO_RADIONICE" MODIFY("ID" NOT NULL ENABLE);



--ALTER TABLE "DEO_RADIONICE" MODIFY("ID_SEFA" NOT NULL ENABLE);--mozda ovo

--------------------------------------------------------
--  Constraints for Table IGRACKA
--------------------------------------------------------

ALTER TABLE "IGRACKA" ADD CONSTRAINT "IGRACKA_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "IGRACKA" MODIFY ("ID" NOT NULL ENABLE);

--ALTER TABLE "IGRACKA" MODIFY ("ID_VILENJAK" NOT NULL ENABLE);--mozda ovo

--------------------------------------------------------
--  Constraints for Table ZELJA
--------------------------------------------------------

ALTER TABLE "ZELJA" ADD CONSTRAINT "ZELJA_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "ZELJA" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "ZELJA" MODIFY("NAZIV" NOT NULL ENABLE);
 
ALTER TABLE "ZELJA" MODIFY("ID_PISMA" NOT NULL ENABLE);

--ALTER TABLE "ZELJA" MODIFY("ID_IGRACKE" NOT NULL ENABLE);
  
--------------------------------------------------------
--  Constraints for Table TIM
--------------------------------------------------------

ALTER TABLE "TIM" ADD CONSTRAINT "TIM_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "TIM" MODIFY("ID" NOT NULL ENABLE);

--ALTER TABLE "TIM" MODIFY("ID_KOORD" NOT NULL ENABLE);--mozda ovo

--------------------------------------------------------
--  Constraints for Table JE_PAKOVAO 
--------------------------------------------------------

ALTER TABLE "JE_PAKOVAO" ADD CONSTRAINT "JE_PAKOVAO_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "JE_PAKOVAO" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "JE_PAKOVAO" MODIFY("ID_V" NOT NULL ENABLE);

ALTER TABLE "JE_PAKOVAO" MODIFY("SIFRA_P" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table ISPORUCUJE
--------------------------------------------------------

ALTER TABLE "ISPORUCUJE" ADD CONSTRAINT "ISPORUCUJE_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "ISPORUCUJE" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "ISPORUCUJE" MODIFY("SIFRA_T" NOT NULL ENABLE);

ALTER TABLE "ISPORUCUJE" MODIFY("ID_IRV" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table ZNA
--------------------------------------------------------

ALTER TABLE "ZNA" ADD CONSTRAINT "ZNA_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "ZNA" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "ZNA" MODIFY("ID_PES" NOT NULL ENABLE);

ALTER TABLE "ZNA" MODIFY("ID_VIL" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table MAGICNA_VESTINA
--------------------------------------------------------

ALTER TABLE "MAGICNA_VESTINA" ADD CONSTRAINT "MAGICNA_VESTINA_PK" PRIMARY KEY ("NAZIV") ENABLE;

--ALTER TABLE "MAGICNA_VESTINA" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "MAGICNA_VESTINA" MODIFY ("NAZIV" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table ZAHTEVA
--------------------------------------------------------

ALTER TABLE "ZAHTEVA" ADD CONSTRAINT "ZAHTEVA_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "ZAHTEVA" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "ZAHTEVA" MODIFY("RADIONICA_ID" NOT NULL ENABLE);

ALTER TABLE "ZAHTEVA" MODIFY("NAZIV_V" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table POSEDUJE
--------------------------------------------------------

ALTER TABLE "POSEDUJE" ADD CONSTRAINT "POSEDUJE_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "POSEDUJE" MODIFY ("ID" NOT NULL ENABLE);
 
ALTER TABLE "POSEDUJE" MODIFY ("VILENJAK_ID" NOT NULL ENABLE);

ALTER TABLE "POSEDUJE" MODIFY ("NAZIV_VES" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table IMA
--------------------------------------------------------

ALTER TABLE "IMA" ADD CONSTRAINT "IMA_PK" PRIMARY KEY ("ID") ENABLE;

ALTER TABLE "IMA" MODIFY ("ID" NOT NULL ENABLE);

ALTER TABLE "IMA" MODIFY ("VIL_ID" NOT NULL ENABLE);

ALTER TABLE "IMA" MODIFY ("NAZIV_VESTINE" NOT NULL ENABLE);


----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--  Ref Constraints for Table PISMO
--------------------------------------------------------

ALTER TABLE "PISMO" ADD CONSTRAINT "PISMO_FK" FOREIGN KEY ("ID_DETE")
	REFERENCES "DETE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table POKLON
--------------------------------------------------------

ALTER TABLE "POKLON" ADD CONSTRAINT "POKLON_FK" FOREIGN KEY ("SIFRA_TOV")
	REFERENCES "TOVAR" ("SIFRA") ENABLE;	
--------------------------------------------------------
--  Ref Constraints for Table VILENJAK_IGRACKE
--------------------------------------------------------

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_TIM_FK" FOREIGN KEY ("ID_TIM")
	REFERENCES "TIM" ("ID") ENABLE;

ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_MENTOR_FK" FOREIGN KEY ("ID_MENT")
	REFERENCES "VILENJAK_IGRACKE" ("ID") ENABLE;
	  
ALTER TABLE "VILENJAK_IGRACKE" ADD CONSTRAINT "VILENJAK_IGRACKE_DEO_FK" FOREIGN KEY ("ID_RAD")
	REFERENCES "DEO_RADIONICE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table VILENJAK_TOVAR
--------------------------------------------------------

ALTER TABLE "VILENJAK_TOVAR" ADD CONSTRAINT "VILENJAK_TOVAR_FK" FOREIGN KEY ("TOVAR_SIFRA")
	REFERENCES "TOVAR" ("SIFRA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table VILENJAK_IRVASI
--------------------------------------------------------

ALTER TABLE "VILENJAK_IRVASI" ADD CONSTRAINT "VILENJAK_IRVASI_FK" FOREIGN KEY ("ID_IRVAS")
	REFERENCES "IRVAS" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DEO_RADIONICE
--------------------------------------------------------

ALTER TABLE "DEO_RADIONICE" ADD CONSTRAINT "DEO_RADIONICE_FK" FOREIGN KEY ("ID_SEFA")
	REFERENCES "VILENJAK_IGRACKE" ("ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table IGRACKA
--------------------------------------------------------

ALTER TABLE "IGRACKA" ADD CONSTRAINT "IGRACKA_POKLON_FK" FOREIGN KEY ("SIFRA_POKLONA")
	REFERENCES "POKLON" ("SIFRA") ENABLE;
	  
ALTER TABLE "IGRACKA" ADD CONSTRAINT "IGRACKA_VILENJAK_FK" FOREIGN KEY ("ID_VILENJAK")
	REFERENCES "VILENJAK_IGRACKE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ZELJA
--------------------------------------------------------

ALTER TABLE "ZELJA" ADD CONSTRAINT "ZELJA_PISMO_FK" FOREIGN KEY ("ID_PISMA")
	REFERENCES "PISMO" ("ID") ENABLE;
	 
ALTER TABLE "ZELJA" ADD CONSTRAINT "ZELJA_IGRACKA_FK" FOREIGN KEY ("ID_IGRACKE")
	REFERENCES "IGRACKA" ("ID") ENABLE;
	  
ALTER TABLE "ZELJA" ADD CONSTRAINT "ZELJA_POKLON_FK" FOREIGN KEY ("SIFRA_POK")
	REFERENCES "POKLON" ("SIFRA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for TIM
--------------------------------------------------------

ALTER TABLE "TIM" ADD CONSTRAINT "TIM_FK" FOREIGN KEY ("ID_KOORD")
	REFERENCES "VILENJAK_IGRACKE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table JE_PAKOVAO
--------------------------------------------------------

ALTER TABLE "JE_PAKOVAO" ADD CONSTRAINT "JE_PAKOVAO_POKLON_FK" FOREIGN KEY ("SIFRA_P")
	REFERENCES "POKLON" ("SIFRA") ENABLE;
	  
ALTER TABLE "JE_PAKOVAO" ADD CONSTRAINT "JE_PAKOVAO_VILENJAK_FK" FOREIGN KEY ("ID_V")
	REFERENCES "VILENJAK_POKLONI" ("ID") ENABLE;  
--------------------------------------------------------
--  Ref Constraints for Table ISPORUCUJE 
--------------------------------------------------------

ALTER TABLE "ISPORUCUJE" ADD CONSTRAINT "ISPORUCUJE_TOVAR_FK" FOREIGN KEY ("SIFRA_T")
	REFERENCES "TOVAR" ("SIFRA") ENABLE;
	  
ALTER TABLE "ISPORUCUJE" ADD CONSTRAINT "ISPORUCUJE_IRVAS_FK" FOREIGN KEY ("ID_IRV")
	REFERENCES "IRVAS" ("ID") ENABLE;	  
--------------------------------------------------------
--  Ref Constraints for Table ZNA
--------------------------------------------------------

ALTER TABLE "ZNA" ADD CONSTRAINT "ZNA_VILENJAK_FK" FOREIGN KEY ("ID_VIL")
	REFERENCES "VILENJAK_IRVASI" ("ID") ENABLE;
	  
ALTER TABLE "ZNA" ADD CONSTRAINT "ZNA_PESMA_FK" FOREIGN KEY ("ID_PES")
	REFERENCES "PESMA" ("ID") ENABLE;	
--------------------------------------------------------
--  Ref Constraints for Table ZAHTEVA
-------------------------------------------------------- 

ALTER TABLE "ZAHTEVA" ADD CONSTRAINT "ZAHTEVA_DEO_FK" FOREIGN KEY ("RADIONICA_ID")
	REFERENCES "DEO_RADIONICE" ("ID") ENABLE;
	  
ALTER TABLE "ZAHTEVA" ADD CONSTRAINT "ZAHTEVA_VESTINA_FK" FOREIGN KEY ("NAZIV_V")
	REFERENCES "MAGICNA_VESTINA" ("NAZIV") ENABLE;	  
--------------------------------------------------------
--  Ref Constraints for Table POSEDUJE
-------------------------------------------------------- 

ALTER TABLE "POSEDUJE" ADD CONSTRAINT "POSEDUJE_VILENJAK_FK" FOREIGN KEY ("VILENJAK_ID")
	REFERENCES "VILENJAK_IGRACKE" ("ID") ENABLE;

ALTER TABLE "POSEDUJE" ADD CONSTRAINT "POSEDUJE_VESTINA_FK" FOREIGN KEY ("NAZIV_VES")
    REFERENCES "MAGICNA_VESTINA" ("NAZIV") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table IMA
-------------------------------------------------------- 

ALTER TABLE "IMA" ADD CONSTRAINT "IMA_VILENJAK_FK" FOREIGN KEY ("VIL_ID")
	REFERENCES "VILENJAK_IRVASI" ("ID") ENABLE;

ALTER TABLE "IMA" ADD CONSTRAINT "IMA_VESTINA_FK" FOREIGN KEY ("NAZIV_VESTINE")
    REFERENCES "MAGICNA_VESTINA" ("NAZIV") ENABLE;


---------------------------------------------------------------------------------------------------------------- 


--------------------------------------------------------
--  DDL for Trigger DETE_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "DETE_AUTO_PK" 
    BEFORE INSERT
    ON DETE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT DETE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "DETE_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger PISMO_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PISMO_AUTO_PK" 
    BEFORE INSERT
    ON PISMO
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT PISMO_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "PISMO_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TOVAR_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TOVAR_AUTO_PK" 
    BEFORE INSERT
    ON TOVAR
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT TOVAR_SIFRA_SEQ.NEXTVAL INTO :NEW.SIFRA FROM DUAL;
END;
/
ALTER TRIGGER "TOVAR_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger POKLON_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "POKLON_AUTO_PK" 
    BEFORE INSERT
    ON POKLON
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT POKLON_SEQ.NEXTVAL INTO :NEW.SIFRA FROM DUAL;
END;
/
ALTER TRIGGER "POKLON_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger IRVAS_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "IRVAS_AUTO_PK" 
    BEFORE INSERT
    ON IRVAS
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT IRVAS_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "IRVAS_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger PESMA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PESMA_AUTO_PK" 
    BEFORE INSERT
    ON PESMA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT PESMA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "PESMA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VILENJAK_I_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "VILENJAK_I_AUTO_PK" 
    BEFORE INSERT
    ON VILENJAK_IGRACKE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT VILENJAK_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "VILENJAK_I_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VILENJAK_P_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "VILENJAK_P_AUTO_PK" 
    BEFORE INSERT
    ON VILENJAK_POKLONI
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT VILENJAK_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "VILENJAK_P_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VILENJAK_T_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "VILENJAK_T_AUTO_PK" 
    BEFORE INSERT
    ON VILENJAK_TOVAR
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT VILENJAK_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "VILENJAK_T_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VILENJAK_IRV_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "VILENJAK_IRV_AUTO_PK" 
    BEFORE INSERT
    ON VILENJAK_IRVASI
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT VILENJAK_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "VILENJAK_IRV_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger DEO_RADIONICE_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "DEO_RADIONICE_AUTO_PK" 
    BEFORE INSERT
    ON DEO_RADIONICE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT DEO_RADIONICE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "DEO_RADIONICE_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger IGRACKA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "IGRACKA_AUTO_PK" 
    BEFORE INSERT
    ON IGRACKA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT IGRACKA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "IGRACKA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TIM_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TIM_AUTO_PK" 
    BEFORE INSERT
    ON TIM
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT TIM_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "TIM_AUTO_PK" ENABLE;


----------------------------------------------------------------------------------------------------------------
--NOVI TRIGERI
----------------------------------------------------------------------------------------------------------------
--------------------------------------------------------
--  DDL for Trigger JE_PAKOVAO_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "JE_PAKOVAO_AUTO_PK" 
    BEFORE INSERT
    ON JE_PAKOVAO
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT JE_PAKOVAO_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "JE_PAKOVAO_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger ISPORUCUJE_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "ISPORUCUJE_AUTO_PK" 
    BEFORE INSERT
    ON ISPORUCUJE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ISPORUCUJE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "ISPORUCUJE_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger ZNA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "ZNA_AUTO_PK" 
    BEFORE INSERT
    ON ZNA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ZNA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "ZNA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger IMA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "IMA_AUTO_PK" 
    BEFORE INSERT
    ON IMA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT IMA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "IMA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger POSEDUJE_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "POSEDUJE_AUTO_PK" 
    BEFORE INSERT
    ON POSEDUJE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT POSEDUJE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "POSEDUJE_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger ZAHTEVA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "ZAHTEVA_AUTO_PK" 
    BEFORE INSERT
    ON ZAHTEVA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ZAHTEVA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "ZAHTEVA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger ZELJA_AUTO_PK
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "ZELJA_AUTO_PK" 
    BEFORE INSERT
    ON ZELJA
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ZELJA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
ALTER TRIGGER "ZELJA_AUTO_PK" ENABLE;
--------------------------------------------------------
--  DDL for Trigger MAGICNA_VESTINA_AUTO_PK
--------------------------------------------------------

--  CREATE OR REPLACE TRIGGER "MAGICNA_VESTINA_AUTO_PK" 
--    BEFORE INSERT
--    ON MAGICNA_VESTINA
--    REFERENCING NEW AS NEW
--    FOR EACH ROW
--BEGIN
--    SELECT MAGICNA_VESTINA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
--END;
--/
--ALTER TRIGGER "MAGICNA_VESTINA_AUTO_PK" ENABLE;





----------------------------------------------------------------------------------------------------------------
--INSERTIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
----------------------------------------------------------------------------------------------------------------


--------------------------------------------------------
--  INSERT naredbe za DETE 
--------------------------------------------------------

Insert into DETE (ID,IME,PREZIME,DATUM_RODJENJA,DRZAVA,GRAD,ADRESA,IME_MAJKE,IME_OCA) values ('1','Anita','Aleksic', to_date('17.11.2001','DD.MM.RRRR'),'Srbija','Nis','Betovenova 15','Ivana','Zoran');

Insert into DETE (ID,IME,PREZIME,DATUM_RODJENJA,DRZAVA,GRAD,ADRESA,IME_MAJKE,IME_OCA) values ('2','Uros','Miladinovic', to_date('30.06.2001','DD.MM.RRRR'),'Srbija','Prokuplje','Carice Milice 18','Marija','Boban');

Insert into DETE (ID,IME,PREZIME,DATUM_RODJENJA,DRZAVA,GRAD,ADRESA,IME_MAJKE,IME_OCA) values ('3','Aimee','Allaire', to_date('16.01.2010','DD.MM.RRRR'),'Francuska','Pariz',' 37 rue Marguerite','Charlotte','Charles');

Insert into DETE (ID,IME,PREZIME,DATUM_RODJENJA,DRZAVA,GRAD,ADRESA,IME_MAJKE,IME_OCA) values ('4','Andjelija','Mijajlovic', to_date('11.12.2001','DD.MM.RRRR'),'Srbija','Kursumlija','Drinke Pavlovic 22','Snezana','Dragoje');

--------------------------------------------------------
--  INSERT naredbe za PISMO 
--------------------------------------------------------

Insert into PISMO(ID,DATUM_SLANJA,DATUM_PRIJEMA,INDEKS_DOBROTE,TEKST,ID_DETE) values( '1',to_date('17.12.2021','DD.MM.RRRR'),to_date('25.12.2022','DD.MM.RRRR'),'7.9','Dragi Deda Mraze, zelim slagalicu od puno delova za sebe i autic za svog brata.','1');

Insert into PISMO(ID,DATUM_SLANJA,DATUM_PRIJEMA,INDEKS_DOBROTE,TEKST,ID_DETE) values ('2',to_date('14.12.2022','DD.MM.RRRR'),to_date('20.12.2022','DD.MM.RRRR'),'6.6','Dragi Deda Mraze, mama je rekla da ti posaljem spisak zelja. Zelim auto na daljinski i helikopter.', '2');

Insert into PISMO(ID,DATUM_SLANJA,DATUM_PRIJEMA,INDEKS_DOBROTE,TEKST,ID_DETE) values( '3',to_date('22.12.2020','DD.MM.RRRR'),to_date('28.12.2020','DD.MM.RRRR'),'8.1','Dragi Deda Mraze, zelela bih da te zamolim za mog malog ponija i figuricu Iron Man-a.','3');

Insert into PISMO(ID,DATUM_SLANJA,DATUM_PRIJEMA,INDEKS_DOBROTE,TEKST,ID_DETE) values( '4',to_date('08.12.2019','DD.MM.RRRR'),to_date('18.12.2019','DD.MM.RRRR'),'8.4','Dragi Deda Mraze, volela bih da dobijem plisanu lutku.','4');

--------------------------------------------------------
--  INSERT naredbe za TOVAR 
--------------------------------------------------------

Insert into TOVAR(SIFRA,GRAD) values ('1','Nis');

Insert into TOVAR(SIFRA,GRAD) values ('2','Prokuplje');

Insert into TOVAR(SIFRA,GRAD) values ('3','Pariz');

Insert into TOVAR(SIFRA,GRAD) values ('4','Kursumlija');

Insert into TOVAR(SIFRA,GRAD) values ('5','Rim');

Insert into TOVAR(SIFRA,GRAD) values ('6','London');

--------------------------------------------------------
--  INSERT naredbe za POKLON 
--------------------------------------------------------

Insert into POKLON(SIFRA,BOJA,POSVETA,SIFRA_TOV) values ('1','Roze','Aniti','1');

Insert into POKLON(SIFRA,BOJA,POSVETA,SIFRA_TOV) values ('2','Plava','Urosu','2');

Insert into POKLON(SIFRA,BOJA,POSVETA,SIFRA_TOV) values ('3','Zuta','Aimee','3');

Insert into POKLON(SIFRA,BOJA,POSVETA,SIFRA_TOV) values ('4','Ljubicasta','Andjeliju','4');

--------------------------------------------------------
--  INSERT naredbe za IRVAS 
--------------------------------------------------------

Insert into IRVAS(ID,IME,NADIMAK,POL,DATUM_RODJENJA) values ('1','Rudolf','Ruki','M',to_date('22.08.2017','DD.MM.RRRR'));

Insert into IRVAS(ID,IME,NADIMAK,POL,DATUM_RODJENJA) values ('2','Vixen','Vixy','M',to_date('04.02.2016','DD.MM.RRRR'));

Insert into IRVAS(ID,IME,NADIMAK,POL,DATUM_RODJENJA) values ('3','Dasher','Dash','Z',to_date('30.05.2018','DD.MM.RRRR'));

Insert into IRVAS(ID,IME,NADIMAK,POL,DATUM_RODJENJA) values ('4','Miki','Bency','M',to_date('17.05.2001','DD.MM.RRRR'));

--------------------------------------------------------
--  INSERT naredbe za PESMA 
--------------------------------------------------------

Insert into PESMA(ID,NAZIV,TEKST) values ('1','Zvoncici', 'Zvončići zvončići zvonite kroz noć, večeras će Deda Mraz kroz svaku kuću proć hej.');

Insert into PESMA(ID,NAZIV,TEKST) values ('2','Preko brda, preko brega', 'Preko brda preko brega i debelog snega jure neke čudne sanke srebrne i tanke.');

Insert into PESMA(ID,NAZIV,TEKST) values ('3','Nova godina kuca na vratima', 'Ovo je vreme praznika i snežnih belih pahulja.');

--------------------------------------------------------
--  INSERT naredbe za VILENJAK_IGRACKE 
--------------------------------------------------------

Insert into VILENJAK_IGRACKE(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,OCENA,TRAJANJE_OBUKE,SPECIJALIZOVAN_ZA,SEF,MENTOR,KOORDINATOR,ID_TIM,ID_MENT,ID_RAD) values ('1', 'Petar', 'Kina', '5 godina', '9','6 meseci','Plastika','Da','Ne','Ne', null, null, null);

Insert into VILENJAK_IGRACKE(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,OCENA,TRAJANJE_OBUKE,SPECIJALIZOVAN_ZA,SEF,MENTOR,KOORDINATOR,ID_TIM,ID_MENT,ID_RAD) values ('2','Milos','Indija','6 godina', '8', '5 meseci','Metal','Ne','Ne','Ne',null,null,null);

Insert into VILENJAK_IGRACKE(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,OCENA,TRAJANJE_OBUKE,SPECIJALIZOVAN_ZA,SEF,MENTOR,KOORDINATOR,ID_TIM,ID_MENT,ID_RAD) values ('3','Uros','Svajcarska','7 godina','7','11 meseci','Drvo', 'Ne','Da', 'Ne', null, null, null);

Insert into VILENJAK_IGRACKE(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,OCENA,TRAJANJE_OBUKE,SPECIJALIZOVAN_ZA,SEF,MENTOR,KOORDINATOR,ID_TIM,ID_MENT,ID_RAD) values ('4','Veki','Srbija','9 godina','9.7','9 meseci','Vuna', 'Ne','Da', 'Da', null, null, null);

--------------------------------------------------------
--  INSERT naredbe za VILENJAK_POKLONI 
--------------------------------------------------------

Insert into VILENJAK_POKLONI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ) values ('5','Arven','Kina', '3 godine');

Insert into VILENJAK_POKLONI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ) values ('6','Elrond','Rusija', '2 godine');

Insert into VILENJAK_POKLONI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ) values ('7','Legolas','Norveska', '5 godina');

--------------------------------------------------------
--  INSERT naredbe za VILENJAK_TOVAR 
--------------------------------------------------------

Insert into VILENJAK_TOVAR(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,TOVAR_SIFRA) values ('8','Idril','Indija', '4 godine','1');

Insert into VILENJAK_TOVAR(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,TOVAR_SIFRA) values ('9','Fingolfin','Francuska', '7 godina','2');

Insert into VILENJAK_TOVAR(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,TOVAR_SIFRA) values ('10','Maglor','Hrvatska', '6 godina','3');

--------------------------------------------------------
--  INSERT naredbe za VILENJAK_IRVASI 
--------------------------------------------------------

Insert into VILENJAK_IRVASI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,ID_IRVAS) values ('11','Nerdanel','Svedska', '7 godina','1');

Insert into VILENJAK_IRVASI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,ID_IRVAS) values ('12','Carantir','Kina', '6 godina','2');

Insert into VILENJAK_IRVASI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,ID_IRVAS) values ('13','Elemir','Japan', '2 godine','3');

Insert into VILENJAK_IRVASI(ID,IME,ZEMLJA_POREKLA,RADNI_STAZ,ID_IRVAS) values ('14','Dzoni','Srbija', '3 godine','4');

--------------------------------------------------------
--  INSERT naredbe za DEO_RADIONICE 
--------------------------------------------------------

Insert into DEO_RADIONICE(ID,NAZIV,BROJ_VILENJAKA,TIP_IGRACAKA,ID_SEFA,DATUM_POSTAVLJANJA) values ('1', 'DEO ZA VOZILA','1', 'Vozila','1',to_date('30.05.2018','DD.MM.RRRR'));

Insert into DEO_RADIONICE(ID,NAZIV,BROJ_VILENJAKA,TIP_IGRACAKA,ID_SEFA,DATUM_POSTAVLJANJA) values ('2', 'DEO ZA LUTKE','1', 'Lutke','4',to_date('05.11.2017','DD.MM.RRRR'));

Insert into DEO_RADIONICE(ID,NAZIV,BROJ_VILENJAKA,TIP_IGRACAKA,ID_SEFA,DATUM_POSTAVLJANJA) values ('3', 'DEO ZA FIGURE','1', 'Figure','2',to_date('15.03.2018','DD.MM.RRRR'));

Insert into DEO_RADIONICE(ID,NAZIV,BROJ_VILENJAKA,TIP_IGRACAKA,ID_SEFA,DATUM_POSTAVLJANJA) values ('4', 'DEO ZA SLAGALICE','1', 'Slagalice','3',to_date('15.03.2018','DD.MM.RRRR'));

--------------------------------------------------------
--  INSERT naredbe za IGRACKA 
--------------------------------------------------------

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('1','1','SLAGALICE', 'Puzle od 1000 delova','3','1');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('2','2','VOZILA', 'Autic','1','1');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('3','1','VOZILA', 'Auto na daljinski za decake','1','2');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('4','2','VOZILA', 'Plasticni helikopter za decake','1','2');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('5','1','FIGURE', 'Moj mali poni figura','2','3');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('6','2','FIGURE', 'Iron man figura za decake','2','3');

Insert into IGRACKA(ID,REDNI_BROJ,TIP,OPIS,ID_VILENJAK,SIFRA_POKLONA) values ('7','1','LUTKE', 'Plisana lutka Pipi Duga Carapa','4','4');

--------------------------------------------------------
--  INSERT naredbe za ZELJA 
--------------------------------------------------------

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Slagalica', '1', '1', '1');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Autic', '1', '2', '1');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Auto na daljinski', '2', '3', '2');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Helikopter', '2', '4', '2');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Moj mali poni', '3', '5', '3');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Iron man figura', '3', '6', '3');

Insert into ZELJA(NAZIV,ID_PISMA,ID_IGRACKE,SIFRA_POK) values ('Lutka', '4', '7', '4');

--------------------------------------------------------
--  INSERT naredbe za TIM
--------------------------------------------------------

Insert into TIM(ID,ID_KOORD) VALUES ('1', '1');

Insert into TIM(ID,ID_KOORD) VALUES ('2', '2');

Insert into TIM(ID,ID_KOORD) VALUES ('3', '3');

Insert into TIM(ID,ID_KOORD) VALUES ('4', '4');

--------------------------------------------------------
--  INSERT naredbe za JE_PAKOVAO 
--------------------------------------------------------

Insert into JE_PAKOVAO(SIFRA_P, ID_V) values ('1','7');

Insert into JE_PAKOVAO(SIFRA_P, ID_V) values ('2','5');

Insert into JE_PAKOVAO(SIFRA_P, ID_V) values ('3','6');

Insert into JE_PAKOVAO(SIFRA_P, ID_V) values ('4','6');

--------------------------------------------------------
--  INSERT naredbe za ISPORUCUJE 
--------------------------------------------------------

Insert into ISPORUCUJE(SIFRA_T, ID_IRV) values ('1','1');

Insert into ISPORUCUJE(SIFRA_T, ID_IRV) values ('2','2');

Insert into ISPORUCUJE(SIFRA_T, ID_IRV) values ('3','3');

--------------------------------------------------------
--  INSERT naredbe za ZNA 
--------------------------------------------------------

Insert into ZNA(ID_PES, ID_VIL) values ('1', '11');

Insert into ZNA(ID_PES, ID_VIL) values ('2', '12');

Insert into ZNA(ID_PES, ID_VIL) values ('3', '13');

Insert into ZNA(ID_PES, ID_VIL) values ('1', '14');

--------------------------------------------------------
--  INSERT naredbe za MAGICNA_VESTINA 
--------------------------------------------------------

Insert into MAGICNA_VESTINA(NAZIV) values ('Milovanje');

Insert into MAGICNA_VESTINA(NAZIV) values ('Zvizdanje');

Insert into MAGICNA_VESTINA(NAZIV) values ('Saputanje');

Insert into MAGICNA_VESTINA(NAZIV) values ('Stepovanje');

Insert into MAGICNA_VESTINA(NAZIV) values ('Pravljenje kose');

Insert into MAGICNA_VESTINA(NAZIV) values ('Okretanje tockova');

Insert into MAGICNA_VESTINA(NAZIV) values ('Ubacivanje glasa');

Insert into MAGICNA_VESTINA(NAZIV) values ('Obrada drveta');

Insert into MAGICNA_VESTINA(NAZIV) values ('Obrada metala');

Insert into MAGICNA_VESTINA(NAZIV) values ('Obrada plastike');

--------------------------------------------------------
--  INSERT naredbe za ZAHTEVA 
--------------------------------------------------------

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('1', 'Okretanje tockova');

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('2', 'Pravljenje kose');

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('4', 'Obrada drveta');

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('2', 'Obrada drveta');

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('3', 'Obrada metala');

Insert into ZAHTEVA(RADIONICA_ID,NAZIV_V) values ('1', 'Obrada plastike');

--------------------------------------------------------
--  INSERT naredbe za POSEDUJE 
--------------------------------------------------------

Insert into POSEDUJE(VILENJAK_ID,NAZIV_VES) values ('4', 'Pravljenje kose');

Insert into POSEDUJE(VILENJAK_ID,NAZIV_VES) values ('1', 'Okretanje tockova');

Insert into POSEDUJE(VILENJAK_ID,NAZIV_VES) values ('2', 'Obrada metala');

Insert into POSEDUJE(VILENJAK_ID,NAZIV_VES) values ('3', 'Obrada drveta');

--------------------------------------------------------
--  INSERT naredbe za IMA 
--------------------------------------------------------

Insert into IMA(VIL_ID,NAZIV_VESTINE) values ('11', 'Milovanje');

Insert into IMA(VIL_ID,NAZIV_VESTINE) values ('12', 'Zvizdanje');

Insert into IMA(VIL_ID,NAZIV_VESTINE) values ('13','Saputanje');

Insert into IMA(VIL_ID,NAZIV_VESTINE) values ('14','Stepovanje');





---------------------------------------------------
--UPDATE 
---------------------------------------------------
UPDATE VILENJAK_IGRACKE SET SEF = 'Da' WHERE ID IN ('1', '2', '3', '4');
 
--UPDATE VILENJAK_IGRACKE SET ID_MENT = '1' WHERE ID IN ('6'); 
UPDATE VILENJAK_IGRACKE SET ID_MENT = '2' WHERE ID IN ('1'); 
UPDATE VILENJAK_IGRACKE SET ID_MENT = '3' WHERE ID IN ('2'); 
UPDATE VILENJAK_IGRACKE SET ID_MENT = '4' WHERE ID IN ('3'); 
UPDATE VILENJAK_IGRACKE SET ID_MENT = '2' WHERE ID IN ('4'); 


UPDATE VILENJAK_IGRACKE SET ID_TIM = '4' WHERE ID IN ('4'); 
UPDATE VILENJAK_IGRACKE SET ID_TIM = '1' WHERE ID IN ('1'); 
UPDATE VILENJAK_IGRACKE SET ID_TIM = '2' WHERE ID IN ('2'); 
UPDATE VILENJAK_IGRACKE SET ID_TIM = '3' WHERE ID IN ('3'); 
--UPDATE VILENJAK_IGRACKE SET ID_TIM = '1' WHERE ID IN ('6'); 

--UPDATE VILENJAK_IGRACKE SET ID_RAD = '7' WHERE ID IN ('6'); 
UPDATE VILENJAK_IGRACKE SET ID_RAD = '1' WHERE ID IN ('1'); 
UPDATE VILENJAK_IGRACKE SET ID_RAD = '3' WHERE ID IN ('2'); 
UPDATE VILENJAK_IGRACKE SET ID_RAD = '4' WHERE ID IN ('3'); 
UPDATE VILENJAK_IGRACKE SET ID_RAD = '2' WHERE ID IN ('4'); 
