import wget
import sys
import re
import os.path


csvdata = open('productos/data/output.csv')
for line in csvdata:
    title_post = line.strip().split('|')[1]
    image_post = line.strip().split('|')[-1]
    str(image_post)
    filen = image_post.strip().split(".com/")[1].strip().split("/")[-1]
    fname, ext = filen.strip().split('.')
    print(title_post + "." + ext)
    filename = wget.download(image_post, "productos/data/images/"+title_post+"."+ext)
csvdata.close()



#url = 'https://i.ebayimg.com/images/g/ZAIAAOSwxzhetbte/s-l300.jpg'


#foldername = url.strip().split("https://i.ebayimg.com/images/g/")[1].split("/")[1]







