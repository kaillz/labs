import numpy as np

matrix = np.array([[1, 2, 3],
                   [2, 4, 6],
                   [3, 8, 9]])

print(matrix.diagonal())
print(matrix.diagonal(offset=1))
print(matrix.diagonal(offset=-1))
