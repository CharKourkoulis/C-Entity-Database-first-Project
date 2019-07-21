USE privateschool;


GO
CREATE PROCEDURE students_with_more_courses
AS
SELECT	DISTINCT s.id AS STUDENT_ID, s.firstname AS ONOMA, s.lastname AS EPITHETO
		          
FROM (students s INNER JOIN 
						studentspercourse spc ON s.id = spc.studentid )			
											
WHERE studentid IN (
  SELECT 
   studentid
  FROM studentspercourse
  GROUP BY studentid
  HAVING COUNT(studentid) > 1
);


EXECUTE students_with_more_courses;