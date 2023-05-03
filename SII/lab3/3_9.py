import pandas as pd
import numpy as np

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print(dataframe[dataframe['integer'].isnull()].head(2))
dataframe['integer'] = dataframe['integer'].replace('111111', np.nan)
