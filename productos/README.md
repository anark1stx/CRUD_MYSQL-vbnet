#PWEASE IGNORE THIS IS TERRIBLE JUST NOTES XD
# EL COMETIDO DE ESTE SUB-PROYECTO ES CREAR UN PROGRAMA CAPAZ DE CONSEGUIR DATOS DE PRODUCTOS PUBLICADOS EN INTERNET.

# DE MOMENTO NO TIENE MAYOR IMPORTANCIA PERO SERÁ ÚTIL PARA POBLAR BASES DE DATOS DE MANERA RÁPIDA CUANDO SE REQUIERA EN EL FUTURO.

# POSIBLES LENGUAJES: PYTHON. 

# RECURSOS: https://github.com/martincrb/pokemon_battle_system_yt/blob/video_4/pokemon_scraper.py ; https://www.youtube.com/watch?v=_opDs6UPDyo ; https://www.youtube.com/watch?v=m4hEAhHHykI

# EL ULTIMO TIENE UNA EXPLICACIÓN Y APLICACIÓN EXCELENTE.

# USAREMOS EBAY.COM COMO TARGET DE SCRAPPING.

# Lógica: El scrapper visitará el link de busqueda que le proporcionemos, por cada artículo que muestre eBay, los abrirá y conseguira la información que queramos, en este caso: NOMBRE, PRECIO, IMAGEN. (La cantidad la inventamos nosotros).

# Por último exportará toda la información que consiga a un archivo .csv


# CREAR UNA CARPETA POR CADA PRODUCTO, LA CARPETA TENDRÁ UN NOTEPAD CON LAS PROPIEDADES Y EL ARCHIVO.JPG EXTRAÍDO DE LA URL.


# wget a la imagen, guardarla en con el titulo de la publicacion en  .cache, convertirla a blob (binario), reemplazar el string del link en el csv por el blob y luego borrar la carpeta .cache
