USE BCStudentSystem;

INSERT INTO BCStudents VALUES

	(57789, 'Andrea','Piacqu',(SELECT * FROM Openrowset(BULK 'C:\Users\mphel\OneDrive\Desktop\PRG 281 PROJECT\Images_Students\andrea-piacquadio-student1.jpg',SINGLE_BLOB) as image),'2002-03-11','0446603115','13 berg Avenue',221),
	(57756, 'George','Fall',(SELECT * FROM Openrowset(BULK 'C:\Users\mphel\OneDrive\Desktop\PRG 281 PROJECT\Images_Students\george-fall-student2.jpg',SINGLE_BLOB) as image),'2001-02-11','0116603115','11 Avenue',222),
	(57743, 'Max','Fischer',(SELECT * FROM Openrowset(BULK 'C:\Users\mphel\OneDrive\Desktop\PRG 281 PROJECT\Images_Students\max-fischer-studenrt3.jpg',SINGLE_BLOB)as image),'2000-11-15','0476603215','22 Platinum Street',223),
	(57723, 'Mikhali','Nilov',(SELECT * FROM Openrowset(BULK 'C:\Users\mphel\OneDrive\Desktop\PRG 281 PROJECT\Images_Students\mikhail-nilov-student4.jpg',SINGLE_BLOB)as image),'2002-05-24','0886603115','45 RandsVill Street',224),
	(57718, 'Ridna','Sock',(SELECT * FROM Openrowset(BULK 'C:\Users\mphel\OneDrive\Desktop\PRG 281 PROJECT\Images_Students\rdne-stock-student5.jpg',SINGLE_BLOB)as image),'2002-03-28','0876603115','138 CapeVille Street',225);


GO

USE BCStudentSystem;

INSERT INTO BCModules VALUES

	(221,'SFTW', 'Software Testing','https://www.youtube.com/watch?v=E2t5XbWwj7I&list=PLL34mf651faM_nn8uKlnwbQPw5zSh_F84'  ),
	(223,'WPR', 'Web Programming','https://www.youtube.com/watch?v=RjHflb-QgVc&list=PLoYCgNOIyGAB_8_iq1cL8MVeun7cB6eNc'  ),
	(222,'PRG', 'Programming','https://www.youtube.com/watch?v=hMMTnoYFNqg&list=PLUtTaqnx2RJLf3qbrynBpNZsJls-nQ998'  ),
	(224,'', 'Software Testing','https://www.youtube.com/watch?v=6Iu45VZGQDk&list=PLBlnK6fEyqRi_CUQ-FXxgzKQ1dwr_ZJWZ'  ),
	(225,'DBD', 'Database Development','https://www.youtube.com/watch?v=6Iu45VZGQDk&list=PLBlnK6fEyqRi_CUQ-FXxgzKQ1dwr_ZJWZ' )

GO


USE BCStudentSystem;

INSERT INTO StudentModule VALUES

	(221, 57789, 70 ),
	(223, 57789, 80),
	(224, 57789, 83),
	(222, 57789 , 94)









