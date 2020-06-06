CREATE TABLE SINHVIEN(
    MSSV NUMBER,
    HOTENSINHVIEN VARCHAR2(100),
    DTB NUMBER
);
/
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(1, 'NGUYEN A', 10);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(2, 'NGUYEN B', 9);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(3, 'NGUYEN C', 8);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(4, 'NGUYEN D', 7);
INSERT INTO SINHVIEN(MSSV, HOTENSINHVIEN, DTB) VALUES(5, 'NGUYEN E', 6);

--LIST OUT TABLE NAME  // WHERE OWNER = 'SYS' AND LAST_ANALYZED like TO_DATE('20200604', 'yyyymmdd') and
SELECT TABLE_NAME FROM DBA_TABLES WHERE
                               TABLE_NAME NOT LIKE '%$%' AND
                               TABLE_NAME NOT LIKE 'SYS%'AND
                               TABLE_NAME NOT LIKE 'DBA%'AND
                               TABLE_NAME NOT LIKE 'UTL%'AND
                               TABLE_NAME NOT LIKE 'SYS%'AND
                               TABLE_NAME NOT LIKE 'DBMS%'AND
                               TABLE_NAME NOT LIKE 'AQ%' AND
                               TABLE_NAME NOT LIKE 'HS%' AND
                               TABLE_NAME NOT LIKE 'OPATCH%' AND
                               TABLE_NAME NOT LIKE 'LOG%' AND
                               TABLE_NAME NOT LIKE 'CLUSTER%' AND
                               TABLE_NAME NOT LIKE 'DDL%' AND 
                               TABLE_NAME NOT LIKE 'ORD%' AND
                               TABLE_NAME NOT LIKE 'SDO%' AND
                               TABLE_NAME NOT LIKE 'OLS%' AND
                               TABLE_NAME NOT LIKE 'NDM%' AND
                               TABLE_NAME NOT LIKE 'EXT%' AND
                               TABLE_NAME NOT LIKE 'XML%' AND
                               TABLE_NAME NOT LIKE 'SI%' AND
                               TABLE_NAME NOT LIKE 'WLM%' AND
                               TABLE_NAME NOT LIKE 'BSLN%' AND
                               TABLE_NAME NOT LIKE 'MGMT%' AND
                               TABLE_NAME NOT LIKE 'OPENLS%';

--LIST OUT COLUMN IN TABLE
CREATE OR REPLACE PROCEDURE sp_CauTrucBangEMP_1753087
AS
    C1 SYS_REFCURSOR;
BEGIN
    OPEN C1 FOR
    SELECT column_name "Name"
    FROM user_tab_columns
    WHERE table_name='SYS.SINHVIEN';
    dbms_sql.return_result(c1);
END sp_CauTrucBangEMP_1753087;
/

--OR USING
CREATE OR REPLACE PROCEDURE P_GETCOLNAME(TABLE_NAMES IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE 'DESCRIBE ' || TABLE_NAMES;
end;

--CHECK HAVE GRANT OPTION OR NOT
select GRANTABLE from USER_TAB_PRIVS WHERE GRANTOR = SYS_CONTEXT('USERENV', 'SESSION_USER');
--GRANT SELECT MODE NO GRANT OPTION
CREATE OR REPLACE PROCEDURE P_SELECT_NO(TAB_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
BEGIN
    EXECUTE IMMEDIATE('GRANT SELECT ON'|| TAB_NAME || 'TO' || USR_NAME);
END P_SELECT_NO;

--GRANT SELECT ON TAB_NAME TO USR_NAME;
EXECUTE P_SELECT_NO('SINHVIEN','AMY');

--GRANT SELECT WITH GRANT OPTION
CREATE OR REPLACE PROCEDURE P_SELECT_YES(TAB_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
BEGIN
    EXECUTE IMMEDIATE 'GRANT SELECT ON '||TAB_NAME||' TO '||USR_NAME||' WITH GRANT OPTION';
END;
/

--GRANT UPDATE MODE IN
--NO GRANT OPTION
CREATE OR REPLACE PROCEDURE P_UPDATE_NO(COL_NAME IN VARCHAR2, TAB_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT UPDATE('||COL_NAME||') ON'|| TAB_NAME || 'TO' || USR_NAME;
    end P_UPDATE_NO;
    
EXECUTE P_UPDATE_NO('MSSV', 'SINHVIEN','AMY');
--WITH GRANT OPTION

CREATE OR REPLACE PROCEDURE P_UPDATE_YES(COL_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT UPDATE('||COL_NAME||') ON'|| TAB_NAME || 'TO' || USR_NAME || 'WITH GRANT OPTION';
    end P_UPDATE_YES;

--GRANT INSERT
--NO GRANT OPTION
CREATE OR REPLACE PROCEDURE P_INSERT_NO(COL_NAME IN VARCHAR2, TABLE_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT INSERT ('|| COL_NAME ||') ON' || TABLE_NAME || 'TO' || USR_NAME;
    end P_INSERT_NO;

--WITH GRANT OPTION
CREATE OR REPLACE PROCEDURE P_INSERT_YES(COL_NAME IN VARCHAR2, TABLE_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT INSERT ('|| COL_NAME ||') ON' || TABLE_NAME || 'TO' || USR_NAME || 'WITH GRANT OPTION';
    end P_INSERT_YES;

--GRANT DELETE
--NO GRANT OPTION
CREATE OR REPLACE PROCEDURE P_DELETE_NO(COL_NAME IN VARCHAR2, TABLE_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT DELETE ('|| COL_NAME ||') ON' || TABLE_NAME || 'TO' || USR_NAME;
    end P_DELETE_NO;

--WITH GRANT OPTION
CREATE OR REPLACE PROCEDURE P_DELETE_YES(COL_NAME IN VARCHAR2, TABLE_NAME IN VARCHAR2, USR_NAME IN VARCHAR2)
IS
    BEGIN
        EXECUTE IMMEDIATE 'GRANT DELETE ('|| COL_NAME ||') ON' || TABLE_NAME || 'TO' || USR_NAME || 'WITH GRANT OPTION';
    end P_DELETE_YES;
