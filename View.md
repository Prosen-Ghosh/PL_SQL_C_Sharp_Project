# VIEWS
- [1. SHIFT WISE MANAGER]
- [2. DEPT WISE EMPLOYEE]
- [3. EMPLOYEE INFORMATION]
- [4. MANAGER INFORMATION]
- [5. HIGH SALARY EMPLOYEE]
- [6. LOWER SALARY EMPLOYEE]
- [7. EMPLOYEE PER MANAGER]
- [8. AVG MAX MIN SALARY EMPLOYEE]



---------------------------------------------------------------------------------------------------------------------------
### 1. SHIFT_WISE_MANAGER
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW SHIFT_MORNING_MANAGER AS SELECT MANAGERID,MANAGERNAME FROM MANAGER WHERE SHIFT_ID=1;
-----------------------------------------------------------------------------------------------------------------------------
CREATE VIEW SHIFT_NIGHT_MANAGER AS SELECT MANAGERID,MANAGERNAME FROM MANAGER WHERE SHIFT_ID=2;
```


-----------------------------------------------------------------------------------------------------------------------------
### 2.  DEPT_WISE_EMP
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW DEPT_WISE_EMP AS SELECT * FROM EMPLOYEE E,DEPARTMENT D WHERE E.DEPARTMENT_ID=D.DEPARTMENTID AND D.DEPARTMENTNAME='SWING';
```


-----------------------------------------------------------------------------------------------------------------------------
### 3. EMPLOYEE_INFORMATION
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW EMPLOYEE_INFORMATION  AS SELECT E.EMPLOYEEID,UPPER(E.EMPLOYEENAME) AS EMPLOYEENAME,E.EMPLOYEEEMAIL,E.EMPLOYEEPHONE,E.EMPLOYEEGENDER,C.COUNTRYNAME,A.DIVISION,A.CITY,E.EMPLOYEEHIREDATE,E.EMPLOYEESALARY,UPPER(D.DEPARTMENTNAME) AS DEPARTMENTNAME,M.MANAGERNAME,UPPER(J.JOBNAME) AS JOBNAME,S.SHIFT_NAME,G.GRADE FROM EMPLOYEE E,DEPARTMENT D,MANAGER M,JOB J,WORK_SHIFT S,SAL_GRADE G,ADDRESS A,COUNTRY C WHERE E.DEPARTMENT_ID=D.DEPARTMENTID AND E.MANAGER_ID=M.MANAGERID AND E.JOB_ID=J.JOBID AND E.SHIFT_ID=S.SHIFT_ID AND E.EMPLOYEESALARY BETWEEN G.LOWSAL AND G.HIGHSAL AND E.ADDRESS_ID=A.ADDRESSID AND A.COUNTRYCODE=C.COUNTRYCODE;
```


-----------------------------------------------------------------------------------------------------------------------------
### 4. MANAGER_INFORMATION
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW MANAGER_INFORMATION  AS SELECT M.MANAGERID,UPPER(M.MANAGERNAME) AS MANAGERNAME,M.MANAGEREMAIL,M.MANAGERPHONE,M.MANAGERGENDER,M.MANAGERHIREDATE,M.MANAGERSALARY,C.COUNTRYNAME,A.DIVISION,A.CITY,UPPER(D.DEPARTMENTNAME) AS DEPARTMENTNAME,S.SHIFT_NAME,G.GRADE FROM DEPARTMENT D,MANAGER M,WORK_SHIFT S,SAL_GRADE G,ADDRESS A,COUNTRY C WHERE M.DEPARTMENTID=D.DEPARTMENTID AND M.SHIFT_ID=S.SHIFT_ID AND M.MANAGERSALARY BETWEEN G.LOWSAL AND G.HIGHSAL AND M.ADDRESSID=A.ADDRESSID AND A.COUNTRYCODE=C.COUNTRYCODE;
```


