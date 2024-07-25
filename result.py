import pandas as pd
import matplotlib.pyplot as plt

# CSVファイルを読み込み
df = pd.read_csv('J_60.csv', header=None)

# 結果を格納する辞書
result = {}

# 7列目が0から35までの各値について処理
for i in range(36):
    if i==0 :
        continue

    subset = df[df[6] == i]  # 7列目がiの行を抽出

    if not subset.empty:
        min_value = subset[4].max()  # 5列目の最大値を見つける
        result[i] = min_value  # 結果を辞書に格納
    else:
        result[i] = None  # もし該当する行がない場合、Noneを格納


    

# 結果を表示
for key, value in result.items():
#    print(f'7列目が{key}のときの5列目の最小値は: {value}')
    print(value)

valid_values = [v for v in result.values() if v is not None]
average_value = sum(valid_values) / len(valid_values) if valid_values else None
print(f'5列目最小値の平均値は: {average_value}')


if valid_values:
    valid_values.sort()
    mid = len(valid_values) // 2
    if len(valid_values) % 2 == 0:
        median_value = (valid_values[mid - 1] + valid_values[mid]) / 2
    else:
        median_value = valid_values[mid]
else:
    median_value = None

print(f'5列目最大値の中央値は: {median_value}')