
namespace backend.Services.Azure
{

    public class Certificate
    {
        static readonly string Key = "sp=r&st=2024-06-03T03:37:29Z&se=2024-12-04T02:30:00Z&spr=https&sv=2022-11-02&sr=c&sig=9b76%2FQwyP%2FdVg6%2B7qZQ3L4wBLDzSBsxobX7fMq5QOWU%3D";

        public string AcessImgBlob(string fileUrl, string FileName)
        {
            return fileUrl + "/" + FileName + "?" + Key;
        }

    }

}
