import numpy as np
matrix = np.array([[1, 2, 3],
                  [4, 5, 6],
                  [7, 8, 9]])

print(np.max(matrix))
print(np.min(matrix))
print(np.max(matrix, axis=0))
print(np.max(matrix, axis=1))
