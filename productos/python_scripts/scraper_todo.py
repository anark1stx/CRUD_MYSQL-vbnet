import requests
from bs4 import BeautifulSoup
import csv
import random 
import os.path

def get_page(url):
    response = requests.get(url)
    if not response.ok:
        print('Server response: ', response.status_code)
    else:
        pass
        soup = BeautifulSoup(response.text, 'lxml')
    return soup


def get_detail_data(soup):
    #titulo
    #precio
    #imagen
    # ESTO DEPENDE DE LA ESTRUCTURA DE LA PÁGINA Y DE LOS DISTINTOS ARTÍCULOS.

    try:
        title = soup.find('h1', id='itemTitle').find('a').get('data-mtdes').replace('"', '')
    except:
        return
    try:
        prc = soup.find('span', id="prcIsum_bidPrice").get('content')
    except:
        return
    try:
        img = soup.find('img', id='icImg').get('src')
    except:
        return
    #print('Producto: ' + title + ' Precio: ' + price + ' image URL: ' + img)
    data = {
        'titulo': title,
        'precio': prc,
        'cantidad': random.randrange(20,100),
        'img': img
    }
    return data

def get_index_data(soup):
    try:
        links = soup.find_all('a', class_='s-item__link')
    except:
        links = []
    urls = [item.get('href') for item in links]
    return urls

def write_csv(data,id):
    with open("productos/data/output.csv", 'a', newline='') as outfile:
        #writer = csv.writer(csvfile, delimiter='|')
        writer = csv.writer(outfile, delimiter='|')
        row = [id, data['titulo'], data['precio'], data['cantidad'], data['img']]
        print(row)
        writer.writerow(row)
        
def main():
    id=0
    url ='https://www.ebay.com/sch/i.html?_nkw=laptop&rt=nc&LH_PrefLoc=3'
    #get_detail_data(get_page(url))
    products = get_index_data(get_page(url))
    for link in products:
        tempdata = get_detail_data(get_page(link))
        if tempdata is not None:
            data = tempdata
            write_csv(data, id)
            id+=1
            #print(data)
    #otro for para descargar las imagenes de cada url.

    
if __name__ == '__main__':
    main()

