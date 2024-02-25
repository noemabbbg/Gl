SELECT substr(NAME, 1, instr(NAME, ' ') - 1) AS Lastname
FROM students
GROUP BY Lastname
HAVING MIN(MARK) = 5;
