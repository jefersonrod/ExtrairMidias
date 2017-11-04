using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtrairMidias
{
    public partial class Form1 : Form
    {
        #region Variables
        String htmlFile = @"c:\tmp\enem3.html";
        String pdf = ".pdf";
        String rar = ".rar";
        String mp3 = ".mp3";
        String HTTP = "http://";
        String HREF = "href=";
        
        String pl = Environment.NewLine; //pula linha para lazy coders
        #endregion

                               
        public Form1()
        {
            InitializeComponent();
            tbCaminho.Text = htmlFile;
        }

        #region Function SearchReference()
        public void SearchReference(String Extension)
        {
            String content;
            String line;
            String lineLink;
            int countLine = 0;
            int startLine = 0;
            int finishLine = 0;
            int sizeLine = 0;
            int sizeString = 0;
            int startSubstring = 0;
            String tempContent = "";
            int countOccurrence = 0;

            StreamReader str = new StreamReader(htmlFile);//Le o arquivo e joga dentro de str
            while ((content = str.ReadLine()) != null)//Le o str linha a linha e joga em content até encontrar null que é o final do arquivo
            {
                countLine++; //contando as linhas
                line = content; //recebendo o conteudo do html linha a linha
                while (line.Contains(HTTP) && line.Contains(Extension)) //enquanto ainda tiver http e pdf na string continua a buscar links
                {
                    if (line.Contains(HTTP) && line.Contains(Extension)) //enquanto ainda tiver http e pdf na string continua a buscar links
                    {
                        sizeLine = line.Length; //pega o tamanho da variavel line
                        String cabecalho = (HREF + "\"" + HTTP); // cria variavel para achar a sequencia href + http
                        startLine = line.IndexOf(cabecalho) + HREF.Length + 1; //marca start da linha + tamanho do href
                        sizeString = (sizeLine) - (startLine + 4); //define o tamanho da string
                        lineLink = line.Substring(startLine, sizeString); //usa linelink para armazenar somente a parte que sera buscada o pdf
                        sizeLine = lineLink.Length; //guarda o tamanho do linelink
                        finishLine = lineLink.IndexOf(Extension); //marca o final do trecho onde esta o .pdf
                        finishLine = finishLine + Extension.Length; //marca novamente mas adicionando o tamanho da string .pdf de 4 posições
                        lineLink = lineLink.Substring(0, finishLine); //agora tira até a parte do pdf, separando o link
                        startSubstring = line.IndexOf(Extension); //aqui marca onde esta o .pdf para depois tirar esta parte do line para remover a parte ja extraida
                                                                  //rtConteudo.AppendText(countLine + " | " + lineLink); //adiciona no textbox o numero da linha e | mais a linha
                                                                  //rtConteudo.AppendText("\n"); //pula linha no textbox

                        for (int i = 0; i < lineLink.Length; i++) //começa laço para ler a variavel lineLink toda
                        {
                            tempContent = tempContent + lineLink[i]; //vai adicionando caracter a caracter a variavel tempContent
                                                                     //MessageBox.Show(tempContent);
                            if (tempContent.Contains(HTTP) && tempContent.Contains("\">"))
                            {
                                int posNaoPDF = lineLink.IndexOf("\">"); //procura a posição do final da url sem pdf
                                lineLink = lineLink.Substring(posNaoPDF + 2); //remove da variavel a parte de url invalida
                                tempContent = ""; //limpa a variavel temporaria para receber novo valor                                
                                break; //interrompe a execução para ler novos valores

                            }
                            if (tempContent.Contains(HTTP) && !tempContent.Contains("\">") && tempContent.Contains(Extension)) //verificando se a linha contem o http e final do link ">
                            {
                                try
                                {
                                    rtConteudo.AppendText(countLine + " | " + tempContent); //adiciona no textbox o numero da linha e | mais a linha
                                    rtConteudo.AppendText(pl); //pula linha no textbox
                                    tempContent = "";   //limpa a variavel temporaria para receber novo valor
                                    countOccurrence++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }

                            }
                        }
                        
                    }
                    line = line.Substring(startSubstring + Extension.Length); //aqui retira do line a parte ja procurada para procurar mais links dentro do line
                }
            }

        }
        //só um teste de leitura de char
        public void stringVetorTest()
        {
            String tmpvar = "link http para arquivo pdf";
            for (int i = 0; i < tmpvar.Length; i++)
            {
                MessageBox.Show("pos: "+ i + " = " + Convert.ToString(tmpvar[i]));

                rtConteudo.AppendText(Convert.ToString(tmpvar[i]));
            }

            
        }
        #endregion

        #region Botões
        private void btGo_Click(object sender, EventArgs e)
        {
            if (cbPDF.Checked)
            {
                SearchReference(pdf);
            }else if (cbRAR.Checked)
            {
                SearchReference(rar);
            }else if (cbPDF.Checked && cbRAR.Checked)
            {
                SearchReference(pdf);
                SearchReference(rar);
            }
            else
            {
                MessageBox.Show("Escolha ao menos uma extensão para buscar");
            }
            
            //stringVetorTest();
        }
        #endregion

        private void btOpen_Click(object sender, EventArgs e)
        {
            //Criar Janela com Open File Dialog para jogar na variavel htmlFile e exibir no tbox do caminho
        }
    }
}
