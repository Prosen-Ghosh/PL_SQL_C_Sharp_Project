# TIGGER
----------------------------------------------------------------------------------------------------
### 1. ADMIN_TO_USER_CONTROL
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER ADMIN_TO_USER_CONTROL after INSERT or UPDATE of ADMINPASSWORD or DELETE on ADMIN for EACH ROW
DECLARE 
log varchar2(20);
BEGIN
IF (inserting) THEN
log:='ADMIN';
INSERT into USER_CONTROL VALUES(:NEW.ADMINID,:NEW.ADMINPASSWORD,log);
ELSIF (updating) THEN
UPDATE USER_CONTROL set PASSWORD=:NEW.ADMINPASSWORD where USERID=:OLD.ADMINID;
ELSIF (deleting) THEN
DELETE from USER_CONTROL where USERID=:OLD.ADMINID;
END IF;
END;
```
----------------------------------------------------------------------------------------------------
### 2. MANAGER_TO_USER_CONTROL
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER MANAGER_TO_USER_CONTROL after INSERT or UPDATE of MANAGERPASSWORD or DELETE on MANAGER for EACH ROW
DECLARE 
log varchar2(20);
BEGIN
IF (inserting) THEN
log:='MANAGER';
INSERT into USER_CONTROL VALUES(:NEW.MANAGERID,:NEW.MANAGERPASSWORD,log);
ELSIF (updating) THEN
UPDATE USER_CONTROL set PASSWORD=:NEW.MANAGERPASSWORD where USERID=:OLD.MANAGERID;
ELSIF (deleting) THEN
DELETE from USER_CONTROL where USERID=:OLD.MANAGERID;
END IF;
END;
```
----------------------------------------------------------------------------------------------------
### 3. USER_PERFORM_LOG_ON_ADMIN
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_ADMIN after INSERT or UPDATE  or DELETE on ADMIN 
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='ADMIN';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 4. USER_PERFORM_LOG_ON_DEPARTMENT
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_DEPARTMENT after INSERT or UPDATE  or DELETE on DEPARTMENT 
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='DEPARTMENT';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 5. USER_PERFORM_LOG_ON_JOB
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_JOB after INSERT or UPDATE  or DELETE on JOB 
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='JOB';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 6. USER_PERFORM_LOG_ON_SAL_GRADE
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_SAL_GRADE after INSERT or UPDATE  or DELETE on SAL_GRADE
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='SAL_GRADE';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 7. USER_PERFORM_LOG_ON_COUNTRY
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_COUNTRY after INSERT or UPDATE  or DELETE on COUNTRY
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='COUNTRY';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 8. USER_PERFORM_LOG_ON_ADDRESS
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_ADDRESS after INSERT or UPDATE  or DELETE on ADDRESS
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='ADDRESS';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 9. USER_PERFORM_LOG_ON_MANAGER
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_MANAGER after INSERT or UPDATE  or DELETE on MANAGER
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='MANAGER';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;


```

----------------------------------------------------------------------------------------------------
### 10. USER_PERFORM_LOG_ON_EMPLOYEE
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER USER_PERFORM_LOG_ON_EMPLOYEE after INSERT or UPDATE  or DELETE on EMPLOYEE
DECLARE 
LOG1 VARCHAR2(20);
LOG2 VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
LOG2:='EMPLOYEE';
IF (inserting) THEN
LOG1:='INSERT';
ELSIF (updating) THEN
LOG1:='UPDATE';
ELSIF (deleting) THEN
LOG1:='DELETE';
END IF;
INSERT INTO USER_PERFORM_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),LOG1,LOG2,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 11. REMOVED_EMPLOYEE_LOG_TRIG
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER REMOVED_EMPLOYEE_LOG_TRIG after DELETE on EMPLOYEE FOR EACH ROW
DECLARE 
LOG VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
LOG:='EMPLOYEE';
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
INSERT INTO FIRED_EMPLOYEE_LOG VALUES(:OLD.EMPLOYEEID,LOG,:OLD.EMPLOYEENAME,:OLD.EMPLOYEEEMAIL,:OLD.EMPLOYEEPHONE,:OLD.EMPLOYEEGENDER,:OLD.EMPLOYEEHIREDATE,SYSDATE,:OLD.EMPLOYEESALARY,:OLD.DEPARTMENT_ID,:OLD.JOB_ID,:OLD.ADDRESS_ID,:OLD.SHIFT_ID,A_ID,A_TYPE);
END;

```

----------------------------------------------------------------------------------------------------
### 12. REMOVED_MANAGER_LOG_TRIG
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER REMOVED_MANAGER_LOG_TRIG after DELETE on MANAGER FOR EACH ROW
DECLARE 
LOG VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
LOG:='MANAGER';
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
INSERT INTO FIRED_EMPLOYEE_LOG VALUES(:OLD.MANAGERID,LOG,:OLD.MANAGERNAME,:OLD.MANAGEREMAIL,:OLD.MANAGERPHONE,:OLD.MANAGERGENDER,:OLD.MANAGERHIREDATE,SYSDATE,:OLD.MANAGERSALARY,:OLD.DEPARTMENTID,:OLD.JOBID,:OLD.ADDRESSID,:OLD.SHIFT_ID,A_ID,A_TYPE);
END;
```

----------------------------------------------------------------------------------------------------
### 13. EMP_SAL_UPDATE_LOG
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER EMP_SAL_UPDATE_LOG after UPDATE OF EMPLOYEESALARY on EMPLOYEE FOR EACH ROW
DECLARE 
LOG VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
LOG:='EMPLOYEE';
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
INSERT INTO SAL_UPDATE_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),:OLD.EMPLOYEEID,LOG,:OLD.EMPLOYEESALARY,:NEW.EMPLOYEESALARY,A_ID,A_TYPE);
END;
```
----------------------------------------------------------------------------------------------------
### 14. MGR_SAL_UPDATE_LOG
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE TRIGGER MGR_SAL_UPDATE_LOG after UPDATE OF MANAGERSALARY on MANAGER FOR EACH ROW
DECLARE 
LOG VARCHAR2(20);
A_TYPE VARCHAR2(20);
A_ID NUMBER;
BEGIN
LOG:='MANAGER';
SELECT USER_ID,USER_TYPE INTO A_ID,A_TYPE FROM CURRENT_LOGEDIN_TABLE;
INSERT INTO SAL_UPDATE_LOG VALUES(SYSDATE,TO_CHAR(SYSDATE,'HH24:MI:SS'),:OLD.MANAGERID,LOG,:OLD.MANAGERSALARY,:NEW.MANAGERSALARY,A_ID,A_TYPE);
END;
```



