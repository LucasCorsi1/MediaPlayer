using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;


namespace TrabalhoMediaPlayer
{

    public partial class Form1 : Form
    {
        ListaEncadeada<CaminhoMusica> listaMusicas = new ListaEncadeada<CaminhoMusica>();
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        private BlockAlignReductionStream stream = null;
        private DirectSoundOut output = null;
        private Node<CaminhoMusica> _rMusicaAtual = null;
        private bool _rPodeEntrarTrocaMusic = true;
        private bool _rAleatorio = false;

        private ListaEncadeada<FileInfo> _uListaArquivos = new ListaEncadeada<FileInfo>();

        public Form1()

        {
            InitializeComponent();
            try
            {
                output = new DirectSoundOut();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                comboBox1.Items.AddRange(devices.ToArray());
                comboBox1.SelectedIndex = 0;
            }
            catch { }
            textBoxAleatorio.BackColor = Color.Red;
            textBoxAleatorio.Enabled = false;
        }

        void player_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            /* o ocorre um evento toda vez que occorre o stop e em alguns momentos é tratado para não entrar. */
            if (_rPodeEntrarTrocaMusic)
            {
                /* Quando selecionado o aleatório ele entra no if e sorteia a musica para a próxima reprodução. */

                if (_rAleatorio)
                {
                    Node<CaminhoMusica> _rTemp = listaMusicas.head;
                    Random randNum = new Random();
                    int count = 0;
                    while (count < randNum.Next(listaMusicas.count))
                    {
                        _rTemp = _rTemp.Proximo;
                        count++;
                    }
                    _rMusicaAtual = _rTemp;
                    proPlayMusic(_rMusicaAtual.Item.musica);
                }
                else
                {
                    /* Se não tiver selecionado o aleatório ele simplesmente toca o próximo 
                      E torna a lista circular  */
                    if (_rMusicaAtual.Proximo == null)
                    {
                        _rMusicaAtual = listaMusicas.head;
                        proPlayMusic(_rMusicaAtual.Item.musica);

                    }
                    else
                    {
                        proPlayMusic(_rMusicaAtual.Proximo.Item.musica);
                        _rMusicaAtual = _rMusicaAtual.Proximo;

                    }
                }
            }
        }
        private Node<CaminhoMusica> proDevolverAtual(String caminho)
        {   /* de acordo com o  caminho da musica ele pega o item atual da lista*/
            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            while (_rTemp.Proximo != null)
            {
                if (_rTemp.Item.arquivo == caminho)
                    return _rTemp;
                _rTemp = _rTemp.Proximo;
            }
            return _rTemp;
        }

