import os.path
import requests
import pymysql
import pymysql.cursors

connection = pymysql.connect(user='mateo', password='123', host='localhost', database='item_db') #CHANGE THIS TO YOUR CREDS
mycursor = connection.cursor()  # connect to database

csvdata = open('productos/data/output.csv')

for line in csvdata:

    #GET CSV DATA
    id = line.strip().split('|')[0]
    nombre = line.strip().split('|')[1]
    precio = line.strip().split('|')[2]
    cantidad = line.strip().split('|')[3]
    image_post = line.strip().split('|')[-1]
    str(image_post)
    
        #EN CASO QUE QUERAMOS DESCARGAR EL ARCHIVO CON EL TITULO DE LA PUBLICACION COMO NOMBRE DEL ARCHIVO:

        #filen = image_post.strip().split(".com/")[1].strip().split("/")[-1]
        #fname, ext = filen.strip().split('.')
    
        # metodo wget si queremos descargar las imagenes: filename = wget.download(image_post, "productos/data/images/"+title_post+"."+ext)
        #print(id, nombre, precio, cantidad)

    data=requests.get(image_post) #GET THE IMAGE XD
    photo=data.content #convert it to bitearray

    #query
    sql_insert = """ INSERT INTO item_table (ID, Nombre, Precio, Cantidad, Imagen) VALUES (%s, %s,%s, %s,%s)"""

    mycursor.execute(sql_insert, (id, nombre, precio, cantidad, photo))
    
    connection.commit()  # save to database
csvdata.close() #not needed but jic


#url = 'https://i.ebayimg.com/images/g/ZAIAAOSwxzhetbte/s-l300.jpg' #SAMPLE URL OF IMG'S LINK.
 
