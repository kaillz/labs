import pandas as pd

url = 'https://tinyurl.com/simulated-data'
dataframe = pd.read_csv(url)

print('Максимум:', dataframe['integer'].max())
print('Минимум:', dataframe['integer'].min())
print('Среднее:', dataframe['integer'].mean())
print('Сумма:', dataframe['integer'].sum())
print('Количество:', dataframe['integer'].count())
