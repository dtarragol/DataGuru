import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'https://dataguru.odoo.com'
DB='dataguru'
USER='khlazovska@uoc.edu'
PASS='password'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
common.version()

#object = xmlrpc.client.ServerProxy(url+'object')
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
uid = common.authenticate(DB, USER, PASS, {})

if uid:
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Actividades.xml')
    xml = archivo_xml.getroot()
    for i in xml:
        do_write = models.execute(DB,uid,PASS,'x_actividades','create',[{
            'x_studio_x_id': i[0].text,
            'x_studio_x_tipo': i[1].text,
            'x_studio_x_hora': i[2].text,
            'x_studio_x_diaSemana': i[3].text,
            'x_studio_x_plazas': i[4].text,
            }])
    print('Las actividades se han cargado correctamente')
else:
    print('Error en conexión')