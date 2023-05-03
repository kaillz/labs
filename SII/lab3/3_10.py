import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe.drop('integer', axis=1).head(2))
print(dataframe.drop(['integer', 'category'], axis=1).head)
print(dataframe.drop(dataframe.columns[1], axis=1).head(2))