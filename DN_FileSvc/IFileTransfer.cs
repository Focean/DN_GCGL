using System;
using System.IO;
using System.Data;
using System.ServiceModel;

namespace WcfFileTransferInterface123
{
    [ServiceContract]
    public interface IFileTransfer
    {
        [OperationContract]
        string Hello(string yourName);

        [OperationContract]
        Int32Message UploadFile(UploadFileMessage request); 

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginUploadFile(UploadFileMessage request, AsyncCallback callback, object asyncState);

        Int32Message EndUploadFile(IAsyncResult asyncResult);

        [OperationContract]
        DownloadFileMessage DownloadFile(FileMessage request);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginDownloadFile(FileMessage request, AsyncCallback callback, object asyncState);

        DownloadFileMessage EndDownloadFile(IAsyncResult asyncResult);

        [OperationContract]
        DataSet GetFileList();

    }

    [MessageContract]
    public class FileMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string FileName;  //文件名称

        [MessageHeader(MustUnderstand = true)]
        public Int32 Index;  //
    }



    [MessageContract]
    public class Int32Message
    {
        [MessageHeader(MustUnderstand = true)]
        public Int32 Index;  //
    }


    [MessageContract]
    public class StreamMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public Int32 Index;  //

        [MessageBodyMember]
        public Stream FileData;
    }


    [MessageContract]
    public class UploadFileMessage : StreamMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string FileName;  //文件名称

        [MessageHeader(MustUnderstand = true)]
        public string SavePath;  //文件保存路径

    }

    [MessageContract]
    public class DownloadFileMessage : StreamMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public long FileSize;

        [MessageHeader(MustUnderstand = true)]
        public string Tag;

    }


}
