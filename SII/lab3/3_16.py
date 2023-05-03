import pandas as pd

# оздать URL-адрес
url = 'https://tinyurl.com/simulated-data'

# Загрузить данные
dataframe = pd.read_csv(url)

employee_data = {'employee_id': ['1', '2', '3', '4'],
                 'name': ['Amy Jones', 'Allen Keys', 'Alice Bees',
                          'Tim Horton']}
dataframe_employees = pd.DataFrame(employee_data, columns = ['employee_id',
                                                             'name'])
# Создать функцию
def uppercase(x):
    return x.upper()

# Применить функцию, показать две строки
print(dataframe_employees['name'].apply(uppercase)[0:2])