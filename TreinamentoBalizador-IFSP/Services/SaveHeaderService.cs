using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Services
{
    class SaveHeaderService
    {
        private List<String> movements = new List<String>();

        public SaveHeaderService()
        {
            movements.Add("Sinaleiro,");
            movements.Add("IdentificacaoRampa,");
            movements.Add("ProsseguirParaProximoSinaleiroComoOrientadoPelaTorreControle,");
            movements.Add("ProsseguirFrente,");
            movements.Add("GirarParaEsquerda,");
            movements.Add("GirarParaDireita,");
            movements.Add("ParadaNormal,");
            movements.Add("ParadaEmergencia,");
            movements.Add("AcionarFreios,");
            movements.Add("SoltarFreios,");
            movements.Add("CalcosColocados,");
            movements.Add("CalcosRetirados,");
            movements.Add("AcionamentoMotores,");
            movements.Add("CortarMotores,");
            movements.Add("ReduzirVelocidade,");
            movements.Add("ReduzirVelocidadeMotorDireita,");
            movements.Add("ReduzirVelocidadeMotorEsquerda,");
            movements.Add("Recuar,");
            movements.Add("VirarEnquantoRecuandoDireita,");
            movements.Add("VirarEnquantoRecuandoEsquerda,");
            movements.Add("Afirmativo,");
            movements.Add("VooPairado,");
            movements.Add("Subida,");
            movements.Add("Descida,");
            movements.Add("DeslocamentoHorizontalParaDireita,");
            movements.Add("DeslocamentoHorizontalParaEsquerda,");
            movements.Add("Pouso,");
            movements.Add("Fogo,");
            movements.Add("ManterPosicao,");
            movements.Add("DespachoAeronave,");
            movements.Add("NaoToqueComandos,");
            movements.Add("ConectarAlimentacaoEletricaSolo,");
            movements.Add("DesconectarAlimentacaoEletrica,");
            movements.Add("Negativo,");
            movements.Add("EstabelecerComunicacaoInterfone,");
            movements.Add("AbrirFecharEscadas");
        }

        public String Create (int joints)
        {
            String path = GeneratePath();

            File.Create("coordinates/" + path);

            String relation = "@relation TreinamentoBalizador-IFSP";

            String attributeCoordinates = CreateAttributeCoordinates(joints);

            String attributeMovement = CreateAttributeMovement();

            String data = "@data";

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(relation);
                streamWriter.WriteLine("");

                streamWriter.WriteLine(attributeCoordinates);
                streamWriter.WriteLine(attributeMovement);
                streamWriter.WriteLine("");

                streamWriter.WriteLine(data);

                streamWriter.Close();
            }

            return path;
        }

        private String CreateAttributeCoordinates(int joints)
        {
            String init = "@attribute Coordinates { ";

            String coodinates = StringBuilder(joints);

            String finish = " }";

            return String.Concat(init, coodinates, finish);
        }

        private String CreateAttributeMovement()
        {
            String init = "@attribute Movement { ";

            String movements = "";

            foreach (String movement in this.movements) {
                movements = String.Concat(movements, movement);
            }

            String finish = " }";

            return String.Concat(init, movements, finish);
        }

        private String StringBuilder(int joints)
        {
            String builder = "";

            for (int i = 0; i < joints; i++)
            {
                builder = String.Concat(
                    builder,
                    "x", i, ",",
                    "y", i, ",",
                    "z", i, ","
                );
            }

            return builder;
        }

        private String GeneratePath()
        {

            String date = DateTime.Now.ToString("yyyy-MM-dd");

            return String.Concat(
                "coordinates-",
                date,
                "-",
                DateTime.Now.Hour,
                "-",
                DateTime.Now.Minute,
                "-",
                DateTime.Now.Second,
                ".arff"
            );
        }
    }
}
