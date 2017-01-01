# INSERT DATA
```sql
ADD_ADMIN('Rizve','123','rizve@example.com','Male','01678173287');
ADD_ADMIN('Prosen','321','prosen@example.com','Male','01822804168');
ADD_ADMIN('Orko','911','0rko@example.com','Male','01922104264');
```
…………………………………………………………………………………...
```sql
ADD_JOB('Manager',2000000,1500001);
ADD_JOB('Cutting Worker',200000,150001);
ADD_JOB('Sewing Worker',600000,100001);
ADD_JOB('Dyeing Worker',600000,300001);
ADD_JOB('Netting Worker',700000,400001);
ADD_JOB('Supervisor',1000000,600001);
ADD_JOB('Security Guard',200000,120001);
ADD_JOB('Peon',70000,60001);
```
--------------------------------------------------------------------------
```sql
ADD_DEPARTMENT('CUTTING');
ADD_DEPARTMENT('SEWING');
ADD_DEPARTMENT('DYEING');
ADD_DEPARTMENT('NETTING');
ADD_DEPARTMENT('ACCOUNTS');
```
---------------------------------------------------------------------------
```sql
ADD_SAL_GRADE('A',2000000,1500001);
ADD_SAL_GRADE('B',1500000,1000001);
ADD_SAL_GRADE('C',1000000,700001);
ADD_SAL_GRADE('D',700000,400001);
ADD_SAL_GRADE('E',400000,200001);
ADD_SAL_GRADE('F',200000,50001);
```
-----------------------------------------------------------------------
```sql
ADD_COUNTRY(880,'BANGLADESH');
ADD_COUNTRY(91,'INDIA');
ADD_COUNTRY(92,'PAKISTAN');
ADD_COUNTRY(94,'SRI LANKA');
ADD_COUNTRY(975,'BHUTAN');
ADD_COUNTRY(977,'NEPAL');
ADD_COUNTRY(95,'MYANMAR');
```
------------------------------------------------------------------------
```sql
ADD_ADDRESS(880,'DHAKA','DHAKA');
ADD_ADDRESS(880,'DHAKA','FARIDPUR');
ADD_ADDRESS(880,'DHAKA','GAZIPUR');
ADD_ADDRESS(880,'DHAKA','GOPALGANJ');
ADD_ADDRESS(880,'DHAKA','KISHORGONJ');
ADD_ADDRESS(880,'DHAKA','MADARIPUR');
ADD_ADDRESS(880,'DHAKA','MANIKGANJ');
ADD_ADDRESS(880,'DHAKA','MUNSHIGANJ');
```

-------------------------------------------------------------------------
```sql
INSERT INTO WORK_SHIFT VALUES(1,'MORNING',8,18);
INSERT INTO WORK_SHIFT VALUES(2,'NIGHT',20,6);
```
------------------------------------------------------------------------------------------------
```sql
ADD_MANAGER('NEAM','111','neam@example.com','01234152698','Male',700000,100,201,500,1);
ADD_MANAGER('SOHEL','222','sohel@gmail.com','01678951247','Male',1500000,100,200,502,2);
ADD_MANAGER('TUHIN','333','sohel@gmail.com','01678915987','Male',1600000,101,200,503,1);
ADD_MANAGER('TURUN','444','tarun@gmail.com','01678147857','Male',1700000,101,200,503,2);
ADD_MANAGER('RAJIB','555','ragib@gmail.com','01598123657','Male',1500000,102,200,504,1);
ADD_MANAGER('JABED','666','jabed@gmail.com','01785123958','Male',1600000,102,200,504,2);
ADD_MANAGER('SANI','777','sani@gmail.com','01598549874','Male',1800000,103,200,505,1);
ADD_MANAGER('ALAM','888','alam@gmail.com','01880159874','Male',1900000,103,200,506,2);
```
--------------------------------------------------------------------------------------------------------------------------------
```sql
BEGIN
ADD_EMPLOYEE('HRIDOY', 'hridoy@example.com','01710145875','Male',65000,150,100,100001,207,501,1);
ADD_EMPLOYEE('ROFIQ', 'rofiq@example.com','01710141258','Male',66000,200,100,100002,207,503,2);
ADD_EMPLOYEE('MAMUN', 'manun@example.com','01714789665','Male',130000,250,101,100003,206,502,1);
ADD_EMPLOYEE('ATIKUR', 'atikur@example.com','01822159753','Male',125000,150,101,100004,206,505,2);
ADD_EMPLOYEE('ASHIQ', 'ashiq@example.com','01712548795','Male',900000,450,102,100005,205,501,1);
ADD_EMPLOYEE('TASNIM', 'ashiq@example.com','01710895748','Male',800000,300,102,100006,205,503,2);
ADD_EMPLOYEE('SHOUROV', 'shourov@example.com','01710951753','Male',600000,150,103,100007,204,506,1);
ADD_EMPLOYEE('JAMIL', 'jamil@example.com','01710951475','Male',500000,170,103,100008,204,507,2);
END;

```







