import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'https://dataguru.odoo.com'
DB='dataguru'
USER='khlazovska@uoc.edu'
PASS='Adminpass'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
common.version()

#object = xmlrpc.client.ServerProxy(url+'object')
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
uid = common.authenticate(DB, USER, PASS, {})

if uid:
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Clientes.xml')
    xml = archivo_xml.getroot()
    for i in xml.findall('Cliente'):
        do_write = models.execute_kw(DB,uid,PASS,'x_clientes','create',[{
            'x_studio_x_nif': i.get('NIF'),
            'x_studio_x_nombre': i.get('Nombre'),
            'x_studio_x_telfono': i.get('Teléfono'),
            'x_studio_x_mail': i.get('Mail'),
            'x_studio_x_contrasena': i.get('Contraseña'),
            }])
    print('Los clientes se han cargado correctamente')
else:
    print('Error en conexión')