'''Необходимо написать программу на любом языке программирования
Дана строка состоящая из следующего набора скобок: (, ), {, }, [, ] . Каждой открывающей скобке соответствует закрывающая, образуя пары.Будем считать строку «правильной» если все скобки закрываются в нужном порядке, т.е:
 для каждой открывающей есть закрывающая из той же пары;
скобки закрываются в правильном порядке.
 Пустая строка считается правильной.
// trueisValid('()[]{}')// trueisValid('{[]}')// trueisValid('((()(())))')// falseisValid('(]')// falseisValid('([)]')'''


def is_valid(string):
    stack = []
    b_map = {')': '(', '}': '{', ']': '['}
    for i in string:   
        if i in b_map.values():
            stack.append(i)
        elif i in b_map.keys():
            if len(stack) == 0 or b_map[i] != stack.pop():
                return False
        else:
            return False

    return stack == []

string = "()"
if is_valid(string) == True:
    print(f"(True)Строка правильная: {string}")
else:
    print(f"(False)Строка неправильная: {string}")
