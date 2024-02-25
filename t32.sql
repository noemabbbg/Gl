SELECT 
    substr(NAME, 1, instr(NAME, ' ') - 1) AS Lastname,
    COUNT(*) AS NumTwos
FROM students
WHERE MARK = 2
GROUP BY substr(NAME, 1, instr(NAME, ' ') - 1);
