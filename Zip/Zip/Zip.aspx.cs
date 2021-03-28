using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;

namespace Zip
{
    public partial class Zip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCompactarArquivo_Click(object sender, EventArgs e)
        {
            var listaArquivos = new List<string>();

            using (ZipFile zip = new ZipFile())
            {
                string diretorio = "C:\\Zip\\";

                //foreach (string arquivo in arquivos)
                //{
                //    zip.AddFile(arquivo);
                //}

                //foreach (var arquivo in fupArquivo.PostedFiles)
                //{
                //    fupArquivo.SaveAs(diretorio + arquivo.FileName);
                //    zip.AddFile(diretorio + arquivo.FileName);
                //}

                for (int i = 1; i < fupArquivo.PostedFiles.Count; i++)
                {
                    fupArquivo.SaveAs(diretorio + fupArquivo.PostedFiles[i].FileName);
                    zip.AddFile(diretorio + fupArquivo.PostedFiles[i].FileName);
                }

                zip.Save($"{diretorio}\\meu_zip.zip");

                string[] arquivos = Directory.GetFiles("C:\\Zip\\");

                foreach (var deletar in arquivos)
                {
                    if (!deletar.Contains($".zip"))
                    {
                        File.Delete(deletar);
                    }
                }
            }
        }
    }
}