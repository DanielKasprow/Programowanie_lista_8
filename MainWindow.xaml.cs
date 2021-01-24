using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Microsoft.Reporting;
using Microsoft.ReportingServices;
using Microsoft.Reporting.WinForms;

namespace Daniel_Kasprów_lista_8v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rptViewer.ProcessingMode = ProcessingMode.Remote;

            rptViewer.ServerReport.ReportServerUrl = new Uri("http://desktop-3sj6cnc/ReportServer", UriKind.Absolute);

            rptViewer.ServerReport.ReportPath = "/Test/Report1";

            rptViewer.RefreshReport();
        }
    }
}
