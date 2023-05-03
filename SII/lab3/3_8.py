import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe['integer'].unique ())
print(dataframe['integer'].value_counts())
print(dataframe['integer'].nunique())