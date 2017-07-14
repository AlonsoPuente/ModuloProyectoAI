using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDA
{
    public class DataAccessGeneral
    {
        static public List<Proyecto> listadoProyecto()
        {
            List<Proyecto> listado = new List<Proyecto>();

            using (var data = new WebEntities1())
               
            {
                listado = data.Proyecto.ToList();
            }

            return listado;
        }

        static public List<Archivo_Investigacion> listadoArchivoI()
        {
            List<Archivo_Investigacion> listado = new List<Archivo_Investigacion>();

            using (var data = new WebEntities1())

            {
                listado = data.Archivo_Investigacion.ToList();
            }

            return listado;
        }

        static public bool RegistrarProyecto(Proyecto proyecto)
        {
            bool exito = true;

            try
            {
                using (var data = new WebEntities1())
                {
                    data.Proyecto.Add(proyecto);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }

        static public bool RegistrarArchivoI(Archivo_Investigacion archivoI)
        {
            bool exito = true;

            try
            {
                using (var data = new WebEntities1())
                {
                    data.Archivo_Investigacion.Add(archivoI);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }

        static public bool RegistrarParticipante(Det_Partic_Proyecto participante)
        {
            bool exito = true;

            try
            {
                using (var data = new WebEntities1())
                {
                    data.Det_Partic_Proyecto.Add(participante);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }

        static public bool RegistrarParticipanteAI(Det_Archivo_Inv participanteAI)
        {
            bool exito = true;

            try
            {
                using (var data = new WebEntities1())
                {
                    data.Det_Archivo_Inv.Add(participanteAI);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }

        static public bool EliminarProyecto(int ID_Proyecto) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new WebEntities1())
                {
                    Proyecto proyecto = data.Proyecto.Where(x => x.ID_Proyecto == ID_Proyecto).FirstOrDefault();// alias

                    data.Proyecto.Remove(proyecto);
                    data.SaveChanges();                   
                   
                }
            }
            catch (Exception)
            {

                exito = false;
            }

            return exito;
        }


        static public bool EliminarArchivoI(int ID_ArchivoI) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new WebEntities1())
                {
                    Archivo_Investigacion archivoI = data.Archivo_Investigacion.Where(x => x.ID_ArchivoI == ID_ArchivoI).FirstOrDefault();// alias

                    data.Archivo_Investigacion.Remove(archivoI);
                    data.SaveChanges();

                }
            }
            catch (Exception)
            {

                exito = false;
            }

            return exito;
        }

        static public bool ActualizarProyecto(Proyecto proyecto) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new WebEntities1())
                {
                    // realizar la consulta y actualizar
                    Proyecto actual = data.Proyecto.Where(x => x.ID_Proyecto == proyecto.ID_Proyecto).FirstOrDefault();// alias
                    actual.Titulo = proyecto.Titulo;
                    actual.Abstract = proyecto.Abstract;
                    actual.Keywords = proyecto.Keywords;
                    actual.Fecha_pub = proyecto.Fecha_pub;
                    actual.Tipo = proyecto.Tipo;
                    actual.Fecha_ini = proyecto.Fecha_ini;
                    actual.Fecha_fin = proyecto.Fecha_fin;
                    actual.Link_file = proyecto.Link_file;
                    actual.Estado = proyecto.Estado;
                    actual.ID_Usuario_crea = proyecto.ID_Usuario_crea;                   

                    // transaccion landa express
                    // data.GEPOSTULANTEs.InsertOnSubmit(postulante);
                    data.SaveChanges(); // guarda los cambios
                }
            }
            catch (Exception)
            {
                // cuando ocurre el error
                exito = false;
            }
            return exito;

        }

        static public bool ActualizarArchivoI(Archivo_Investigacion archivoI) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new WebEntities1())
                {
                    // realizar la consulta y actualizar
                    Archivo_Investigacion actual = data.Archivo_Investigacion.Where(x => x.ID_ArchivoI == archivoI.ID_ArchivoI).FirstOrDefault();// alias
                    actual.Nombre = archivoI.Nombre;
                    actual.Descripcion = archivoI.Descripcion;
                    actual.Fecha_invest = archivoI.Fecha_invest;
                    actual.Fecha_pub_ini = archivoI.Fecha_pub_ini;
                    actual.Fecha_pub_fin = archivoI.Fecha_pub_fin;
                    actual.Foto = archivoI.Foto;
                    actual.Estado = archivoI.Estado;
                    actual.Referencia = archivoI.Referencia;
                    actual.Fecha_crea = archivoI.Fecha_crea;
                    actual.ID_Usuario_crea = archivoI.ID_Usuario_crea;
                    actual.Fecha_mod = archivoI.Fecha_mod;
                    actual.ID_Usuario_mod = archivoI.ID_Usuario_mod;
                    actual.Link_file = archivoI.Link_file;
                    actual.Keywords = archivoI.Keywords;
                    actual.ID_Proyecto = archivoI.ID_Proyecto;
                    actual.AI_Externo = archivoI.AI_Externo;

                    // transaccion landa express
                    // data.GEPOSTULANTEs.InsertOnSubmit(postulante);
                    data.SaveChanges(); // guarda los cambios
                }
            }
            catch (Exception)
            {
                // cuando ocurre el error
                exito = false;
            }
            return exito;

        }
        ///////////////////////////////////////////////////////////////////////////



    }
}
