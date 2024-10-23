def generate_and_execute_code(template, values):

    code = template.format(**values)
    try:
        exec(code)
    except Exception as e:
        print(f"Błąd wykonania: {e}")


template = """
def dynamic_function(x):
    return x + {increment}
print(dynamic_function({value}))
"""

values = {"increment": 5, "value": 10}
generate_and_execute_code(template, values)
