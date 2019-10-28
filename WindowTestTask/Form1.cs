using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLibrary;

namespace WindowTestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Model dataModel;
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы XML|*.xml";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                diagramControl1.DeleteItems(diagramControl1.Items);
                dataModel = new Model(OPF.FileName);
                // Загрузка Щита обогрева
                foreach (var heatingPanel in dataModel.Diagram.element.HeatingPanel)
                {
                    diagramControl1.Items.Add(new ViewContainerHeatingPanel(
                        float.Parse(heatingPanel.Location.Split(new char[] { ';' })[0])
                        , float.Parse(heatingPanel.Location.Split(new char[] { ';' })[1])
                        , heatingPanel.IsEntryAutomateOn
                        , heatingPanel.IsNetworkOn
                        , heatingPanel.IsPowerOn
                        , heatingPanel.IsOnUps
                        , heatingPanel.Name
                        , heatingPanel.Temperature
                        , heatingPanel.IsInAlarm
                    ));
                }
                // Загрузка Датчика
                foreach (var sensor in dataModel.Diagram.element.Sensor)
                {
                    diagramControl1.Items.Add(new ViewSensor(
                        sensor.Temperature
                        ,sensor.State
                        , float.Parse(sensor.Location.Split(new char[] { ';' })[0])
                        , float.Parse(sensor.Location.Split(new char[] { ';' })[1])
                    ));
                }
                // Загрузка Линии обогрева
                foreach (var hLine in dataModel.Diagram.element.HeatingLine)
                {
                    diagramControl1.Items.Add(new ViewHeatingLine(
                        hLine.Temperature
                        ,hLine.State
                        , float.Parse(hLine.Location.Split(new char[] { ';' })[0])
                        , float.Parse(hLine.Location.Split(new char[] { ';' })[1])
                    ));
                }
            }

            

            /*
            

            foreach (var hp in dataModel.Diagram.element.HeatingLine)
            {
                hp.PrintConsoleInfo("HLine");
            }
            */
        }
    }

    

     

     

    

     

     

     

     
}
