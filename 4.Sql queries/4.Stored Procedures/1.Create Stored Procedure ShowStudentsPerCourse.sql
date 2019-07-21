USE privateschool;

GO
CREATE PROCEDURE show_students_per_course @courseid INT
AS
 SELECT  s.id AS ID_MATHITI, s.firstname AS ONOMA, s.lastname AS EPITHETO, c.id AS COURSE_ID, c.title AS TITLOS_COURSE, c.stream AS DIARKEIA_COURSE
 FROM (students s INNER JOIN studentspercourse spc ON s.id = spc.studentid  
					INNER JOIN courses c ON c.id = spc.courseid)
 WHERE  c.id = @courseid;
GO



EXECUTE show_students_per_course @courseid = '11';
EXECUTE show_students_per_course @courseid = '12';
EXECUTE show_students_per_course @courseid = '21';
EXECUTE show_students_per_course @courseid = '22';
EXECUTE show_students_per_course @courseid = '31';
EXECUTE show_students_per_course @courseid = '32';
