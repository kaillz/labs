import pandas as pd
import numpy as np

# Создать диапазон дат
time_index = pd.date_range('06/06/2017', periods=100000, freq='30S')

# Создать фрейм данных
dataframe = pd.DataFrame(index=time_index)

# Создать столбец случайных значений
dataframe['Sale_Amount'] = np.random.randint(1, 10, 100000)
print(dataframe)
# Сгруппировать строки по неделе, вычислить сумму за неделю
print(dataframe.resample('W').sum())
# Показать три строки
print(dataframe.head(3))

# Сгруппировать по двум неделям, вычислить среднее
print(dataframe.resample('2W').mean())

print(dataframe.resample('M').count())

print(dataframe.resample('M', label='left').count())