import pandas as pd
import collections

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)
column_names = collections.defaultdict(str)
for name in dataframe.columns:
    column_names[name]

print(column_names)