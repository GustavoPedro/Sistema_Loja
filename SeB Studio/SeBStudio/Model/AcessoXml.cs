using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeBStudio.Model
{
    class AcessoXml
    {
        
        public string ConexaoXml()
        {
            try
            {
                string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                pasta = pasta + "\\SebStudio";
                string arquivo = @"\configuracoes.xml";
            
                if (!Directory.Exists(pasta))
                {

                    Directory.CreateDirectory(pasta);

                    using (File.Create(pasta + arquivo))
                    {

                    }                    
                    XmlTextWriter writer = new XmlTextWriter(pasta + arquivo, null);
                    //inicia o documento xml
                    writer.WriteStartDocument();
                    //escreve o elmento raiz
                    writer.WriteStartElement("Configuracoes");
                    writer.WriteEndElement();
                    writer.Close();
                    System.Windows.Forms.MessageBox.Show("Uma pasta com um arquivo foi criada em documentos onde as configurações serão guardadas");
                    return pasta + arquivo;
                }
                else
                {
                    if (!File.Exists(pasta + arquivo))
                    {
                        using (File.Create(pasta + arquivo)) {}
                        XmlTextWriter writer = new XmlTextWriter(pasta + arquivo, null);
                        //inicia o documento xml
                        writer.WriteStartDocument();
                        //escreve o elmento raiz
                        writer.WriteStartElement("Configuracoes");
                        writer.WriteEndElement();
                        writer.Close();
                       System.Windows.Forms.MessageBox.Show("Uma pasta com um arquivo foi criada em documentos onde as configurações serão guardadas");
                        return pasta + arquivo;
                    }
                    return pasta + arquivo;
                }
            }
            catch (Exception)
            {

                return "erro";
            }
        }
    }
}
