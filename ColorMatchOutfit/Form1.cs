using System.Globalization;
using System.IO;
namespace ColorMatchOutfit
{
    public partial class ColorMatching : Form
    {
        public ColorMatching()
        {
            InitializeComponent();
        }

        private void ColorMatching_Load(object sender, EventArgs e)
        {
            comboStyle.Items.AddRange(new string[] { "warm", "cool", "neutral" });
            try
            {
                if (File.Exists("palettes.txt"))
                {
                    string[] lines = File.ReadAllLines("palettes.txt");
                    foreach (string line in lines)
                        listSaved.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error regarding loading the palette" + ex.Message);
            }
        }
        private Color GenerateColor(string style)
        {
            Random r1 = new Random();
            int rd, grn, blu;
            if(style == "warm")
            {
                rd = r1.Next(180, 255);
                grn = r1.Next(60, 180);
                blu = r1.Next(0, 100);
            }
            else if(style == "cool")
            {
                rd = r1.Next(0, 120);
                grn = r1.Next(100, 200);
                blu = r1.Next(160, 255);
            }
            else
            {
                int value = r1.Next(150, 230);
                rd = grn = blu = value;
            }
            return Color.FromArgb(rd, grn, blu);
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            string style = comboStyle.Text.ToLower();
            //generate the main color
            Color Main = GenerateColor(style);
            MainColor.BackColor = Main;
            label1.Text = $"RGB({Main.R},{Main.G},{Main.B})";
            //generating 3 matching colors
            pic1Match.BackColor = GenerateColor(style);
            pic2Match.BackColor = GenerateColor(style);
            pic3Match.BackColor = GenerateColor(style);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter file = new StreamWriter("palettes.txt, true"))
                {
                    file.WriteLine(MainColor.Text);
                }
                listSaved.Items.Add(MainColor.Text);
                LblStatus.Text = "palette saved ;)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error saving " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //make sure sothin is selected
                if(listSaved.SelectedItem != null)
                {
                    //saving selected text
                    string SelectedPalette = listSaved.SelectedItems.ToString();
                    //removing form list box
                    listSaved.Items.Remove(SelectedPalette);
                    //rewriting the file without the removed items 
                    List<string> remaining = listSaved.Items.Cast<string>().ToList();
                    File.WriteAllLines("palettes.txt", remaining);
                    LblStatus.Text = "palette removed :)";
                }
                else
                {
                    MessageBox.Show("please select palette to remove");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(" error in removing " + ex.Message);
            }
        }
    }
}
