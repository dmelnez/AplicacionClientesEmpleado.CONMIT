using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal class EmpleadoOperativaImplementacion : EmpleadoOperativaInterfaz
    {
        public void mostrarCliente(List<AltaCliente> listaClientes)
        {

            foreach (AltaCliente clientes in listaClientes)
            {
                Console.WriteLine(clientes.ToString());
            }
        }


        public void borrarCliente(List<AltaCliente> listaClientes)
        {

            Console.WriteLine("DNI CLIENTE A BORRAR");
            string dniABorrar = Console.ReadLine();

            foreach (AltaCliente clienteABorrar in listaClientes)
            {

                if (clienteABorrar.DniCliente.Equals(dniABorrar) == true)
                {


                    listaClientes.Remove(clienteABorrar);

                    Console.WriteLine("########################################");
                    Console.WriteLine("# [INFO] - Cliente eliminado con Exito #");
                    Console.WriteLine("########################################");
                    break;
                }

                else
                {
                    Console.WriteLine("##################################################################");
                    Console.WriteLine("# [ATENCION] - El DNI especificado no pertenece a ningun cliente #");
                    Console.WriteLine("##################################################################");
                }

            }

        }
    }
}
