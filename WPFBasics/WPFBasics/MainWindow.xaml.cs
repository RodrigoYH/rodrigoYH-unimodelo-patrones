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

namespace WPFBasics
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnApply_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"La descripción es: {this.txtDescription.Text}");
		}

		private void BtnReset_Click(object sender, RoutedEventArgs e)
		{
			this.chkSoldar.IsChecked = this.chkEnsamblador.IsChecked = this.chkPlasma.IsChecked = this.chkPlasma.IsChecked = 
				this.chkLaser.IsChecked = chkVentas.IsChecked = this.chkTorno.IsChecked = this.chkPerforador.IsChecked = 
				this.chkDoblez.IsChecked = this.chkRodar.IsChecked = this.chkSierra.IsChecked = false;
		}

		private void Checkbox_Checked(object sender, RoutedEventArgs e)
		{
			this.txtLength.Text += ((CheckBox)sender).Content;
		}

		private void CmbFinish_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(this.txtNotes==null)
			{
				return;
			}

			var combo = (ComboBox)sender;
			var value = (ComboBoxItem)combo.SelectedValue;

			this.txtNotes.Text = (string)value.Content;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			CmbFinish_SelectionChanged(this.cmbFinish, null);
		}

		private void TxtSupplierName_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.txtMass.Text = this.txtSupplierName.Text;
		}
	}
}
