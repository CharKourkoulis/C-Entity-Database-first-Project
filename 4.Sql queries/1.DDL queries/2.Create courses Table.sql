USE privateschool;



CREATE TABLE courses
(
id          INTEGER NOT NULL,
title       VARCHAR(30) NOT NULL,
type		VARCHAR(50) NOT NULL,
stream      VARCHAR(30) NOT NULL,
start_date  DATE NOT NULL,
end_date    DATE NOT NULL,

CONSTRAINT pk_course PRIMARY KEY(id)
);