--xem all user trong database duoc tao boi bat ki ai
    select * from all_users
    order by created;
/
--xem all user duoc tao boi nguoi sysdba
SELECT * FROM user_users;
-- show privileges
--nhieu qua coi cai nay tam di https://chartio.com/resources/tutorials/oracle-user-privileges--how-to-show-all-privileges-for-a-user/
select * from USER_SYS_PRIVS;
SELECT * FROM USER_TAB_PRIVS; 
SELECT * FROM USER_ROLE_PRIVS;


alter session set "_ORACLE_SCRIPT"=true --before create user have to alter session? idk why doing this

--tao user moi khong co quyen
create user ahihi identified by passWords; --create new user with password
grant connect to ahihi; --grant role to user

drop user ahihi;

/

exec create_user admin1 password2;

drop procedure create_user;