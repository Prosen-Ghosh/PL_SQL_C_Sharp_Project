# CREATE TABLE
---------------------------------------------------------------------------------------------------------------------------
### 1. USER_CONTROL
----------------------------------------------------------------------------------------------------------------------------

```sql
CREATE TABLE user_control(
	userid number(10) NOT NULL,
	password varchar2(50) NOT NULL,
	usertype varchar2(50) NOT NULL,
	CONSTRAINT user_pk PRIMARY KEY (userid)
);
```
---------------------------------------------------------------------------------------------------------------------------
### 2. ADMIN
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE admin(
	adminid number(10) NOT NULL,
	adminname varchar2(50) NOT NULL,
	adminpassword varchar2(50) NOT NULL,
	adminemail varchar2(50) NOT NULL,
	admingender varchar2(10) NOT NULL,
	adminphoneno varchar2(20) NOT NULL,
	CONSTRAINT admin_pk PRIMARY KEY (adminid)
);
```
---------------------------------------------------------------------------------------------------------------------------
### 3. DEPARTMENT
----------------------------------------------------------------------------------------------------------------------------
CREATE TABLE department(
	departmentid number(10) NOT NULL,
	departmentname varchar2(50) NOT NULL,
	CONSTRAINT department_pk PRIMARY KEY (departmentid)
);
---------------------------------------------------------------------------------------------------------------------------
### 4. JOB
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE job(
	jobid number(10) NOT NULL,
	jobname varchar2(50) NOT NULL,
	highsal number(10) NOT NULL,
	lowsal number(10) NOT NULL,
	CONSTRAINT job_pk PRIMARY KEY (jobid)
);
```
---------------------------------------------------------------------------------------------------------------------------
### 5. SAL_GRADE
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE sal_grade(
	grade varchar2(10) NOT NULL,
	highsal number(10) NOT NULL,
	lowsal number(10) NOT NULL,
	CONSTRAINT sal_grade_pk PRIMARY KEY (grade)
);
```
---------------------------------------------------------------------------------------------------------------------------
### 6. COUNTRY
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE country(
	countrycode number(10) NOT NULL,
	countryname varchar2(50) NOT NULL,
	CONSTRAINT country_pk PRIMARY KEY (countrycode)
);

insert into country values(880,'BANGLADESH');
```
---------------------------------------------------------------------------------------------------------------------------
### 7. ADDRESS
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE address(
	addressid number(10) NOT NULL,
	countrycode number(10) NOT NULL,
	division varchar2(50) NOT NULL,
	city varchar2(50) NOT NULL,
	CONSTRAINT address_pk PRIMARY KEY (addressid),
	CONSTRAINT fk_country FOREIGN KEY (countrycode) REFERENCES country(countrycode)
);

insert into address values(1000,880,'DHAKA','MYMENSINGH');

```
---------------------------------------------------------------------------------------------------------------------------
### 8. WORK_SHIFT
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE work_shift (
	shift_id number(10) NOT NULL,
	shift_name varchar2(20) NOT NULL,
	shift_starting_hour number(10) NOT NULL,
	shift_ending_hour number(10) NOT NULL,
	CONSTRAINT work_shift_pk PRIMARY KEY (shift_id)
);

```
---------------------------------------------------------------------------------------------------------------------------
### 9. MANAGER
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE manager(
	managerid number(10) NOT NULL,
	managername varchar2(50) NOT NULL,
	managerpassword varchar2(50) NOT NULL,
	manageremail varchar2(50) NOT NULL,
	managerphone varchar2(50) NOT NULL,
	managergender varchar2(10) NOT NULL,
	managerhiredate DATE NOT NULL,
	managersalary number(10) NOT NULL,
	departmentid number(10) NOT NULL,
	jobid number(10) NOT NULL,
	addressid number(10) NOT NULL,
	shift_id number(10) NOT NULL,
	CONSTRAINT manager_pk PRIMARY KEY (managerid),
	CONSTRAINT fk_department FOREIGN KEY (departmentid) REFERENCES department(departmentid),
	CONSTRAINT fk_job FOREIGN KEY (jobid) REFERENCES job(jobid),
	CONSTRAINT fk_address FOREIGN KEY (addressid) REFERENCES address(addressid),
	CONSTRAINT fk_work_shift FOREIGN KEY (shift_id) REFERENCES work_shift(shift_id)
);

