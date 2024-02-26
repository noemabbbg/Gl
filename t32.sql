SELECT 
    substr(NAME, 1, instr(NAME, ' ') - 1) AS Lastname,
    SUM(CASE WHEN MARK = 2 THEN 1 ELSE 0 END) AS NumDva
FROM students
GROUP BY Lastname;
