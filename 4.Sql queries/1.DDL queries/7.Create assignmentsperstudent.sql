USE privateschool;

CREATE TABLE assignmentsperstudent
(
studentid     INTEGER NOT NULL ,
assignid      INTEGER NOT NULL ,

 CONSTRAINT pk_assignmentsperstudent PRIMARY KEY (studentid,assignid),
 CONSTRAINT fk_student_id2 FOREIGN KEY (studentid)  REFERENCES students(id),
 CONSTRAINT fk_assign_id2 FOREIGN KEY (assignid)  REFERENCES assignments(id)
);