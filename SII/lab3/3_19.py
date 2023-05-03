import pandas as pd

# Создать фрейм данных
employee_data = {'employee_id': ['1', '2', '3', '4'],
                 'name': ['Amy Jones', 'Allen Keys', 'Alice Bees',
                          'Tim Horton']}
dataframe_employees = pd.DataFrame(employee_data, columns = ['employee_id',
                                                             'name'])
# Создать фрейм данных
sales_data = {'employee_id': ['3', '4', '5', '6'],
              'total_sales': [23456, 2512, 2345, 1455]}
dataframe_sales = pd.DataFrame(sales_data, columns = ['employee_id',
                                                      'total_sales'])

# Выполнить слияние фреймов данных

print(pd.merge(dataframe_employees, dataframe_sales, on='employee_id'))


# In[73]:


# Выполнить слияние фреймов данных
print(pd.merge(dataframe_employees, dataframe_sales, on='employee_id', how='outer'))




# Выполнить слияние фреймов данных
print(pd.merge(dataframe_employees, dataframe_sales, on='employee_id', how='left'))



# Выполнить слияние фреймов данных
print(pd.merge(dataframe_employees,
         dataframe_sales,
         left_on='employee_id',
         right_on='employee_id'))