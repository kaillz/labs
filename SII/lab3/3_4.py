import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)
print(dataframe[dataframe['integer'] == 6].head(10))