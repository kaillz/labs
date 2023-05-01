import pandas as pd
import xlsxwriter
import numpy as np

dataframe = pd.DataFrame()
dataframe['Имя'] = ['Джеки Джексон', 'Стивен Стивенсон']
dataframe['Возраст'] = [38, 25]
dataframe['Водитель'] = [True, False]
dataframe['Автомобиль'] = ['Honda','TOyota']

A = 2
i=0
while (i < A):
    name = input('Введитн имя: ')
    age = input('Возраст: ')
    carlicens = input('Права: ')
    car = input('Автомобиль: ')
    new_person = pd.Series([name, age, carlicens, car],
                        index=['Имя','Возраст','Водитель','Автомобиль'])
    dataframe = pd.concat([dataframe, pd.DataFrame([new_person])], ignore_index=True)
    i += 1


writer = pd.ExcelWriter('Write.xlsx',engine='xlsxwriter')
dataframe.to_excel(writer, sheet_name='Sheet')
writer.close()



print(dataframe)

print(dataframe.head(-1))
print(dataframe.shape)
print(dataframe.describe())