USE privateschool;

CREATE TABLE students
(
id           INTEGER NOT NULL ,
firstname    VARCHAR(50) NOT NULL ,
lastname     VARCHAR(50) NOT NULL ,
dateofbirth  DATE NOT NULL ,
tuitionfees  FLOAT NOT NULL ,

 CONSTRAINT pk_students PRIMARY KEY (id)
);

