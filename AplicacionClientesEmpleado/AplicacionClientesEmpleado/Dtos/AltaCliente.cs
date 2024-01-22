﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Dtos
{
    internal class AltaCliente
    {


        int idCliente = 1;
        string dniCliente = "aaaaa";
        string nombreCliente = "aaaaa";
        string apellido1Cliente = "aaaaa";
        string apellido2Cliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        string emailCliente = "aaaaa";
        string contraseniaCliente = "aaaaa";
        bool esValidado = false;

        public AltaCliente(int idCliente, string dniCliente, string nombreCliente, string apellido1Cliente, string apellido2Cliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente, bool esValidado)
        {
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
            this.nombreCliente = nombreCliente;
            this.apellido1Cliente = apellido1Cliente;
            this.apellido2Cliente = apellido2Cliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.esValidado = esValidado;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }



        public AltaCliente() { }

        override

            public string ToString()
                {

                 string datosClientes =
                    "%%%%%%%%%%%%%%%%%%%%" +
                    " DNI: " + this.dniCliente +
                    " NOMBRE: " + this.apellido1Cliente + " " + this.apellido2Cliente + "," + this.nombreCliente +
                    " ESTADO VALIDACIÓN: " + this.esValidado +
                    " ID: " + this.idCliente + // ELIMINAR
                    " %%%%%%%%%%%%%%%%%%%%" ;

                return datosClientes;

                }

    }
}