-----------------------------------------------------------------------------------------------------------------------------
### 5. HIGH_SALARY_EMP
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW HIGH_SALARY_EMP AS SELECT UPPER(E.EMPLOYEENAME) AS EMPLOYEENAME,E.EMPLOYEESALARY,UPPER(D.DEPARTMENTNAME) AS DEPARTMENTNAME,M.MANAGERNAME,UPPER(J.JOBNAME) AS JOBNAME,S.SHIFT_NAME,G.GRADE FROM EMPLOYEE E,DEPARTMENT D,MANAGER M,JOB J,WORK_SHIFT S,SAL_GRADE G,ADDRESS A,COUNTRY C WHERE E.DEPARTMENT_ID=D.DEPARTMENTID AND E.MANAGER_ID=M.MANAGERID AND E.JOB_ID=J.JOBID AND E.SHIFT_ID=S.SHIFT_ID AND E.EMPLOYEESALARY BETWEEN G.LOWSAL AND G.HIGHSAL AND E.ADDRESS_ID=A.ADDRESSID AND A.COUNTRYCODE=C.COUNTRYCODE AND E.EMPLOYEESALARY>(SELECT AVG(EMPLOYEESALARY) FROM EMPLOYEE);
```


-----------------------------------------------------------------------------------------------------------------------------
### 6. LOWER_SALARY_EMP
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW LOWER_SALARY_EMP AS SELECT UPPER(E.EMPLOYEENAME) AS EMPLOYEENAME,E.EMPLOYEESALARY,UPPER(D.DEPARTMENTNAME) AS DEPARTMENTNAME,M.MANAGERNAME,UPPER(J.JOBNAME) AS JOBNAME,S.SHIFT_NAME,G.GRADE FROM EMPLOYEE E,DEPARTMENT D,MANAGER M,JOB J,WORK_SHIFT S,SAL_GRADE G,ADDRESS A,COUNTRY C WHERE E.DEPARTMENT_ID=D.DEPARTMENTID AND E.MANAGER_ID=M.MANAGERID AND E.JOB_ID=J.JOBID AND E.SHIFT_ID=S.SHIFT_ID AND E.EMPLOYEESALARY BETWEEN G.LOWSAL AND G.HIGHSAL AND E.ADDRESS_ID=A.ADDRESSID AND A.COUNTRYCODE=C.COUNTRYCODE AND E.EMPLOYEESALARY<(SELECT AVG(EMPLOYEESALARY) FROM EMPLOYEE);

```


-----------------------------------------------------------------------------------------------------------------------------
### 7. EMP_PER_MANAGER
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW EMP_PER_MANAGER AS SELECT M.MANAGERNAME,COUNT(E.EMPLOYEEID) AS NO_OF_EMP FROM MANAGER M,EMPLOYEE E WHERE E.MANAGER_ID=M.MANAGERID GROUP BY M.MANAGERNAME ;
```


-----------------------------------------------------------------------------------------------------------------------------
### 8. AVG_MAX_MIN_SAL_EMP
-----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE VIEW AVG_MAX_MIN_SAL_EMP AS SELECT D.DEPARTMENTNAME,AVG(EMPLOYEESALARY) AS AVG_SALARY,MAX(EMPLOYEESALARY) AS MAX_SALARY,MIN(EMPLOYEESALARY) AS MIN_SALARY,COUNT(E.EMPLOYEEID) AS NO_OF_EMP FROM EMPLOYEE E,DEPARTMENT D WHERE E.DEPARTMENT_ID=D.DEPARTMENTID GROUP BY D.DEPARTMENTNAME;
```

[1. SHIFT WISE MANAGER]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#1-shift_wise_manager>
[2. DEPT WISE EMPLOYEE]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#2--dept_wise_emp>
[3. EMPLOYEE INFORMATION]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#3-employee_information>
[4. MANAGER INFORMATION]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#4-manager_information>
[5. HIGH SALARY EMPLOYEE]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#5-high_salary_emp>
[6. LOWER SALARY EMPLOYEE]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#6-lower_salary_emp>
[7. EMPLOYEE PER MANAGER]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#7-emp_per_manager>
[8. AVG MAX MIN SALARY EMPLOYEE]: <https://github.com/Prosen-Ghosh/PL_SQL_C_Sharp_Project/blob/master/View.md#8-avg_max_min_sal_emp>
