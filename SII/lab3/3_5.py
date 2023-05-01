import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe['integer'].replace("5","6").head(2))