using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String greetingFormat = "Здравствуйте, {0}!\nНаша компания рада приветствовать {1}, увлечённ{2} {3}";
            String name = nameBox.Text != "" ? nameBox.Text : "Аноним";
            String gender = femaleCheckBox.Checked ? "девушку" : "юношу";
            String ending = femaleCheckBox.Checked ? "ую" : "ого";

            String[] hobbyNames = { "музыкой", "спортом", "наукой", "живописью" };

            Boolean[] hobbiesCheckBoxes = { musicCheckBox.Checked, sportCheckBox.Checked, scienceCheckBox.Checked, artCheckBox.Checked };
            var hobbyDescriptions = 
                hobbyNames
                .Zip(hobbiesCheckBoxes, (hobby, check) => check ? hobby : "")
                .Where(elem => elem != "");

            String hobbies = hobbyDescriptions.Any() ?
                             String.Join(", ", hobbyDescriptions) :
                             "миром";

            String greeting = String.Format(greetingFormat, name, gender, ending, hobbies);
            outputLabel.Text = greeting;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
    }
}
