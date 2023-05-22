using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private HouseStorage storage;

        public Form()
        {
            InitializeComponent();
            storage = new HouseStorage();
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            try
            {
                storage.InsertData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveToFiles_Click(object sender, EventArgs e)
        {
            try
            {
                storage.SaveToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetFilteredData_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Text = "";
                var list = storage.GetFilteredList(textBoxStreet.Text);
                if (list != null)
                {
                    foreach (var el in list)
                    {
                        textBoxResult.Text += el.Street + el.Num.ToString() + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
