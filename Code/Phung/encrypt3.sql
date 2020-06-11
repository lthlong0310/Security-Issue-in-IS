CREATE OR REPLACE EDITIONABLE PACKAGE NV_ENCRYPT IS
  FUNCTION ENCRYPT_(inputData IN VARCHAR2) RETURN RAW DETERMINISTIC;
  FUNCTION DECRYPT_(inputEncryptData IN RAW) RETURN VARCHAR2 DETERMINISTIC;
END;
/
  CREATE OR REPLACE EDITIONABLE PACKAGE BODY NV_ENCRYPT IS 
    encrypt_Type PLS_INTEGER :=DBMS_CRYPTO.ENCRYPT_DES
							+DBMS_CRYPTO.CHAIN_CBC
							+DBMS_CRYPTO.PAD_PKCS5;
    Mykey VARCHAR2(100) := 'AHIHIHIHI';
  FUNCTION ENCRYPT_(inputData IN VARCHAR2) RETURN RAW DETERMINISTIC
  IS
  	encrypted_raw raw(1000);
    
  BEGIN
       encrypted_raw := dbms_crypto.encrypt(
          src => utl_raw.cast_to_raw(inputData),
          typ => encrypt_Type,
          key => utl_raw.cast_to_raw(Mykey)
      );
      return encrypted_raw;
  END ENCRYPT_;

  FUNCTION DECRYPT_(inputEncryptData IN RAW) RETURN VARCHAR2 DETERMINISTIC
  IS
    decrypted_raw raw(1000);
  BEGIN
       decrypted_raw := dbms_crypto.decrypt(
          src => inputEncryptData,
          typ => encrypt_Type,
          key => utl_raw.cast_to_raw(Mykey)
      );
      return  utl_raw.cast_to_VARCHAR2(decrypted_raw);
  END DECRYPT_;

END NV_Encrypt;
/


--testing
BEGIN 
    FOR STT IN(SELECT COUNT(MSSV)FROM SINHVIEN)
    LOOP
        UPDATE SINHVIEN SET HOTENSINHVIEN = NV_ENCRYPT.ENCRYPT_(HOTENSINHVIEN);
    END LOOP;
END;
--TEST DATA ENCRYPTED
SELECT * FROM SINHVIEN;

SELECT MSSV, NV_ENCRYPT.DECRYPT_(HOTENSINHVIEN), DTB FROM SINHVIEN;

DROP TABLE SINHVIEN;
/
CREATE TABLE SINHVIEN(
    MSSV NUMBER(*,0),
    HOTENSINHVIEN VARCHAR2(100),
    DTB NUMBER(*,0)
);
/
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(1, 'NGUYEN A', 10);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(2, 'NGUYEN B', 9);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(3, 'NGUYEN C', 8);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(4, 'NGUYEN D', 7);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(5, 'NGUYEN E', 6);
/