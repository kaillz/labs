import pandas as pd

url = 'C:/Users/kaill/Downloads/data.xlsx'
dataframe = pd.read_excel(url, sheet_name=0, header=1)

print(dataframe.head(2))