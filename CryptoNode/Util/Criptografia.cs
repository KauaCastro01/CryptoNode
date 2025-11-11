using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoNode.Util
{
    public class Criptografia
    {
        private int[] chave;

        char[] alfabetoNormal = new char[] {
    'A','B','C','D','E','F','G','H','I','J','K','L','M',
    'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
};

        private Random random = new Random();

        public string CriptografiaCifraCesar(string texto)
        {
            int deslocamento = Properties.Settings.Default.Deslocamento;
            StringBuilder textoModificado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (c >= 'A' && c <= 'Z')
                    c = (char)(((c - 'A' + deslocamento) % 26) + 'A');
                else if (c >= 'a' && c <= 'z')
                    c = (char)(((c - 'a' + deslocamento) % 26) + 'a');

                textoModificado.Append(c);
            }

            return textoModificado.ToString();
        }

        public string DescriptografiaCifraCesar(string texto)
        {
            int deslocamento = Properties.Settings.Default.Deslocamento;
            StringBuilder textoModificado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (c >= 'A' && c <= 'Z')
                    c = (char)(((c - 'A' - deslocamento) % 26) + 'A');
                else if (c >= 'a' && c <= 'z')
                    c = (char)(((c - 'a' - deslocamento) % 26) + 'a');

                textoModificado.Append(c);
            }

            return textoModificado.ToString();
        }

        public string GerarAlfabetoAleatorioSubstituicao()
        {
            char[] alfabetoCopia = alfabetoNormal.ToArray();
            char[] alfabetoCriptografado = new char[26];

            for (int i = 0; i < 26; i++)
            {
                int indiceAleatorio;
                do { indiceAleatorio = random.Next(0, 26); }
                while (alfabetoCopia[indiceAleatorio] == '\0');

                alfabetoCriptografado[i] = alfabetoCopia[indiceAleatorio];
                alfabetoCopia[indiceAleatorio] = '\0';
            }

            return new string(alfabetoCriptografado);
        }

        public string CriptografiaSubstituicao(string texto)
        {
            texto = texto.ToUpper();
            string alfabetoCriptografado = Properties.Settings.Default.AlfabetoCriptografado;
            StringBuilder textoModificado = new StringBuilder();

            foreach (char c in texto)
            {
                if (char.IsLetter(c))
                {
                    int index = Array.IndexOf(alfabetoNormal, c);
                    textoModificado.Append(alfabetoCriptografado[index]);
                }
                else
                    textoModificado.Append(c);
            }

            return textoModificado.ToString();
        }

        public string DescriptografiaSubstituicao(string texto )
        {
            texto = texto.ToUpper();
            string alfabetoCriptografado = Properties.Settings.Default.AlfabetoCriptografado;
            StringBuilder textoDescriptografado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (char.IsLetter(c))
                {
                    int index = alfabetoCriptografado.IndexOf(c);

                    if (index >= 0)
                        textoDescriptografado.Append(alfabetoNormal[index]);
                    else
                        textoDescriptografado.Append(c); 
                }
                else
                    textoDescriptografado.Append(c);

            }

            return textoDescriptografado.ToString();
        }

        public string CriptografarTransposicao(string texto, int[] chave)
        {
            this.chave = chave;

            if (string.IsNullOrWhiteSpace(texto))
                return "ERRO: texto inválido.";

            texto = SanitizarEntrada(texto.ToUpper());

            int n = texto.Length;
            int colunas = Math.Min(chave.Length, n);
            int linhas = (int)Math.Ceiling((double)n / colunas);
            char[,] grid = new char[linhas, colunas];

            // Preenche grid com o texto (e padding com '_')
            int index = 0;
            for (int l = 0; l < linhas; l++)
            {
                for (int c = 0; c < colunas; c++)
                {
                    grid[l, c] = index < n ? texto[index++] : '_';
                }
            }

            // Lê o grid por colunas conforme a chave
            StringBuilder resultado = new StringBuilder();
            foreach (int pos in chave)
            {
                int coluna = pos - 1;
                if (coluna < 0 || coluna >= colunas) continue;

                for (int l = 0; l < linhas; l++)
                {
                    resultado.Append(grid[l, coluna]);
                }
            }

            return resultado.ToString();
        }

        public string DescriptografarTransposicao(string texto, int[] chave)
        {
            this.chave = chave;
            if (string.IsNullOrWhiteSpace(texto) || !ValidarChave())
                return "ERRO: texto ou chave inválida.";

            texto = SanitizarEntrada(texto.ToUpper());

            int n = texto.Length;
            int colunas = Math.Min(chave.Length, n);
            int linhas = (int)Math.Ceiling((double)n / colunas);
            char[,] grid = new char[linhas, colunas];

            // Preenche o grid coluna a coluna
            int index = 0;
            foreach (int pos in chave)
            {
                int coluna = pos - 1;
                if (coluna < 0 || coluna >= colunas) continue;

                for (int l = 0; l < linhas; l++)
                {
                    if (index < n)
                        grid[l, coluna] = texto[index++];
                }
            }

            // Lê linha a linha para restaurar o texto
            StringBuilder restaurado = new StringBuilder();
            for (int l = 0; l < linhas; l++)
            {
                for (int c = 0; c < colunas; c++)
                {
                    restaurado.Append(grid[l, c]);
                }
            }

            return RemoverPaddingFinal(restaurado.ToString());
        }

        private bool ValidarChave()
        {
            if (chave == null || chave.Length == 0)
                return false;

            var unicos = new HashSet<int>();
            foreach (int v in chave)
            {
                if (v < 1 || v > chave.Length || !unicos.Add(v))
                    return false;
            }
            return true;
        }

        private string SanitizarEntrada(string texto)
        {
            return new string(texto.Where(ch => ch != '\n' && ch != '\r').ToArray());
        }

        private string RemoverPaddingFinal(string texto)
        {
            return texto.TrimEnd('_');
        }

        public int[] GerarChave()
        {
            if (Properties.Settings.Default.TamanhoChave <= 0)
                throw new ArgumentException("Tamanho da chave deve ser maior que zero.");

            // Cria uma lista com números de 1 até tamanhoChave
            int[] chave = Enumerable.Range(1, Properties.Settings.Default.TamanhoChave).ToArray();

            // Embaralha a sequência (Fisher–Yates Shuffle)
            for (int i = Properties.Settings.Default.TamanhoChave - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                (chave[i], chave[j]) = (chave[j], chave[i]);
            }

            return chave;
        }

    }
}
