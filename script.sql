/*Tao user dbadmin*/
--->Login vao sys
    alter session set "_ORACLE_SCRIPT"=true;
create user dbadmin identified by dbadmin
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
--Grant quyen cho dbadmin
grant create session, create user, drop user, create role, 
drop any role, create procedure, execute any procedure, 
alter any procedure, drop any procedure, select any table,
create table, insert any table, update any table, drop any table to dbadmin with admin option;
grant select on sys.dba_sys_privs to dbadmin;
grant select on sys.dba_role_privs to dbadmin;
/*1. Xem ds nguoi dung trong he thong*/
-- Xem ds nguoi dung trong he thong
select username from all_users;
-- Thong tin ve  quyen (Quyen he thong) cua moi user
select * from dba_sys_privs where grantee = 'SYS';
-- Thong tin ve role
select * from dba_role_privs where grantee = 'SYS';
-- Tao role
create role A;
--Procedure thuc thi drop user
create or replace procedure sp_Drop_user(username in varchar2)
is
begin
  EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
  execute IMMEDIATE('drop user ' || username);
end;
--Procedure thuc thi create user
create or replace procedure sp_create_user(username in varchar2, pw in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    EXECUTE IMMEDIATE('create user ' || username || ' identified by ' || pw || ' default tablespace users TEMPORARY TABLESPACE temp Quota 10M on users');
    EXECUTE IMMEDIATE('grant create session to ' || username);
end;
--Procedure tao role
create or replace procedure sp_create_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('create role ' || rolename);
end;
--Procedure drop role
create or replace procedure sp_drop_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('drop role ' || rolename);
end;
execute sp_create_role('da2');
execute sp_drop_role('da1');
execute sp_create_user('da2', 'da2');
execute sp_drop_user('da2');
execute sp_grant_user('da2', 'insert any table');
grant create table to da2;
--Procedure grant
create or replace procedure sp_grant_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username);
end;
--Procedure revoke
create or replace procedure sp_revoke_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || name_privs || ' from ' || username);
end;
revoke create session from da2;
grant create session to da2;
execute sp_revoke_user('da2', 'create session');

grant create session to da2 with admin option;

execute sp_grant('da2', 'create table', '');

create or replace procedure sp_grant(username in varchar2, name_privs in varchar2, with_option in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username || ' ' || with_option);
end;

select * from dba_sys_privs where grantee = 'DA2';


