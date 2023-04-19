import numpy as np

matrix = np.array([[1, -1, 3],
                   [1, 1, 6],
                   [3, 8, 9]])

eigenavalues, eigenvrectors = np.linalg.eig(matrix)
print(eigenavalues)
print(eigenvrectors)