insert into manager values(10000,'RIZVE','321','rizve_rock@yahoo.com','01678173287','Male',sysdate,1700000,10,100,1000);

```
---------------------------------------------------------------------------------------------------------------------------
### 10. EMPLOYEE
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE employee(
	employeeid number(10) NOT NULL,
	employeename varchar2(50) NOT NULL,
	employeeemail varchar2(50) NOT NULL,
	employeephone varchar2(50) NOT NULL,
	employeegender varchar2(10) NOT NULL,
	employeehiredate DATE NOT NULL,
	employeesalary number(10) NOT NULL,
	employeecommission number(10) NOT NULL,
	department_id number(10) NOT NULL,
	manager_id number(10) NOT NULL,
	job_id number(10) NOT NULL,
	address_id number(10) NOT NULL,
	shift_id number(10) NOT NULL,
	CONSTRAINT employee_pk_id PRIMARY KEY (employeeid),
	CONSTRAINT employee_fk_department FOREIGN KEY (department_id) REFERENCES department(departmentid),
	CONSTRAINT employee_fk_job FOREIGN KEY (job_id) REFERENCES job(jobid),
	CONSTRAINT employee_fk_address FOREIGN KEY (address_id) REFERENCES address(addressid),
	CONSTRAINT employee_fk_manager FOREIGN KEY (manager_id) REFERENCES manager(managerid),
	CONSTRAINT employee_fk_work_shift FOREIGN KEY (shift_id) REFERENCES work_shift(shift_id)
);

```
---------------------------------------------------------------------------------------------------------------------------
### 11. CURRENT_LOGEDIN_TABLE
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE current_logedin_table(
	user_id number(10) NOT NULL,
	user_type varchar2(20) NOT NULL
);
```
---------------------------------------------------------------------------------------------------------------------------
### 12. WORK_SHIFT
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE work_shift (
	shift_id number(10) NOT NULL,
	shift_name varchar2(20) NOT NULL,
	shift_starting_hour number(10) NOT NULL,
	shift_ending_hour number(10) NOT NULL,
	CONSTRAINT work_shift_pk PRIMARY KEY (shift_id)
);
```
---------------------------------------------------------------------------------------------------------------------------
### 13. SAL_UPDATE_LOG
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE sal_update_log (
	performed_date DATE NOT NULL,
	performed_time varchar2(12) NOT NULL,
	user_id number(10) NOT NULL,
           user_type varchar2(20) NOT NULL,
	old_sal number(10) NOT NULL,
	new_sal number(10) NOT NULL,
	performed_by number(10) NOT NULL,
	performer_type varchar2(12) NOT NULL
);
```
---------------------------------------------------------------------------------------------------------------------------
### 14. USER_PERFORM_LOG
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE user_perform_log (
	performed_date DATE NOT NULL,
	performed_time varchar2(12) NOT NULL,
	operation_performed varchar2(12) NOT NULL,
	performed_table_name varchar2(12) NOT NULL,
	performer_id number(10) NOT NULL,
	performer_type varchar2(12) NOT NULL
);
```
---------------------------------------------------------------------------------------------------------------------------
### 15. FIRED_EMPLOYEE_LOG
----------------------------------------------------------------------------------------------------------------------------
```sql
CREATE TABLE FIRED_EMPLOYEE_LOG(
	ID NUMBER(10),
	TYPE VARCHAR2(20),
	NAME VARCHAR2(20),
	EMAIL VARCHAR2(20),
	PHONE_NO VARCHAR2(20),
	GENDER VARCHAR2(20),
	HIRE_DATE VARCHAR2(20),
	FIRED_DATE VARCHAR2(20),
	SALARY NUMBER(10),
	DEPARTMENT_ID NUMBER(10),
	JOB_ID NUMBER(10),
	ADDRESS_ID NUMBER(10),
	SHIFT_ID NUMBER(10),
	PERFORMER_ID NUMBER(10),
	PERFORMER_TYPE VARCHAR2(20)
);
```




