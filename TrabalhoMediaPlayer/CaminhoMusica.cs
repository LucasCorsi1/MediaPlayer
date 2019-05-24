using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMediaPlayer
{
   public class CaminhoMusica
    {
        public string caminho;
        public string bitRate;
        public string arquivo;
        public string duracao;
        public string musica;
        /* classe para as informações nescessárias da música */
        public CaminhoMusica(string caminho, string bitRate, string arquivo, string duracao)
        {
            this.caminho = caminho;
            this.bitRate = "BitRate: " + bitRate + " Kbps";
            this.arquivo = "Arquivo: " + arquivo;
            this.duracao = "Duração: " + duracao;
            this.musica = arquivo;
        }
    }
}
