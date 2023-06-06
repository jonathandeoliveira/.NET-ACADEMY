using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriptografia30_05
{
    internal class Persistencia
    {
        public static void gravarArquivo(List<User> lista)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("ListaUsuarios.dat", append: true);
                foreach (var usuario in lista)
                {
                    escritor.WriteLine(usuario.Login + ";" + usuario.Password + ";");
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void lerArquivo(List<User> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader("ListaUsuarios.dat", Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    lista.Add(new User(vetorLinha[0], vetorLinha[1]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo ou arquivo não localizado!");
            }
        }



    }
}
