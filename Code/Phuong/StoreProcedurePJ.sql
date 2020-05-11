
--for tables/view
create or replace procedure sp_grant_priv_tabview(grantee in varchar2, privs in varchar2, tabview_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant '|| privs ||' on ' || tabview_name ||' to ' ||grantee|| ' ' ||opt);
end;
/


create or replace procedure sp_revoke_priv_tabview(grantee in varchar2, privs in varchar2, tabview_name in varchar2)
is
begin
    execute immediate('revoke '|| privs ||' on ' || tabview_name ||' from ' ||grantee);
end;
/

--for routine
create or replace procedure sp_grant_priv_func(grantee in varchar2, func_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant execute on ' || func_name ||' to ' ||grantee|| ' ' ||opt);
end;
/

create or replace procedure sp_grant_priv_pro(grantee in varchar2, pro_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant execute on ' || pro_name ||' to ' ||grantee|| ' ' ||opt);
end;
/

create or replace procedure sp_revoke_priv_func(grantee in varchar2, func_name in varchar2)
is
begin
    execute immediate('revoke execute on ' || func_name ||' from ' ||grantee||' restrict');
end;
/

create or replace procedure sp_revoke_priv_pro(grantee in varchar2, pro_name in varchar2)
is
begin
    execute immediate('revoke execute on ' || pro_name ||' from ' ||grantee||' restrict');
end;
/


--for sequence generators

create or replace procedure sp_grant_seq(grantee in varchar2, seq_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant usage on sequence ' || seq_name ||' to ' ||grantee|| ' ' ||opt);
end;
/

create or replace procedure sp_revoke_seq(grantee in varchar2, seq_name in varchar2)
is
begin
    execute immediate('revoke usage on sequence ' || seq_name ||' from ' ||grantee||' restrict');
end;
/

--for user defined typed

create or replace procedure sp_grant_utype(grantee in varchar2, utype_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant usage on type ' || utype_name ||' to ' ||grantee|| ' ' ||opt);
end;
/

create or replace procedure sp_revoke_utype(grantee in varchar2, utype_name in varchar2)
is
begin
    execute immediate('revoke usage on type ' || utype_name ||' from ' ||grantee||' restrict');
end;
/

--for role 
create or replace procedure sp_grant_role(grantee in varchar2, role_name in varchar2, opt varchar2)
is
begin
    execute immediate('grant '|| role_name ||' to ' ||grantee|| ' ' ||opt);
end;
/

create or replace procedure sp_revoke_role(grantee in varchar2, role_name in varchar2)
is
begin
    execute immediate('revoke ' || role_name ||' from ' ||grantee);
end;
/



