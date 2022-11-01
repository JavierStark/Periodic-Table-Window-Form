using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TableForm : Form
    {
        PeriodicTableHandler periodicTableHandler = new PeriodicTableHandler();

        InfoForm currentInfoForm; 

        public TableForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Element element in periodicTableHandler.GetElementsTable())
            {
                int column = element.xpos-1;
                int row = element.ypos-1;

                Button currentButton = new Button() { Name = $"button_{column}_{row}", Text = element.symbol, Width = 53, Height = 50 };
                currentButton.Click += (eventSender, eventArgs) => OpenElementForm(eventSender, eventArgs, element);
                tableLayoutPanel1.Controls.Add(currentButton, column, row);
            }
            
        } 
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void OpenElementForm(object sender, EventArgs e, Element element)
        {
            if(currentInfoForm != null)
            {
                currentInfoForm.Close();
            }
            InfoForm elementInfoForm = new InfoForm(element);
            elementInfoForm.Show();
            elementInfoForm.Activate();
            currentInfoForm = elementInfoForm;

        }
    }
}
