def analyze_mixed_data(data):

    numbers = list(filter(lambda x: isinstance(x, (int, float)), data))
    max_number = max(numbers) if numbers else None


    strings = list(filter(lambda x: isinstance(x, str), data))
    longest_string = max(strings, key=len) if strings else None


    tuples = list(filter(lambda x: isinstance(x, tuple), data))
    longest_tuple = max(tuples, key=len) if tuples else None

    return {
        "max_number": max_number,
        "longest_string": longest_string,
        "longest_tuple": longest_tuple
    }


data = [123, "apple", (1, 2), (3, 4, 5), "banana", 456, 789.0]
print(analyze_mixed_data(data))
