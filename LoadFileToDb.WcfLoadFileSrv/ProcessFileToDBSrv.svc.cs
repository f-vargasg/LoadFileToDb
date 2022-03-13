using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoadFileToDb.WcfLoadFileSrv
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    //TODO: Agregar log4net 
    public class ProcessFileToDBSrv : IProcessFileToDBSrv
    {
        public void UploadFile(RemoteFileInfo request)
        {
            Stream sourceStream = request.FileByteStream;

            string uploadFolder = ConfigurationManager.AppSettings["uploadPath"]; ;

            string filePath = Path.Combine(uploadFolder, request.Filename);

            using (var fname = File.Create(filePath))
            {
                sourceStream.CopyTo(fname);
            }
        }
    }
}
