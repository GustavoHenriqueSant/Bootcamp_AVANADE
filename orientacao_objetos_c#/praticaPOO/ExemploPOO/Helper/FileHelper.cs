using System.Collections.Generic;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        
        public void listDrectory(string path){
            var deretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var diretorio in deretorios)
            {
                System.Console.WriteLine(diretorio);
            }
        }

        public void listFiles(string path){
            var files = Directory.GetFiles(path, "*2*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }
        }

        public void criarDerectory(string path){
            var infos = Directory.CreateDirectory(path);
            System.Console.WriteLine(infos);
        }

        public void apagarDirectory(string path, bool apagarArquivos){
            Directory.Delete(path, apagarArquivos);
        }

        public void criarArquivoTxt(string path, string text){
            if(!File.Exists(path))
                File.WriteAllText(path, text); 
        }

        public void criandoTextoStream(string path, List<string> listaString){
            using(var stream = File.CreateText(path)){
                foreach (var line in listaString)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void incrementarArquivoTxt(string path, string adicao){
            File.AppendAllText(path, adicao);
        }

        public void incrementarTextoStream(string path, List<string> listaString){
            using(var stream = File.AppendText(path)){
                foreach (var line in listaString)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void lerArquivo(string path){
            var conteudoFile = File.ReadAllLines(path);

            foreach (var conteudo in conteudoFile)
            {
                System.Console.WriteLine(conteudo);
            }
        }

        public void lerArquivoStream(string path){
            string linha = string.Empty;

            using(var stream = File.OpenText(path)){
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }

        public void moverArquivo(string currentPath, string futurePath, bool sobrescrever){
            File.Move(currentPath, futurePath, sobrescrever);
        }

        public void copiarArquivo(string caminho, string caminhoCopia, bool sobrescrever){
            File.Copy(caminho, caminhoCopia, sobrescrever);
        }

        public void deletarFile(string path){
            File.Delete(path);
        }
    }
}