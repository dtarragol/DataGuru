using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuruData.ModeloBBDD
{
    public class ListaReservas : Reservas
    {
        private List<Reservas> reservasAceptadas;

        public ListaReservas() : base() 
        {
            reservasAceptadas = new List<Reservas>();
        }

        public void hacerReserva(Reservas reserva)
        {
            reserva.EstadoReserva = "confirmada";
            reservasAceptadas.Add(reserva);
        }

        public void anularReserva(Reservas reserva)
        {
            reserva.EstadoReserva = "cancelada";
            reservasAceptadas.Remove(reserva);
        }

        public void mostrarReservas()
        {
            Console.WriteLine("Reservas Aceptadas:");
            foreach (var reserva in reservasAceptadas)
            {
                Console.WriteLine("- IdReserva: {0}, ClienteFk: {1}, ActividadFk: {2}, FechaHoraReserva: {3}, EstadoReserva: {4}", reserva.IdReserva, reserva.ClienteFk, reserva.ActividadFk, reserva.FechaHoraReserva, reserva.EstadoReserva);
            }
        }

        public void mostrarReservasAceptadasPorCliente(string idCliente)
        {
            Console.WriteLine("Reservas Aceptadas para el Cliente {0}:", idCliente);

            var reservasPorCliente = reservasAceptadas.Where(r => r.ClienteFk == idCliente);

            if (reservasPorCliente.Any())
            {
                foreach (var reserva in reservasPorCliente)
                {
                    Console.WriteLine("- IdReserva: {0}, ClienteFk: {1}, ActividadFk: {2}, FechaHoraReserva: {3}, EstadoReserva: {4}", reserva.IdReserva, reserva.ClienteFk, reserva.ActividadFk, reserva.FechaHoraReserva, reserva.EstadoReserva);
                }
            }
            else
            {
                Console.WriteLine("No hay reservas aceptadas para el Cliente {0}", idCliente);
            }
        }
    }
}
