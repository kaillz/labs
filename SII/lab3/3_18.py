import pandas as pd

# Создать фрейм данных
data_a = {'id': ['1', '2', '3'],
          'first': ['Alex', 'Amy', 'Allen'],
          'last': ['Anderson', 'Ackerman', 'Ali']}
dataframe_a = pd.DataFrame(data_a, columns = ['id', 'first', 'last'])

# Создать фрейм данных
data_b = {'id': ['4', '5', '6'],
          'first': ['Billy', 'Brian', 'Bran'],
          'last': ['Bonder', 'Black', 'Balwner']}
dataframe_b = pd.DataFrame(data_b, columns = ['id', 'first', 'last'])

# Конкатенировать фреймы данных построчно
print(pd.concat([dataframe_a, dataframe_b], axis=0))



# Конкатенировать фреймы данных по столбцам
print(pd.concat([dataframe_a, dataframe_b], axis=1))



# Создать строку
row = pd.Series([10, 'Chris', 'Chillon'], index=['id', 'first', 'last'])

dataframe_a = dataframe_a._append(row, ignore_index=True)
print(dataframe_a)