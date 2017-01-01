# PROCEDURE
----------------------------------------------------------------------------------------------------------------------------
### 1. ADD_ADMIN()
----------------------------------------------------------------------------------------------------
```sql 
CREATE SEQUENCE ADMIN_SEQ
 START WITH     2
 INCREMENT BY   1
 MAXVALUE 99
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_ADMIN(NAME ADMIN.ADMINNAME%TYPE, PASSWORD ADMIN.ADMINPASSWORD%TYPE,  E_MAIL ADMIN.ADMINEMAIL%TYPE, GENDER ADMIN.ADMINGENDER%TYPE,PHONE ADMIN.ADMINPHONENO%TYPE) is 
BEGIN
INSERT INTO ADMIN VALUES(ADMIN_SEQ.NEXTVAL, NAME, PASSWORD, E_MAIL,GENDER,PHONE);
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 2. DELETE_ADMIN()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_ADMIN(ID ADMIN.ADMINID%TYPE) is 
BEGIN
DELETE FROM ADMIN WHERE ADMINID=ID;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 3. UPDATE_ADMIN()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_ADMIN(ID ADMIN.ADMINID%TYPE,NAME ADMIN.ADMINNAME%TYPE, PASSWORD ADMIN.ADMINPASSWORD%TYPE,  E_MAIL ADMIN.ADMINEMAIL%TYPE, GENDER ADMIN.ADMINGENDER%TYPE,PHONE ADMIN.ADMINPHONENO%TYPE) is 
BEGIN
UPDATE ADMIN SET ADMINNAME=NAME, ADMINPASSWORD=PASSWORD, ADMINEMAIL=E_MAIL, ADMINGENDER=GENDER, ADMINPHONENO=PHONE WHERE ADMINID=ID;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 4. ADD_DEPARTMENT()
----------------------------------------------------------------------------------------------------
```sql
 CREATE SEQUENCE DEPARTMENT_SEQ
 START WITH     100
 INCREMENT BY   1
 MAXVALUE 199
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_DEPARTMENT(NAME DEPARTMENT.DEPARTMENTNAME%TYPE) is 
BEGIN
INSERT INTO DEPARTMENT VALUES(DEPARTMENT_SEQ.NEXTVAL, NAME);
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 5. DELETE_DEPARTMENT()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_DEPARTMENT(ID DEPARTMENT.DEPARTMENTID%TYPE) is 
BEGIN
DELETE FROM DEPARTMENT WHERE DEPARTMENTID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 6. UPDATE_DEPARTMENT()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_DEPARTMENT(ID DEPARTMENT.DEPARTMENTID%TYPE,NAME DEPARTMENT.DEPARTMENTNAME%TYPE) is
BEGIN
UPDATE DEPARTMENT SET DEPARTMENTNAME=NAME WHERE DEPARTMENTID=ID;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 7. ADD_SAL_GRADE()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE ADD_SAL_GRADE(GD SAL_GRADE.GRADE%TYPE, HI_SAL SAL_GRADE.HIGHSAL%TYPE,  L_SAL SAL_GRADE.LOWSAL%TYPE) is 
BEGIN
INSERT INTO SAL_GRADE VALUES(GD, HI_SAL, L_SAL);
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 8. DELETE_SAL_GRADE()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_SAL_GRADE(GD SAL_GRADE.GRADE%TYPE) is 
BEGIN
DELETE FROM SAL_GRADE WHERE GRADE=GD;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 9. UPDATE_SAL_GRADE()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_SAL_GRADE(GD SAL_GRADE.GRADE%TYPE,HI_SAL SAL_GRADE.HIGHSAL%TYPE, L_SAL SAL_GRADE.LOWSAL%TYPE) is 
BEGIN
UPDATE SAL_GRADE SET HIGHSAL=HI_SAL, LOWSAL=L_SAL WHERE GRADE=GD;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 10. ADD_JOB()
----------------------------------------------------------------------------------------------------
```sql
 CREATE SEQUENCE JOB_SEQ
 START WITH     200
 INCREMENT BY   1
 MAXVALUE 499
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_JOB(NAME JOB.JOBNAME%TYPE, HI_SAL JOB.HIGHSAL%TYPE,  L_SAL JOB.LOWSAL%TYPE) is 
BEGIN
INSERT INTO JOB VALUES(JOB_SEQ.NEXTVAL, NAME, HI_SAL,L_SAL);
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 11. DELETE_JOB()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_JOB(ID JOB.JOBID%TYPE) is 
BEGIN
DELETE FROM JOB WHERE JOBID=ID;
END;
```
----------------------------------------------------------------------------------------------------------------------------
### 12. UPDATE_JOB()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_JOB(ID JOB.JOBID%TYPE,NAME JOB.JOBNAME%TYPE,HI_SAL JOB.HIGHSAL%TYPE, L_SAL JOB.LOWSAL%TYPE) is 
BEGIN
UPDATE JOB SET JOBNAME=NAME,HIGHSAL=HI_SAL, LOWSAL=L_SAL WHERE JOBID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 13. ADD_COUNTRY()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE ADD_COUNTRY(CODE COUNTRY.COUNTRYCODE%TYPE,NAME COUNTRY.COUNTRYNAME%TYPE) is 
BEGIN
INSERT INTO COUNTRY VALUES(CODE, NAME);
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 14. DELETE_COUNTRY()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_COUNTRY(CODE COUNTRY.COUNTRYCODE%TYPE) is 
BEGIN
DELETE FROM COUNTRY WHERE COUNTRYCODE=CODE;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 15. UPDATE_COUNTRY()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_COUNTRY(CODE COUNTRY.COUNTRYCODE%TYPE,NAME COUNTRY.COUNTRYNAME%TYPE) is 
BEGIN
UPDATE COUNTRY SET COUNTRYNAME=NAME WHERE COUNTRYCODE=CODE;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 16. ADD_ADDRESS()
----------------------------------------------------------------------------------------------------
```sql
 CREATE SEQUENCE ADDRESS_SEQ
 START WITH     500
 INCREMENT BY   1
 MAXVALUE 99999
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_ADDRESS(CODE ADDRESS.COUNTRYCODE%TYPE,DIV ADDRESS.DIVISION%TYPE,CT ADDRESS.CITY%TYPE) is 
BEGIN
INSERT INTO ADDRESS VALUES(ADDRESS_SEQ.NEXTVAL, CODE, DIV,CT);
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 17. DALETE_ADDRESS()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_ADDRESS(ID ADDRESS.ADDRESSID%TYPE) is 
BEGIN
DELETE FROM ADDRESS WHERE ADDRESSID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 18. UPDATE_ADDRESS()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_ADDRESS(ID ADDRESS.ADDRESSID%TYPE,CODE ADDRESS.COUNTRYCODE%TYPE,DIV ADDRESS.DIVISION%TYPE,CT ADDRESS.CITY%TYPE) is 
BEGIN
UPDATE ADDRESS SET COUNTRYCODE=CODE,DIVISION=DIV,CITY=CT WHERE ADDRESSID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 19. ADD_MANAGER()
----------------------------------------------------------------------------------------------------
```sql
 CREATE SEQUENCE MANAGER_SEQ
 START WITH     100000
 INCREMENT BY   1
 MAXVALUE 109999
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_MANAGER(NAME MANAGER.MANAGERNAME%TYPE, PASSWORD MANAGER.MANAGERPASSWORD%TYPE,  E_MAIL MANAGER.MANAGEREMAIL%TYPE,PHONE MANAGER.MANAGERPHONE%TYPE, GENDER MANAGER.MANAGERGENDER%TYPE, SAL MANAGER.MANAGERSALARY%TYPE, D_ID MANAGER.DEPARTMENTID%TYPE,J_ID MANAGER.JOBID%TYPE,A_ID MANAGER.ADDRESSID%TYPE,S_ID MANAGER.SHIFT_ID%TYPE) is 
BEGIN
INSERT INTO MANAGER VALUES(MANAGER_SEQ.NEXTVAL, NAME, PASSWORD, E_MAIL,PHONE,GENDER,SYSDATE,SAL,D_ID,J_ID,A_ID,S_ID);
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 20. DALETE_MANAGER()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_MANAGER(ID MANAGER.MANAGERID%TYPE) is 
BEGIN
DELETE FROM MANAGER WHERE MANAGERID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 21. UPDATE_MANAGER()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_MANAGER(ID MANAGER.MANAGERID%TYPE,NAME MANAGER.MANAGERNAME%TYPE, PASSWORD MANAGER.MANAGERPASSWORD%TYPE,  E_MAIL MANAGER.MANAGEREMAIL%TYPE,PHONE MANAGER.MANAGERPHONE%TYPE, GENDER MANAGER.MANAGERGENDER%TYPE, SAL MANAGER.MANAGERSALARY%TYPE, D_ID MANAGER.DEPARTMENTID%TYPE,J_ID MANAGER.JOBID%TYPE,A_ID MANAGER.ADDRESSID%TYPE,S_ID MANAGER.SHIFT_ID%TYPE) is 
BEGIN
UPDATE MANAGER SET MANAGERNAME=NAME, MANAGERPASSWORD=PASSWORD, MANAGEREMAIL=E_MAIL, MANAGERPHONE=PHONE, MANAGERGENDER=GENDER, MANAGERSALARY=SAL, DEPARTMENTID=D_ID, JOBID=J_ID, ADDRESSID=A_ID, SHIFT_ID=S_ID WHERE MANAGERID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 22. ADD_EMPLOYEE()
----------------------------------------------------------------------------------------------------
```sql
 CREATE SEQUENCE EMPLOYEE_SEQ
 START WITH     110000
 INCREMENT BY   1
 MAXVALUE 199999
 NOCACHE
 NOCYCLE;

CREATE or REPLACE PROCEDURE ADD_EMPLOYEE(NAME EMPLOYEE.EMPLOYEENAME%TYPE, E_MAIL EMPLOYEE.EMPLOYEEEMAIL%TYPE, PHONE EMPLOYEE.EMPLOYEEPHONE%TYPE, GENDER EMPLOYEE.EMPLOYEEGENDER%TYPE, SAL EMPLOYEE.EMPLOYEESALARY%TYPE, COMM EMPLOYEE.EMPLOYEECOMMISSION%TYPE, D_ID EMPLOYEE.DEPARTMENT_ID%TYPE, M_ID EMPLOYEE.MANAGER_ID%TYPE, J_ID EMPLOYEE.JOB_ID%TYPE, A_ID EMPLOYEE.ADDRESS_ID%TYPE, S_ID EMPLOYEE.SHIFT_ID%TYPE) is 
BEGIN
INSERT INTO EMPLOYEE VALUES(EMPLOYEE_SEQ.NEXTVAL, NAME, E_MAIL, PHONE, GENDER,SYSDATE, SAL, COMM, D_ID, M_ID, J_ID, A_ID, S_ID);
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 23. DELETE_EMPLOYEE()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE DELETE_EMPLOYEE(ID EMPLOYEE.EMPLOYEEID%TYPE) is 
BEGIN
DELETE FROM EMPLOYEE WHERE EMPLOYEEID=ID;
END;
```
--------------------------------------------------------------------------------------------------------------------------------
### 24. UPDATE_EMPLOYEE()
----------------------------------------------------------------------------------------------------
```sql
CREATE or REPLACE PROCEDURE UPDATE_EMPLOYEE(ID EMPLOYEE.EMPLOYEEID%TYPE,NAME EMPLOYEE.EMPLOYEENAME%TYPE, E_MAIL EMPLOYEE.EMPLOYEEEMAIL%TYPE, PHONE EMPLOYEE.EMPLOYEEPHONE%TYPE, GENDER EMPLOYEE.EMPLOYEEGENDER%TYPE, SAL EMPLOYEE.EMPLOYEESALARY%TYPE, COMM EMPLOYEE.EMPLOYEECOMMISSION%TYPE, D_ID EMPLOYEE.DEPARTMENT_ID%TYPE, M_ID EMPLOYEE.MANAGER_ID%TYPE, J_ID EMPLOYEE.JOB_ID%TYPE, A_ID EMPLOYEE.ADDRESS_ID%TYPE, S_ID EMPLOYEE.SHIFT_ID%TYPE) is 
BEGIN
UPDATE EMPLOYEE SET EMPLOYEENAME=NAME, EMPLOYEEEMAIL=E_MAIL, EMPLOYEEPHONE=PHONE, EMPLOYEEGENDER=GENDER,  EMPLOYEESALARY=SAL, EMPLOYEECOMMISSION=COMM, DEPARTMENT_ID=D_ID, MANAGER_ID=M_ID, JOB_ID=J_ID, ADDRESS_ID=A_ID, SHIFT_ID=S_ID WHERE EMPLOYEEID=ID;
END;
```










