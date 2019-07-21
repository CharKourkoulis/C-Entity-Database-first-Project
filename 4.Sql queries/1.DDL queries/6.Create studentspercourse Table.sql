USE privateschool;

CREATE TABLE studentspercourse
(
studentid        INTEGER NOT NULL ,
courseid         INTEGER NOT NULL ,

 CONSTRAINT  pk_studentspercourse   PRIMARY KEY (studentid,courseid),
 CONSTRAINT  fk_student_id_3        FOREIGN KEY (studentid)  REFERENCES students(id),
 CONSTRAINT  fk_course_id_3         FOREIGN KEY (courseid)  REFERENCES courses(id)
);