USE privateschool;

GO
CREATE PROCEDURE show_assignments_per_course_per_student @studentid INT
AS
 SELECT  			 
		 a.id AS ASSIGNMENT_ID, a.title AS ASSIGNMENT_TITLE, a.description AS ASSIGNMENT_DESCRIPTION, a.subdatetime AS SUBMISSION_DATE,
		 c.id AS COURSE_ID, c.title AS TITLOS_COURSE, c.stream AS DIARKEIA_COURSE,
		 s.id AS ID_MATHITI, s.firstname AS ONOMA, s.lastname AS EPITHETO
 
 FROM (students s  INNER JOIN
						assignmentsperstudent aps ON s.id = aps.studentid				  
				     INNER JOIN 
						assignments a ON  a.id = aps.assignid
				     INNER JOIN 
						courses c ON c.id = a.courseid)

 WHERE  s.id = @studentid;
GO

--MPOREIS NA VALEIS TO ID OPOIOUDIPOTE MATHITI KAI NA DEIS TA ASSIGNMENTS PER COURSE (id: 1 - 17)
EXECUTE show_assignments_per_course_per_student @studentid = '1';
EXECUTE show_assignments_per_course_per_student @studentid = '2';
EXECUTE show_assignments_per_course_per_student @studentid = '3';
EXECUTE show_assignments_per_course_per_student @studentid = '4';
EXECUTE show_assignments_per_course_per_student @studentid = '5';
EXECUTE show_assignments_per_course_per_student @studentid = '6';
EXECUTE show_assignments_per_course_per_student @studentid = '7';
EXECUTE show_assignments_per_course_per_student @studentid = '8';
EXECUTE show_assignments_per_course_per_student @studentid = '9';
EXECUTE show_assignments_per_course_per_student @studentid = '10';
EXECUTE show_assignments_per_course_per_student @studentid = '11';
EXECUTE show_assignments_per_course_per_student @studentid = '12';
EXECUTE show_assignments_per_course_per_student @studentid = '13';
EXECUTE show_assignments_per_course_per_student @studentid = '14';
EXECUTE show_assignments_per_course_per_student @studentid = '15';
EXECUTE show_assignments_per_course_per_student @studentid = '16';
EXECUTE show_assignments_per_course_per_student @studentid = '17';