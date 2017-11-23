﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Final1C_Ejercicio7
{
 
        [Serializable]
        public class Deposito : IGuardar
        {
            public string nombre;
            public DateTime hs;

            //Tiene que tener constructor por defecto para serializar
            public Deposito(){}

            public Deposito(string nombre)
            {
                this.nombre = nombre;
                this.hs = DateTime.Now;
            }

            public bool Serializar()
            {
                try
                {
                    XmlTextWriter writer = new XmlTextWriter("C:\\XML\\Datos.xml", System.Text.Encoding.UTF8);
                    XmlSerializer ser = new XmlSerializer(typeof(Deposito));
                    ser.Serialize(writer, this);
                    return true;

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    return false;

                }

            }
            public static bool GuardarXML(IGuardar productoAux)
            {
                bool serializoToF = productoAux.Serializar();
                return serializoToF;
            }

        }

}
