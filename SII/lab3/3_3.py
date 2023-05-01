import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)
dataframe = dataframe.set_index(dataframe['datetime'])

# print(dataframe.loc['2015-01-01 00:00:04'])
print(dataframe.iloc[:5])