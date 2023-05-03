import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe.drop_duplicates().head(2))
print(dataframe.drop_duplicates(subset=['integer']))