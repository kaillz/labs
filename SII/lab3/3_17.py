import pandas as pd

# Создать URL-адрес
url = 'https://tinyurl.com/simulated-data'

# Загрузить данные
dataframe = pd.read_csv(url)

# Сгруппировать строки, применить функцию к группам
print(dataframe.groupby('integer').apply(lambda x: x.count()))
