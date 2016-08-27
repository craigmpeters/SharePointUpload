using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharePointUpload.Domain;

namespace SharePointUploadInterface
{
    public interface SharePointRepository
    {
        SharePointFileReturnDomain UploadFile(String AccessToken, String Library, String LocalFilePath, String RemoteFileName);

        SharePointFileReturnDomain DownloadFile(String AccessToken, String Library, String LocalFilePath, String RemoteFileName);

    }
}
