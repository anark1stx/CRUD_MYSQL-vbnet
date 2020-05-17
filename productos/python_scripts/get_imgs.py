import wget
import sys

import csv

with open('../data/output.csv', newline='') as f:
    reader = csv.reader(f)
    data = list(reader)

for list_item in data:
    str(list_item)
    print(type(list_item))


#url = 'https://i.ebayimg.com/images/g/ZAIAAOSwxzhetbte/s-l300.jpg'
#filename = wget.download(url, out)

#foldername = url.strip().split("https://i.ebayimg.com/images/g/")[1].split("/")[1]







