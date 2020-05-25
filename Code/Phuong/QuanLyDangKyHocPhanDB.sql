-- Generated by Oracle SQL Developer Data Modeler 19.4.0.350.1424
--   at:        2020-05-14 22:43:02 ICT
--   site:      Oracle Database 11g
--   type:      Oracle Database 11g

CREATE TABLE taikhoan (
    username  VARCHAR2(32),
    usertype  VARCHAR2(32) --svien, gvien, gvu, trgbm, trgkhoa
);
/
ALTER TABLE taikhoan ADD CONSTRAINT taikhoan_pk PRIMARY KEY ( username );
/
CREATE TABLE lop (
    malop   VARCHAR2(10) NOT NULL,
    tenlop  NVARCHAR2(50)
);
/
ALTER TABLE lop ADD CONSTRAINT lop_pk PRIMARY KEY ( malop );
/
CREATE TABLE sinhvien (
    mssv               VARCHAR2(10) NOT NULL,
    hoten_sinhvien     NVARCHAR2(50),
    lop              VARCHAR2(10) NOT NULL,
    ngaysinh_sv  DATE,
    diachi_sv    NVARCHAR2(150),
    gioitinh_sv  NCHAR(3),
    cmnd_sv     VARCHAR2(11),
    sdt_sv     CHAR(10),
    email_sv     VARCHAR2(50)
);
/

ALTER TABLE sinhvien ADD CONSTRAINT sinhvien_pk PRIMARY KEY ( mssv );
/

CREATE TABLE giaovien (
    magiaovien         VARCHAR2(15) NOT NULL,
    hoten_giaovien     NVARCHAR2(50),
    ngaysinh_gv  DATE,
    diachi_gv    NVARCHAR2(150),
    gioitinh_gv  NCHAR(3),
    cmnd_gv      VARCHAR2(11),
    sdt_gv     CHAR(10),
    email_gv     VARCHAR2(50),
    mabomon            VARCHAR2(10),
    truongkhoa         CHAR(1),
    loaigiaovien       CHAR(1)
    
);
/

ALTER TABLE giaovien ADD CONSTRAINT giaovien_pk PRIMARY KEY ( magiaovien );
/

CREATE TABLE bomon (
    mabomon      VARCHAR2(10) NOT NULL,
    tenbomon     NVARCHAR2(50),
    truongbomon  VARCHAR2(15)
);
/

ALTER TABLE bomon ADD CONSTRAINT bomon_pk PRIMARY KEY ( mabomon );
/

CREATE TABLE monhoc (
    mamonhoc       VARCHAR2(10) NOT NULL,
    tenmonhoc      NVARCHAR2(50),
    mabomon  	   VARCHAR2(10),
    sotinchi       NUMBER
);
/

ALTER TABLE monhoc ADD CONSTRAINT monhoc_pk PRIMARY KEY ( mamonhoc );
/

CREATE TABLE thoikhoabieu (
    malop                VARCHAR2(10) NOT NULL,
    mamonhoc             VARCHAR2(10) NOT NULL,
    hocky                NUMBER NOT NULL,
    namhoc               CHAR(9) NOT NULL,
    phonghoc             VARCHAR2(10),
    giaoviengiangday  VARCHAR2(15),
    sosinhvientoida	 NUMBER
    
);
/

ALTER TABLE thoikhoabieu
    ADD CONSTRAINT thoikhoabieu_pk PRIMARY KEY (malop , mamonhoc, hocky, namhoc);
                                                 

CREATE TABLE diem (
    mssv      VARCHAR2(10) NOT NULL,
    malop     VARCHAR2(10) NOT NULL,
    mamonhoc  VARCHAR2(10) NOT NULL,
    hocky     NUMBER(1) NOT NULL,
    namhoc    CHAR(9) NOT NULL,
    diemgiuaky    varchar2(20),
    diemcuoiky    varchar2(20),
    diemkhac  varchar2(20),
    diemtong  varchar2(20)
);

ALTER TABLE diem
    ADD CONSTRAINT diem_pk PRIMARY KEY ( hmssv, malop, mamonhoc, hocky, namhoc);

ALTER TABLE bomon
    ADD CONSTRAINT bomon_giaovien_fk FOREIGN KEY ( truongbomon )
        REFERENCES giaovien ( magiaovien );

ALTER TABLE diem
    ADD CONSTRAINT diem_sinhvien_fk FOREIGN KEY ( mssv )
        REFERENCES sinhvien ( mssv );

ALTER TABLE diem
    ADD CONSTRAINT diem_thoikhoabieu_fk FOREIGN KEY ( malop, mamonhoc, hocky, namhoc )
        REFERENCES thoikhoabieu ( malop, mamonhoc, hocky, namhoc );

ALTER TABLE giaovien
    ADD CONSTRAINT giaovien_bomon_fk FOREIGN KEY ( mabomon )
        REFERENCES bomon ( mabomon );


ALTER TABLE monhoc
    ADD CONSTRAINT monhoc_bomon_fk FOREIGN KEY ( mabomon )
        REFERENCES bomon ( mabomon );

ALTER TABLE sinhvien
    ADD CONSTRAINT sinhvien_lop_fk FOREIGN KEY ( lop )
        REFERENCES lop ( malop );

ALTER TABLE thoikhoabieu
    ADD CONSTRAINT thoikhoabieu_giaovien_fk FOREIGN KEY ( giaoviengiangday )
        REFERENCES giaovien ( magiaovien );

ALTER TABLE thoikhoabieu
    ADD CONSTRAINT thoikhoabieu_lop_fk FOREIGN KEY ( malop )
        REFERENCES lop ( malop );

ALTER TABLE thoikhoabieu
    ADD CONSTRAINT thoikhoabieu_monhoc_fk FOREIGN KEY ( mamonhoc )
        REFERENCES monhoc ( mamonhoc );

----Tao user sinhvien, giaovu, giaovien
alter session set "_ORACLE_SCRIPT"=true;
/
--User : SinhVien
create user sv1 identified by sv1
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;

create user sv2 identified by sv2
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
--User: GiaoVu

create user gvu_ntmthu identified by gvu_ntmthu
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;

--User: GiaoVien
create user gvktpm_lbuan identified by lbluan
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;

create user gvhttt_nahoang identified by nahoang
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;

create user gvkhmt_ltlinh identified by ltlinh
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;

-----
---Cap quyen select bang giaovien cho giao vien
grant select on sec_admin.giaovien to giaovu;
grant select on sec_admin.giaovien to gvktpm_lbuan;



create role svien;
/

create role gvien;
/

create role gvu;
/

create role trgbm;
/

create role trgkhoa;
/


grant connect to svien, gvien, gvu, trgbm, trgkhoa;
/
grant select on taikhoan to svien, gvien, gvu, trgbm, trgkhoa;
/

grant svien to sv1, sv2;
/
grant gvien to gvktpm_lbuan, gvhttt_nahoang, gvkhmt_ltlinh;
/
grant gvu to gvu_ntmthu;
/

insert into taikhoan values ('sv1', 'svien');
/
insert into taikhoan values ('sv1', 'svien');
/
insert into taikhoan values ('gvktpm_lbuan', 'gvien');
/
insert into taikhoan values ('gvhttt_nahoang', 'gvien');
/
insert into taikhoan values ('gvkhmt_ltlinh', 'gvien');
/
insert into taikhoan values ('gvu_ntmthu', 'gvu');
/