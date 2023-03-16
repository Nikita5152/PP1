using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.baseDataSetTableAdapters;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        HumanTableAdapter sss = new HumanTableAdapter();
        TovarTableAdapter aaa = new TovarTableAdapter();
        public MainWindow()
        {

            InitializeComponent();
            HumanDataGrid.ItemsSource = sss.GetData();
            TovarComboBox.ItemsSource = aaa.GetData();
            TovarComboBox.DisplayMemberPath = "Title";
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (TovarComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}
