import numpy as np

vector = np.array([1, 2, 3, 4, 5, 6])
matrix = np.array([[1, 2, 3],
                   [4, 5, 6],
                   [7, 8, 9]])
print(vector[2])
print("\n")
print(matrix[1,2])
print("\n")
print(vector[:])
print("\n")
print(vector[:3])
print("\n")
print(vector[3:])
print("\n")
print(vector[-1])
print("\n")
print(matrix[:2, :])
print("\n")
print(matrix[:, 1:2])
