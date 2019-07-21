USE privateschool;

CREATE TABLE assignments
(
id            INTEGER NOT NULL ,
title         VARCHAR(50) NOT NULL ,
description   VARCHAR(50) NOT NULL ,
subdatetime   DATE,
oralmark      INTEGER,
totalmark     INTEGER,
courseid      INTEGER NOT NULL,

 CONSTRAINT pk_assignments PRIMARY KEY (id),
 CONSTRAINT fk_courseid2 FOREIGN KEY (courseid)  REFERENCES courses(id)
);
