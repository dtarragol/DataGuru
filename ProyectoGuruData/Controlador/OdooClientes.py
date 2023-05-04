import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069/xmlrpc/'
DB='DATAguru'
USER='khlazovska@uoc.edu'
PASS='Animals24'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)
#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Clientes.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_cliente','create',[{
            'x_nif': subraiz[0].text,
            'x_nombre': subraiz[1].text,
            'x_telefono': subraiz[2].text,
            'x_mail': subraiz[3].text,
            'x_contraseña': subraiz[4].text,
            }])
    print('Clientes Cargados correctamente')
else:
    print('Error al conectar a Odoo')