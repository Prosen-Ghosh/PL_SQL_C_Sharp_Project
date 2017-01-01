# FUNCTION
---------------------------------------------------------------------------------------------------------------------------
### 1. USER_LOGIN_FUNCTION
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE OR REPLACE FUNCTION GET_LOGIN_INFO( user_id in USER_CONTROL.USERID%TYPE,user_password in USER_CONTROL.PASSWORD%TYPE) 
RETURN USER_CONTROL.USERTYPE%TYPE
IS
    USER_TYPE USER_CONTROL.USERTYPE%TYPE;
BEGIN
    SELECT USERTYPE INTO USER_TYPE FROM USER_CONTROL WHERE USERID = user_id AND PASSWORD = user_password;
    RETURN USER_TYPE;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 2. CHECK_DEPT_NAME
--------------------------------------------------------------------------------------------------
```sql
CREATE OR REPLACE FUNCTION CHECK_DEPT_NAME(NAME IN DEPARTMENT.DEPARTMENTNAME%TYPE)
RETURN NUMBER
IS
VAL NUMBER;
BEGIN
SELECT COUNT(*) INTO VAL FROM DEPARTMENT WHERE DEPARTMENTNAME= NAME;
IF(VAL = 0) THEN
    ADD_DEPARTMENT(NAME);
ELSE 
    RETURN VAL;
END IF;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 3. ADD_ADDRESS_FUNC()
----------------------------------------------------------------------------------------
```sql
CREATE OR REPLACE FUNCTION ADD_ADDRESS_FUNC(CODE ADDRESS.COUNTRYCODE%TYPE,DIV ADDRESS.DIVISION%TYPE,CT ADDRESS.CITY%TYPE) RETURN NUMBER is 
VAR NUMBER;
CNT NUMBER;
BEGIN
SELECT COUNT(*) INTO CNT FROM ADDRESS WHERE COUNTRYCODE=CODE AND DIVISION=DIV AND CITY=CT;
IF(CNT >=1) THEN
SE
LECT ADDRESSID INTO VAR FROM ADDRESS WHERE COUNTRYCODE=CODE AND DIVISION=DIV AND CITY=CT;RETURN VAR;
ELSE
INSERT INTO ADDRESS VALUES(ADDRESS_SEQ.NEXTVAL, CODE, DIV,CT);
RETURN ADDRESS_SEQ.CURRVAL;
EN
D IF;
END;
```
---------------------------------------------------------------------------------------------------------------------------
### 4. CURRENT_LOGEDIN_MANAGER()
----------------------------------------------------------------------------------------
```sql
CREATE OR REPLACE FUNCTION CURRENT_LOGEDIN_MANAGER
RETURN NUMBER IS
RETVAL NUMBER;
BEGIN
SELECT USER_ID INTO RETVAL FROM current_logedin_table;
RETURN RETVAL;
END;
```

