
            // Generacion de id autonumerico

           
            int tamanioLista = listaClientes.Count;

            if(tamanioLista == 0)
            {
               nuevoCliente.IdCliente =  1;


            }

            else
            {

                nuevoCliente.IdCliente = listaClientes[tamanioLista - 1].IdCliente + 1;

            }





            // Separacion de los nomnbres apellidos 
            
            string[] arrayNombre = nombreCompletoCliente.Split(" ");
            this.nombreCliente = arrayNombre[0];
            this.apellido1Cliente = arrayNombre[1];
            this.apellido2Cliente = arrayNombre[2];