        private void buttonbusca_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath == null || folderBrowserDialog1.SelectedPath == "")
                return;
            DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            /* Pega o caminho selcionado e pega todos os arquivos e pastas do local selecionado*/
            ListarFiles(folder.GetFiles(), folder.GetFiles().Length - 1);
            Listarpastas(folder.GetDirectories(), folder.GetDirectories().Length - 1);
            /*adiciona as informações na lista e no treeview*/
            proAdicionarInformacoes();
            proAdicionarTreeViews();
        }
        private void proPlayMusic(string musica)
        {
            
            /* Toca a musica em si e aciona o evento para já tocar a próxima */
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(musica));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            _rPodeEntrarTrocaMusic = true;
            output.Init(stream);
            output.PlaybackStopped += player_PlaybackStopped;
            output.Play();
        }
        public Boolean ListarFiles(FileInfo[] arquivos, int comprimento)
        {
            if (comprimento < 0)
                return true;
            /* Função recursiva para pegar os arquivos mp3 e adicionar na lista.*/
            if (arquivos[comprimento].Extension.Equals(".mp3"))
            {
                _uListaArquivos.InsertLast(arquivos[comprimento]);
            }
            ListarFiles(arquivos, comprimento - 1);
            return true;
        }

        public Boolean Listarpastas(DirectoryInfo[] pastas, int comprimento)
        {
            if (comprimento < 0)
            {
                return true;
            }
            /* Função recursiva para pegar as subpastas e chamar os arquivos nela presente*/
            ListarFiles(pastas[comprimento].GetFiles(), pastas[comprimento].GetFiles().Length - 1);
            Listarpastas(pastas[comprimento].GetDirectories(), pastas[comprimento].GetDirectories().Length - 1);
            Listarpastas(pastas, comprimento - 1);
            return true;
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            string _rMusicaSelecionada = string.Empty;
            if (_rMusicaAtual != null)
            {
                if (treeViewMusic.SelectedNode != null) {
                    if (_rMusicaAtual.Item.arquivo == treeViewMusic.SelectedNode.Nodes[0].Text.ToString())
                    {
                        if (output.PlaybackState.ToString() == "Paused")
                        {
                            output.Play();
                            return;
                        }
                    }
                    else {

                        _rMusicaAtual = proDevolverAtual(treeViewMusic.SelectedNode.Nodes[0].Text.ToString());
                        proPlayMusic(_rMusicaAtual.Item.musica);
                    }
                }
            }

            if (output.PlaybackState.ToString() == "Playing")
                return;
            
            if (treeViewMusic.Nodes.Count == 0)
                return;
            /* Depois de feita as validações ele pega o selecionado do tree view e chama a função para tocar a musica em si. */
            

            if (treeViewMusic.SelectedNode == null)
                _rMusicaSelecionada = treeViewMusic.Nodes[0].Nodes[0].Text.ToString();
            else
                _rMusicaSelecionada = treeViewMusic.SelectedNode.Nodes[0].Text.ToString();

            _rMusicaAtual = proDevolverAtual(_rMusicaSelecionada);
            proPlayMusic(_rMusicaAtual.Item.musica);

        }

        private void buttonpause_Click(object sender, EventArgs e)
        {
            /*Simplesmente pausa musica que está tocando*/
            if (output.PlaybackState.ToString() == "Playing")
                output.Pause();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    var device = (MMDevice)comboBox1.SelectedItem;
                    verticalProgressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 100));
                    verticalProgressBar2.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 80));
                    verticalProgressBar3.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 70));
                    verticalProgressBar4.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 60));
                    verticalProgressBar5.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 50));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro "  + ex.Message);
            }
        }
 
        private String proDevolverAnterior(String caminho)
        {   
            /* Função para retornar a musica anterior da qual está tocando */
            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            while (_rTemp.Proximo != null)
            {
                if (_rTemp.Proximo.Item.caminho == caminho)
                    return _rTemp.Item.musica;
                _rTemp = _rTemp.Proximo;
            }
            return listaMusicas.end.Item.musica;
        }     

        private void buttonDEL_Click(object sender, EventArgs e)
        {

            /*  Função faz as validações nescessárias e deleta a musica selecionado do treeview e da lista. */
            if (treeViewMusic.Nodes.Count == 0)
                return;
            string caminho = string.Empty;

            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();

            if (treeViewMusic.SelectedNode == null)
                caminho = treeViewMusic.Nodes[0].Nodes[0].Text.ToString();
            else
                caminho = treeViewMusic.SelectedNode.Nodes[0].Text.ToString();
            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            while (_rTemp != null)
            {
                if (_rTemp.Item.arquivo == caminho)
                {
                    listaMusicas.DeleteNode(_rTemp.Item.caminho);
                    treeViewMusic.SelectedNode.Remove();
                    break;
                }
                _rTemp = _rTemp.Proximo;
            }
        }

        private void buttonAleatorio_Click(object sender, EventArgs e)
        {
            /*simplesmente liga ou desliga o aleatório*/
            if (_rAleatorio)
            {
                _rAleatorio = false;
                textBoxAleatorio.BackColor = Color.Red;
            }
            else
            {
                textBoxAleatorio.BackColor = Color.Green;
                _rAleatorio = true;
            }
        }

        private void buttonfoward_Click_1(object sender, EventArgs e)
        {
            if (_rMusicaAtual == null)
                return;

            /* faz as validações e toca a próxima música */
            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();
            if (_rMusicaAtual.Proximo == null)
            {
                _rMusicaAtual = listaMusicas.head;
                MessageBox.Show("A lista chegou ao fim.");
                proPlayMusic(_rMusicaAtual.Item.musica);
               

            }
            else
            {
                proPlayMusic(_rMusicaAtual.Proximo.Item.musica);
                _rMusicaAtual = _rMusicaAtual.Proximo;
            }
        }

        private void buttonback_Click_1(object sender, EventArgs e)
        {   
            /* faz as validações e toca a música anterior */
            if (_rMusicaAtual == null)
                return;

            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();

            String musi = proDevolverAnterior(_rMusicaAtual.Item.musica);
            proPlayMusic(musi);
            _rMusicaAtual = proDevolverAtual(musi);
        }

        private void buttonstop_Click_1(object sender, EventArgs e)
        {
            /* para de tocar a musica selecionada*/
            _rPodeEntrarTrocaMusic = false;
            output.Stop();
        }

        private void proAdicionarInformacoes()
        {
            /* pega as informações nescessárias da lista de musicas */
            Node<FileInfo> _rTemp = _uListaArquivos.head;
            Mp3FileReader reader;
            double bitrate;
            String duracao;
            while (_rTemp.Proximo != null)
            {
                try
                {
                    reader = new Mp3FileReader(_rTemp.Item.FullName);
                    bitrate = (reader.Mp3WaveFormat.AverageBytesPerSecond * 8) / 1000;
                    duracao = reader.TotalTime.Duration().ToString().Substring(3, 5);
                    treeViewMusic.SelectedImageIndex = 0;
                    listaMusicas.InsertLast(new CaminhoMusica(_rTemp.Item.ToString(), bitrate.ToString(), _rTemp.Item.FullName, duracao));
                }
                catch
                {
                    MessageBox.Show("Tem um arquivo corrompido em sua playList e não é possivel toca-la. \n Então ela foi retirada.");
                    /* não é tratado pois deve continuar sem o arquivo corrompido */
                }
                _rTemp = _rTemp.Proximo;
            }
            try
            {
                reader = new Mp3FileReader(_rTemp.Item.FullName);
                bitrate = (reader.Mp3WaveFormat.AverageBytesPerSecond * 8) / 1000;
                duracao = reader.TotalTime.Duration().ToString().Substring(3, 5);
                treeViewMusic.SelectedImageIndex = 0;
                listaMusicas.InsertLast(new CaminhoMusica(_rTemp.Item.ToString(), bitrate.ToString(), _rTemp.Item.FullName, duracao));
            }
            catch

            {
                MessageBox.Show("Tem um arquivo corrompido em sua playList e não é possivel toca-la. \n Então ela foi retirada.");
                /* não é tratado pois deve continuar sem o arquivo corrompido */
            }
        }
        private void proAdicionarTreeViews()
        {
            try
            {
                /*adiciona a música no tree view */
                Node<CaminhoMusica> _rTemp = listaMusicas.head;
                int contador = 0;
                while (_rTemp.Proximo != null)
                {

                    treeViewMusic.Nodes.Add(_rTemp.Item.caminho);
                    treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.arquivo);
                    treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.duracao);
                    treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.bitRate);
                    treeViewMusic.SelectedImageIndex = 0;
                    _rTemp = _rTemp.Proximo;
                    contador++;
                }
                treeViewMusic.Nodes.Add(_rTemp.Item.caminho);
                treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.arquivo);
                treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.duracao);
                treeViewMusic.Nodes[contador].Nodes.Add(_rTemp.Item.bitRate);
                treeViewMusic.SelectedImageIndex = 0;
            }
            catch {

                /* O erro que ocorre aqui não tem um tratamento por isso está em um try catch sem tratamento */
            }
        }

        private void buttonPrimeiro_Click(object sender, EventArgs e)
        {
            if (listaMusicas.head == null)
                return;
            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();
            MessageBox.Show("Atlético é first");
            proPlayMusic(listaMusicas.head.Item.musica);
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            if (listaMusicas.end == null)
                return;
            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();
            MessageBox.Show("Coxa é last");
            proPlayMusic(listaMusicas.end.Item.musica);
        }
    }
}
