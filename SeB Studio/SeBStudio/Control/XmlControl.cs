using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeBStudio.Control
{
    class XmlControl
    {
        private string pasta;
        XDocument xmlDoc;

        public XmlControl(string pasta)
        {
            this.pasta = pasta;
            xmlDoc = XDocument.Load(pasta);
        }

        public void RegistrarCaminho(string caminho)
        {
            try
            {
                string cam = BuscarCaminho();
                if (cam == null || cam == "" || cam == " ")
                {
                    XElement emp = new XElement("Caminho",
                    new XElement("Nome", caminho));
                    xmlDoc.Root.Add(emp);
                    xmlDoc.Save(pasta);
                }
                else
                {
                    var path = xmlDoc.Descendants("Caminho").Single(
                  p => p.Element("Nome").Value.Equals(cam));
                    path.SetElementValue("Nome", caminho);
                    xmlDoc.Save(pasta);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public string BuscarCaminho()
        {
            try
            {
                string caminho = "";
                xmlDoc.Descendants("Caminho").Select(p => new
                {
                    Nome = p.Element("Nome").Value

                }).ToList().ForEach(p =>
                {
                    caminho = p.Nome;
                });
                return caminho;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Atendente> BuscarAtendentes()
        {
            try
            {
                List<Atendente> Atendentes = new List<Atendente>();
                xmlDoc.Descendants("Atendente").Select(p => new
                {
                    id = p.Attribute("id").Value,
                    Atentente = p.Element("Nome").Value

                }).ToList().ForEach(p =>
                {
                    Atendente atendente = new Atendente();
                    atendente.Id = int.Parse(p.id);
                    atendente.Nome = p.Atentente;
                    Atendentes.Add(atendente);
                });

                return Atendentes;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public void CadastrarAtendentes(string atendente, string id)
        {
            try
            {
                XElement emp = new XElement("Atendente",
                    new XElement("Nome", atendente),
                    new XAttribute("id", id));
                xmlDoc.Root.Add(emp);
                xmlDoc.Save(pasta);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }
        public void CadastrarTamanhosPreDefinidos(TamanhosPreDefinidos tamanhos)
        {
            try
            {
                XElement emp = new XElement("TamanhosPreDefinidos",
                    new XAttribute("id", tamanhos.Id),
                new XElement("Nome", tamanhos.Nome),
                new XElement("Valor", tamanhos.Valor.ToString()),
                new XElement("Altura", tamanhos.Altura.ToString()),
                new XElement("Largura", tamanhos.Largura.ToString()));
                xmlDoc.Root.Add(emp);
                xmlDoc.Save(pasta);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void ExcluirAtendente(string id)
        {
            try
            {
                var cliente = xmlDoc.Descendants("Atendente").Single(
                 p => p.Attribute("id").Value.Equals(id));
                cliente.Remove();
                xmlDoc.Save(pasta);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void UpdateTamanho(TamanhosPreDefinidos tam)
        {
            try
            {
                var cliente = xmlDoc.Descendants("TamanhosPreDefinidos").Single(
                   p => p.Attribute("id").Value.Equals(tam.Id.ToString()));
                cliente.SetElementValue("Nome", tam.Nome);
                cliente.SetElementValue("Valor", tam.Valor.ToString());
                cliente.SetElementValue("Altura", tam.Altura.ToString());
                cliente.SetElementValue("Largura", tam.Largura.ToString());
                xmlDoc.Save(pasta);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void ExcluirTamanho(string id)
        {
            try
            {
                var cliente = xmlDoc.Descendants("TamanhosPreDefinidos").Single(
                    p => p.Attribute("id").Value.Equals(id));
                cliente.Remove();
                xmlDoc.Save(pasta);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public List<TamanhosPreDefinidos> BuscarTamanhos()
        {
            try
            {
                List<TamanhosPreDefinidos> Lista = new List<TamanhosPreDefinidos>();

                xmlDoc.Descendants("TamanhosPreDefinidos").Select(p => new
                {
                    id = p.Attribute("id").Value,
                    Nome = p.Element("Nome").Value,
                    Valor = p.Element("Valor").Value,
                    Altura = p.Element("Altura").Value,
                    Largura = p.Element("Largura").Value
                }).ToList().ForEach(p =>
                {
                    TamanhosPreDefinidos tamanhosPreDefinidos = new TamanhosPreDefinidos();
                    tamanhosPreDefinidos.Id = Convert.ToInt32(p.id);
                    tamanhosPreDefinidos.Nome = p.Nome;
                    tamanhosPreDefinidos.Valor = decimal.Parse(p.Valor);
                    tamanhosPreDefinidos.Altura = int.Parse(p.Altura);
                    tamanhosPreDefinidos.Largura = int.Parse(p.Largura);
                    Lista.Add(tamanhosPreDefinidos);
                });

                return Lista;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erro inesperado", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }

        }
    }
    public class TamanhosPreDefinidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
    }
    public class Atendente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
