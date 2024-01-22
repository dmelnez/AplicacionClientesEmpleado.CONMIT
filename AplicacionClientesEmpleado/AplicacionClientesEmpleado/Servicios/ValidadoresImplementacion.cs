using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal class ValidadoresImplementacion : ValidadoresInterfaz
    {

        public void validadorAccesoCliente (List<AltaCliente> listaClientes)
        {

            Console.WriteLine("#######################");
            Console.WriteLine("######### LOGIN #######");
            Console.WriteLine("#######################");
            Console.WriteLine("EMAIL: ");
            string emailDeComprobacion = Console.ReadLine();

            Console.WriteLine("CONTRASEÑA: ");
            string contraseñaDeComprobacion = Console.ReadLine();

            

            foreach(AltaCliente clienteAbuscar in listaClientes)
            {
                if (clienteAbuscar.EsValidado == true) { 

                    if(clienteAbuscar.EmailCliente.Equals(emailDeComprobacion) == true)
                    {
                        if (clienteAbuscar.ContraseniaCliente.Equals(contraseñaDeComprobacion) == true)
                        {
                            Console.WriteLine("INICIO DE SESION CORRECTO");
                        }

                    }
                }

                else
                {
                    Console.WriteLine("AUN NO HA SIDO VALIDADO");
                }


            }


        }


        public void validarUnCliente (List<AltaCliente> listaClientes)
        {
            // Muestra al empleado los clientes Aun no validados
            Console.WriteLine("Clientes no Validados: ");
            foreach (AltaCliente clienteABuscar in listaClientes)
            {
                if (clienteABuscar.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\");
                    Console.WriteLine("DNI: " + clienteABuscar.DniCliente);
                    Console.WriteLine("NOMBRE: " + clienteABuscar.NombreCompletoCliente);
                    Console.WriteLine("\\\\\\\\\\");
                }

            }


            Console.WriteLine("DNI CLIENTE: ");

            string dniAValidar = Console.ReadLine();

            foreach(AltaCliente clienteABuscarDNI in listaClientes)
            {

                if (clienteABuscarDNI.DniCliente.Equals(dniAValidar) == true)
                {

                    clienteABuscarDNI.EsValidado = true;

                }

                else { Console.WriteLine("NO HA SIDO VALIDADO"); }

            }

        }




    }
}
