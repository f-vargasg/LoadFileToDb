using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoadFileToDb.WcfLoadFileSrv
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProcessFileToDBSrv
    {
        [OperationContract]
        void UploadFile(RemoteFileInfo request);

    }


    [MessageContract]
    public class DownloadRequest
    {
        [MessageBodyMember]
        public string Filename;
    }

    [MessageContract]
    public class RemoteFileInfo : IDisposable
    {

        [MessageHeader(MustUnderstand = true)]
        public string Filename;


        [MessageHeader(MustUnderstand = true)]
        public long Length;

        [MessageBodyMember(Order = 1)]
        public System.IO.Stream FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }

}
