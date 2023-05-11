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
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Actividades.xml')
    xml = archivo_xml.getroot()
    for i in xml.findall('Actividad'):
        do_write = models.execute(DB,uid,PASS,'x_actividad','create',[{
            'x_studio_x_id': i.get('Id'),
            'x_studio_x_tipo_de_actividad': i.get('Tipo'),
            'x_studio_x_hora': i.get('Hora'),
            'x_studio_x_dia_semana': i.get('DiaSemana'),
            'x_studio_x_plazas': i.get('Plazas'),
            }])
    print('Las actividades se han cargado correctamente')
else:
    print('Error en conexión')