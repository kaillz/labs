import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe.head())
print(dataframe.shape)
print(dataframe.describe())