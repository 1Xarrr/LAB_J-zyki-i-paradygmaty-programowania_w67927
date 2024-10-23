from functools import reduce
import numpy as np

def matrix_operations(matrices, operation):
    if operation == "add":
        return reduce(lambda x, y: x + y, matrices)
    elif operation == "multiply":
        return reduce(lambda x, y: np.dot(x, y), matrices)
    else:
        raise ValueError("Nieznana operacja.")


matrices = [np.array([[1, 2], [3, 4]]), np.array([[5, 6], [7, 8]])]
print(matrix_operations(matrices, "add"))
print(matrix_operations(matrices, "multiply"))
