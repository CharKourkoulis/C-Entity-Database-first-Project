USE privateschool;

GO
CREATE PROCEDURE show_assignments_per_course @courseid INT
AS
 SELECT  a.id AS ASSIGNMENT_ID, a.title AS TITLOS_ASSIGNMENT, a.description AS PERIGRAFH_ASSIGNMENT, a.subdatetime AS HMEROMHNIA_YPOVOLIS , 
 c.id AS COURSE_ID, c.title AS TITLOS_COURSE, c.stream AS DIARKEIA_COURSE
 FROM (assignments a INNER JOIN courses c ON a.courseid = c.id)  
 WHERE  a.courseid = @courseid;
 GO


EXECUTE show_assignments_per_course @courseid = '11';
EXECUTE show_assignments_per_course @courseid = '12';
EXECUTE show_assignments_per_course @courseid = '21';
EXECUTE show_assignments_per_course @courseid = '22';
EXECUTE show_assignments_per_course @courseid = '31';
EXECUTE show_assignments_per_course @courseid = '32';
