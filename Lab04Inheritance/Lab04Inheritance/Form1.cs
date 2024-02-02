namespace Lab04Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rayquaza_button_Click(object sender, EventArgs e)
        {
            Rayquaza rayquaza = new Rayquaza();
            Name_label.Text = rayquaza.getName();
            pictureBox2.Image = rayquaza.Picture();
            Id_label.Text = rayquaza.getId().ToString();
            Level_label.Text = rayquaza.getLevel().ToString();
            Type_label.Text = rayquaza.getType().ToString();
            Hp_label.Text = rayquaza.getHp().ToString();
            Att_label.Text = rayquaza.getAtt().ToString();
            Def_label.Text = rayquaza.getDef().ToString();
            SAtt_label.Text = rayquaza.getSAtt().ToString();
            SDef_label.Text = rayquaza.getSDef().ToString();
            Speed_label.Text = rayquaza.getSpeed().ToString();

        }

        private void Raikou_button_Click(object sender, EventArgs e)
        {
            Raikou raikou = new Raikou();
            Name_label.Text = raikou.getName();
            pictureBox2.Image = raikou.Picture();
            Id_label.Text = raikou.getId().ToString();
            Level_label.Text = raikou.getLevel().ToString();
            Type_label.Text = raikou.getType().ToString();
            Hp_label.Text = raikou.getHp().ToString();
            Att_label.Text = raikou.getAtt().ToString();
            Def_label.Text = raikou.getDef().ToString();
            SAtt_label.Text = raikou.getSAtt().ToString();
            SDef_label.Text = raikou.getSDef().ToString();
            Speed_label.Text = raikou.getSpeed().ToString();
        }

        private void Ditto_button_Click(object sender, EventArgs e)
        {
            Ditto ditto = new Ditto();
            Name_label.Text = ditto.getName();
            pictureBox2.Image = ditto.Picture();
            Id_label.Text = ditto.getId().ToString();
            Level_label.Text = ditto.getLevel().ToString();
            Type_label.Text = ditto.getType().ToString();
            Hp_label.Text = ditto.getHp().ToString();
            Att_label.Text = ditto.getAtt().ToString();
            Def_label.Text = ditto.getDef().ToString();
            SAtt_label.Text = ditto.getSAtt().ToString();
            SDef_label.Text = ditto.getSDef().ToString();
            Speed_label.Text = ditto.getSpeed().ToString();
        }

        private void Wobbuffet_button_Click(object sender, EventArgs e)
        {
            Wobbuffet wobbuffet = new Wobbuffet();
            Name_label.Text = wobbuffet.getName();
            pictureBox2.Image = wobbuffet.Picture();
            Id_label.Text = wobbuffet.getId().ToString();
            Level_label.Text = wobbuffet.getLevel().ToString();
            Type_label.Text = wobbuffet.getType().ToString();
            Hp_label.Text = wobbuffet.getHp().ToString();
            Att_label.Text = wobbuffet.getAtt().ToString();
            Def_label.Text = wobbuffet.getDef().ToString();
            SAtt_label.Text = wobbuffet.getSAtt().ToString();
            SDef_label.Text = wobbuffet.getSDef().ToString();
            Speed_label.Text = wobbuffet.getSpeed().ToString();
        }

        private void Litten_button_Click(object sender, EventArgs e)
        {
            Litten litten = new Litten();
            Name_label.Text = litten.getName();
            pictureBox2.Image = litten.Picture();
            Id_label.Text = litten.getId().ToString();
            Level_label.Text = litten.getLevel().ToString();
            Type_label.Text = litten.getType().ToString();
            Hp_label.Text = litten.getHp().ToString();
            Att_label.Text = litten.getAtt().ToString();
            Def_label.Text = litten.getDef().ToString();
            SAtt_label.Text = litten.getSAtt().ToString();
            SDef_label.Text = litten.getSDef().ToString();
            Speed_label.Text = litten.getSpeed().ToString();
        }

        private void Cinderace_button_Click(object sender, EventArgs e)
        {
            Cinderace cinderace = new Cinderace();
            Name_label.Text = cinderace.getName();
            pictureBox2.Image = cinderace.Picture();
            Id_label.Text = cinderace.getId().ToString();
            Level_label.Text = cinderace.getLevel().ToString();
            Type_label.Text = cinderace.getType().ToString();
            Hp_label.Text = cinderace.getHp().ToString();
            Att_label.Text = cinderace.getAtt().ToString();
            Def_label.Text = cinderace.getDef().ToString();
            SAtt_label.Text = cinderace.getSAtt().ToString();
            SDef_label.Text = cinderace.getSDef().ToString();
            Speed_label.Text = cinderace.getSpeed().ToString();
        }
    }
    
}
