import re

print('Simple calculator')

print('Type "end" to exit')

previous = 0
run = True

def calculate():
    global run
    global previous
    equation = ""
    if previous ==0:
        equation = input("Enter calculation: ")
    else:
        equation = input(str(previous))

    if equation == "end":
        print("Goodbye")
        run = False
    else:
        equation = re.sub('[a-zA-Z,.:()" "]', '', equation)

    if previous == 0:
        previous = eval(equation)
    else:
        previous = eval(str(previous) + equation)

while run:
    calculate()
