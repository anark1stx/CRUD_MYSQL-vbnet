import requests
from bs4 import BeautifulSoup

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
        title = soup.find('h1', id='itemTitle').find('a').get('data-mtdes')
    except:
        title=''
    try:
        p = soup.find('span', id="prcIsum").text.strip()
        currency, price=p.split('$')
    except:
        currency = ''
        price = ''

    try:
        img = soup.find('img', id='icImg').get('src')
    except:
        img=''

    #print('Producto: ' + title + ' Precio: ' + price + ' image URL: ' + img)
    data = {
        'titulo': title,
        'precio': price,
        'img': img
    }
    return data


def main():
    url ='https://www.ebay.com/itm/Intel-Core-i7-Laptop-Max-Support-16GB-512GB-1TB-1080P-Win10-notebook-Computer/392618812553?hash=item5b69e7a489:m:mjiSnpr-EAaqEDhNnoyxKBA'
    get_detail_data(get_page(url))

if __name__ == '__main__':
    main()
