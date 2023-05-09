import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069'
DB='dataguru'
USER='khlazovska@uoc.edu'
PASS='password'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
common.version()

#object = xmlrpc.client.ServerProxy(url+'object')
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
uid = common.authenticate(DB, USER, PASS, {})

if uid:
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Clientes.xml')
    xml = archivo_xml.getroot()
    for i in xml:
        do_write = models.execute(DB,uid,PASS,'x_clientes','create',[{
            'x_studio_x_nif': i[0].text,
            'x_studio_x_nombre': i[1].text,
            'x_studio_x_telfono': i[2].text,
            'x_studio_x_mail': i[3].text,
            'x_studio_x_contrasena': i[4].text,
            }])
    print('Los clientes se han cargado correctamente')
else:
    print('Error en conexión')