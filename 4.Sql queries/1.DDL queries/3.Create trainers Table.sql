USE privateschool;

CREATE TABLE trainers
(
id          INTEGER NOT NULL,
firstname   VARCHAR(30) NOT NULL,
lastname    VARCHAR(30) NOT NULL,
subject     VARCHAR(50),
courseid    INTEGER,

CONSTRAINT pk_trainer PRIMARY KEY (id),
CONSTRAINT fk_courseid1 FOREIGN KEY (courseid) REFERENCES courses(id)
);
