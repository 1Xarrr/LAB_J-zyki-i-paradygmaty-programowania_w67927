def validate_and_execute(matrix_op):

    allowed_operations = {"add", "multiply", "transpose"}


    matrices = {
        "A": [[1, 2], [3, 4]],
        "B": [[5, 6], [7, 8]]
    }


    def add_matrices(A, B):
        return [[A[i][j] + B[i][j] for j in range(len(A[0]))] for i in range(len(A))]


    def multiply_matrices(A, B):
        result = [[0] * len(B[0]) for _ in range(len(A))]
        for i in range(len(A)):
            for j in range(len(B[0])):
                for k in range(len(B)):
                    result[i][j] += A[i][k] * B[k][j]
        return result


    def transpose_matrix(A):
        return [[A[j][i] for j in range(len(A))] for i in range(len(A[0]))]


    try:
        if "add" in matrix_op:
            result = add_matrices(matrices["A"], matrices["B"])
        elif "multiply" in matrix_op:
            result = multiply_matrices(matrices["A"], matrices["B"])
        elif "transpose" in matrix_op:
            matrix = matrices[matrix_op.split()[1]]
            result = transpose_matrix(matrix)
        else:
            raise ValueError("Niedozwolona operacja.")

        return result
    except Exception as e:
        return f"Błąd wykonania: {e}"



print(validate_and_execute("add"))
print(validate_and_execute("multiply"))
print(validate_and_execute("transpose A"))
