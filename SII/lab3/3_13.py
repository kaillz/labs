import pandas as pd

# Создать URL-адрес
employee_data = {'Sex': ['male', 'male', 'female', 'female'],
                 'name': ['Amy Jones', 'Allen Keys', 'Alice Bees','Tim Horton'], 
                 'Age':['20','35','22','44'], 'Survived':['yes','yes','no','no']}
dataframe = pd.DataFrame(employee_data, columns = ['Sex', 'name', 'Age', 'Survived'])


# Сгруппировать строки по значениям столбца 'Sex', вычислить среднее
# каждой группы
dataframe.groupby('Sex').mean()

# Сгруппировать строки
dataframe.groupby('Sex')

# Сгруппировать строки, подсчитать строки
dataframe.groupby('Survived')['name'].count()

# Сгруппировать строки, вычислить среднее
dataframe.groupby(['Sex','Survived'])['Age'].mean()