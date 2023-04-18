using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuruData.ModeloBBDD
{
    internal class ListaEspera : Reservas
    {
        private List<Reservas> reservasEnEspera;

        public ListaEspera() : base()
        {
            reservasEnEspera = new List<Reservas>();
        }

        public void eliminarReservaPendiente(Reservas reserva)
        {
            reservasEnEspera.Remove(reserva);
        }

        public void mostrarReservasPendientesPorCliente(string idCliente)
        {
            Console.WriteLine("Reservas en Espera para el Cliente {0}:", idCliente);
            var reservasPorCliente = reservasEnEspera.Where(r => r.ClienteFk == idCliente);
            if (reservasPorCliente.Any())
            {
                foreach (var reserva in reservasPorCliente)
                {
                    Console.WriteLine("- IdReserva: {0}, ClienteFk: {1}, ActividadFk: {2}, FechaHoraReserva: {3}, EstadoReserva: {4}", reserva.IdReserva, reserva.ClienteFk, reserva.ActividadFk, reserva.FechaHoraReserva, reserva.EstadoReserva);
                }
            }
            else
            {
                Console.WriteLine("No hay reservas en espera para el Cliente {0}", idCliente);
            }
        }
    }
}
