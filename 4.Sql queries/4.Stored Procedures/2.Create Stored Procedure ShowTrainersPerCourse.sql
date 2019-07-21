USE privateschool;

GO
CREATE PROCEDURE show_trainers_per_course @courseid INT
AS
 SELECT  t.id AS ID_TRAINER, t.firstname AS ONOMA, t.lastname AS EPITHETO, c.id AS COURSE_ID, c.title AS TITLOS_COURSE, c.stream AS DIARKEIA_COURSE
 FROM (trainers t INNER JOIN courses c ON t.courseid = c.id)  
 WHERE  t.courseid = @courseid;
GO



EXECUTE show_trainers_per_course @courseid = '11';
EXECUTE show_trainers_per_course @courseid = '12';
EXECUTE show_trainers_per_course @courseid = '21';
EXECUTE show_trainers_per_course @courseid = '22';
EXECUTE show_trainers_per_course @courseid = '31';
EXECUTE show_trainers_per_course @courseid = '32';
