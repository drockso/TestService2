-- Drop the existing table (if any)

DROP TABLE RELATIONALTABLE1;

-- Create a new Relational table with 3 columns

CREATE TABLE RELATIONALTABLE1 
(
  Column1 VARCHAR2(255) NOT NULL,
  Column2 VARCHAR2(1024),
  Column3 VARCHAR(2)
);
