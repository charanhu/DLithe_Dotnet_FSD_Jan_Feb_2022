--PRIMARY KEY
CREATE TABLE DEPT
(
DNO INT PRIMARY KEY,
DNAME VARCHAR(25)
)
--INSERT (DEPT TABLE)
INSERT INTO DEPT VALUES(1, 'HR');
INSERT INTO DEPT VALUES(2, 'DOTNET');
INSERT INTO DEPT VALUES(3, 'JAVA');

--SELECT (DEPT TABLE)
SELECT * FROM DEPT;
--FOREIGN KEY(DEPT-EMP)
CREATE TABLE EMP
(
EID INT PRIMARY KEY,
ENAME VARCHAR(25),
DNO INT FOREIGN KEY REFERENCES DEPT(DNO)
);
--INSERT (EMP TABLE)
INSERT INTO EMP VALUES(1001,'CHARAN',1);
INSERT INTO EMP VALUES(1002,'VENKATESH',10);
--Msg 547, Level 16, State 0, Line 23
--The INSERT statement conflicted with the FOREIGN KEY constraint "FK__EMP__DNO__4BAC3F29". The conflict occurred in database "DLithe", table "dbo.DEPT", column 'DNO'.
--The statement has been terminated.
INSERT INTO EMP VALUES(1003,'KARTHIK',2);
INSERT INTO EMP VALUES(1004,'YASHASH',3);
--SELECT
SELECT * FROM EMP;

--CHEK CONSTRAIT
CREATE TABLE PROJECT
(
PRJNO INT PRIMARY KEY,
PRJNAME VARCHAR(25) CHECK(PRJNAME LIKE 'P1%'),
PRJCLIENT VARCHAR(25) DEFAULT 'ABC'
);
--INSERT INTO PROjECT
INSERT INTO PROJECT VALUES(1,'abc','abc');
--Msg 547, Level 16, State 0, Line 40
--The INSERT statement conflicted with the CHECK constraint "CK__PROJECT__PRJNAME__4E88ABD4". The conflict occurred in database "DLithe", table "dbo.PROJECT", column 'PRJNAME'.
--The statement has been terminated.
INSERT INTO PROJECT VALUES(1,'P1001','TE');
INSERT INTO PROJECT VALUES(1,'P1001');
--Msg 213, Level 16, State 1, Line 45
--Column name or number of supplied values does not match table definition.
INSERT INTO PROJECT(PRJNO,PRJNAME) VALUES(2,'P1002');
SELECT * FROM PROJECT;

--UNIQUE
CREATE TABLE DLITHE_TRAINEES
(
TID INT PRIMARY KEY,
TNAME VARCHAR(30) UNIQUE,
TSALARY INT DEFAULT 35000,
TADDRESS VARCHAR(50) NOT NULL,
TDEPT VARCHAR(10) CHECK(TDEPT LIKE 'DIT%')
)
--INSERT
INSERT INTO DLITHE_TRAINEES VALUES(10, 'CHARAN', 1000000,'SHIVAMOGGA','DIT01');
SELECT * FROM DLITHE_TRAINEES;
INSERT INTO DLITHE_TRAINEES VALUES(20, 'KIRAN', 7000000,'PUNE','DIT01');
INSERT INTO DLITHE_TRAINEES VALUES(40, 'KIRAN', 7000000,'PUNE','DIT01');
--Msg 2627, Level 14, State 1, Line 64
--Violation of UNIQUE KEY constraint 'UQ__DLITHE_T__F993FD0B3975BA7D'. Cannot insert duplicate key in object 'dbo.DLITHE_TRAINEES'. The duplicate key value is (KIRAN).
--The statement has been terminated.
INSERT INTO DLITHE_TRAINEES(TID, TNAME, TADDRESS, TDEPT) VALUES(30, 'VENKATESH','HYDERABHAD','DIT02');
SELECT * FROM DLITHE_TRAINEES;