import pandas as pd

url = 'https://tinyurl.com/simulated-json'
dataframe = pd.read_json (url, orient=' columns')

print(dataframe.head(2))