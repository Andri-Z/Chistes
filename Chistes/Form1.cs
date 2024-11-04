namespace Chistes
{
    public partial class Fgenerador : Form
    {
        public Fgenerador()
        {
            InitializeComponent();
        }
        public static string? BuscarChiste(string path)
        {
            string[] chistes = new string[] { };
            int index = 0;
            try
            {
                chistes = File.ReadAllLines(path);
                index = new Random().Next(1, chistes.Length);
                return chistes[index];
            }
            catch
            {
                MessageBox.Show("Error al buscar los chistes.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return string.Empty;
            }                      
        }
        static void Generar(string categoria)
        {
            string path, chiste, currentDirectory = string.Empty;
            DirectoryInfo dInfo;
            switch (categoria)
            {
                case "ChistesMalos":
                    currentDirectory = Directory.GetCurrentDirectory();
                    dInfo = new DirectoryInfo(currentDirectory);
                    dInfo = dInfo.Parent.Parent.Parent;
                    path = Path.Combine(dInfo.ToString(),"ArchivosTxt\\ChistesMalos.txt");
                    chiste = BuscarChiste(path);
                    if (chiste != "")
                    {
                        MessageBox.Show($"{chiste}", "Chistes Malos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                    break;

                case "ChistesPapa":
                    currentDirectory = Directory.GetCurrentDirectory();
                    dInfo = new DirectoryInfo(currentDirectory);
                    dInfo = dInfo.Parent.Parent.Parent;
                    path = Path.Combine(dInfo.ToString(), "ArchivosTxt\\ChistesPapa.txt");
                    chiste = BuscarChiste(path);
                    if (chiste != "")
                    {
                        MessageBox.Show($"{chiste}", "Chistes de Papa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "ChistesTecnologia":
                    currentDirectory = Directory.GetCurrentDirectory();
                    dInfo = new DirectoryInfo(currentDirectory);
                    dInfo = dInfo.Parent.Parent.Parent;
                    path = Path.Combine(dInfo.ToString(), "ArchivosTxt\\ChistesTecnologia.txt");
                    chiste = BuscarChiste(path);
                    if (chiste != "")
                    {
                        MessageBox.Show($"{chiste}", "Chistes de Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "ChistesAnimales":
                    currentDirectory = Directory.GetCurrentDirectory();
                    dInfo = new DirectoryInfo(currentDirectory);
                    dInfo = dInfo.Parent.Parent.Parent;
                    path = Path.Combine(dInfo.ToString(), "ArchivosTxt\\ChistesAnimales.txt");
                    chiste = BuscarChiste(path);
                    if (chiste != "")
                    {
                        MessageBox.Show($"{chiste}", "Chistes de Animales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "ChistesCortos":
                    currentDirectory = Directory.GetCurrentDirectory();
                    dInfo = new DirectoryInfo(currentDirectory);
                    dInfo = dInfo.Parent.Parent.Parent;
                    path = Path.Combine(dInfo.ToString(), "ArchivosTxt\\ChistesCortos.txt");
                    chiste = BuscarChiste(path);
                    if (chiste != "")
                    {
                        MessageBox.Show($"{chiste}", "Chistes Cortos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    MessageBox.Show("Tipo de chiste no existe.");
                    break;
            }
        }
        #region Botones
        private void btnChistesMalos_Click(object sender, EventArgs e)
        {
            Generar("ChistesMalos");
        }

        private void btnChistesPapa_Click_1(object sender, EventArgs e)
        {
            Generar("ChistesPapa");
        }

        private void btnChistesTecnologia_Click(object sender, EventArgs e)
        {
            Generar("ChistesTecnologia");
        }

        private void btnChistesAnimales_Click(object sender, EventArgs e)
        {
            Generar("ChistesAnimales");
        }

        private void btnChistesCortos_Click(object sender, EventArgs e)
        {
            Generar("ChistesCortos");
        }
        #endregion 
    }
}
