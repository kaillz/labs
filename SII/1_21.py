import numpy as np

np.random.seed(0)
print(np.random.random(3))
print(np.random.randint(0, 11, 3))
print(np.random.normal(0.0, 1.0, 3))
print(np.random.logistic(0.0, 1.0, 3))
print(np.random.uniform(1.0, 2.0, 3))
