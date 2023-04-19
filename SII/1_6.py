import numpy as np

matrix = np.array([[1, 2, 3],
                   [4, 5, 6],
                   [7, 8, 9]])


def add_100(i): return i + 100


vectorized_add_100 = np.vectorize(add_100)

print(matrix + 100)
