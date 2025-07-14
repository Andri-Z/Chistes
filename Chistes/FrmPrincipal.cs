namespace Chistes
{
    public partial class FrmPrincipal : Form
    {
        private Chistes chistes = new();
        public FrmPrincipal()=>
            InitializeComponent();

        private void btnChistesMalos_Click(object sender, EventArgs e)=>
            chistes.GenerateChiste(TipoChiste.ChistesMalos);

        private void btnChistesPapa_Click(object sender, EventArgs e)=>
            chistes.GenerateChiste(TipoChiste.ChistesPapa);
        
        private void btnChistesTecnologia_Click(object sender, EventArgs e)=>
            chistes.GenerateChiste(TipoChiste.ChistesTecnologia);

        private void btnChistesAnimales_Click(object sender, EventArgs e)=>
            chistes.GenerateChiste(TipoChiste.ChistesAnimales);

        private void btnChistesCortos_Click(object sender, EventArgs e)=>
            chistes.GenerateChiste(TipoChiste.ChistesCortos);
    }
}
