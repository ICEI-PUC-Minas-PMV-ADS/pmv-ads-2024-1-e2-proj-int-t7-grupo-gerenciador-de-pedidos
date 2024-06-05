
using Microsoft.AspNetCore.Mvc;
using System;

namespace backend.Services.Azure
{

    public class Certificate
    {
        static readonly string Key = "sp=r&st=2024-06-01T15:00:00Z&se=2024-12-31T02:55:00Z&spr=https&sv=2022-11-02&sr=c&sig=VxC6hllQvJi2Cor0HSF1fnljALMC2gmQPtC1r5a%2FWHs%3D";

        public string AcessImgBlob(string fileUrl, string FileName)
        {
            return fileUrl + "/" + FileName + "?" + Key;
        }

    }

}
