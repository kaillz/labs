import pandas as pd


employee_data = {'employee_id': ['1', '2', '3', '4'],
                 'name': ['Amy Jones', 'Allen Keys', 'Alice Bees',
                          'Tim Horton']}
dataframe = pd.DataFrame(employee_data, columns = ['employee_id',
                                                             'name'])

# Напечатать первые два имени в верхнем регистре
for name in dataframe['name'][0:2]:
    print(name.upper())

# Напечатать первые два имени в верхнем регистре

print([name.upper() for name in dataframe['name'][0:2]])
