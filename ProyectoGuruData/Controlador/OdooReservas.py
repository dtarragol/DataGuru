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
    archivo_xml = ET.parse('C:/Users/kater/OneDrive/Documentos/NET_PROD4/DataGuru/ProyectoGuruData/Controlador/Reservas.xml')
    xml = archivo_xml.getroot()
    for i in xml.findall('Reserva'):
        do_write = models.execute(DB,uid,PASS,'x_reserva','create',[{
            'x_studio_x_id': i.get('Id'),
            'x_studio_reserva_x_cliente': i.get('ReservaxCliente'),
            'x_studio_x_fecha_hora': i.get('FechayHora'),
            'x_studio_x_estado': i.get('Estado'),
            'x_studio_x_cliente': i.get('Cliente'),
            'x_studio_x_actividad': i.get('Actividad'),
            }])
    print('Las reservas se han cargado correctamente')
else:
    print('Error en conexión')