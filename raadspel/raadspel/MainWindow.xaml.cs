using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        int randomNumber;
        int pickedNumber;
        int amountTries;

        public MainWindow()
        {
            InitializeComponent();
            randomNumber = rnd.Next(1, 100);
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out pickedNumber);

            amountTries += 1;
            output2TextBox.Text = $"Aantal keren geraden: {amountTries}";
            
            if (pickedNumber == randomNumber)
            {
                output1TextBox.Text = "Proficiat! U hebt het getal geraden!";
            }
            else if (pickedNumber > randomNumber)
            {
                output1TextBox.Text = "Raad lager!";
            }
            else if (pickedNumber < randomNumber)
            {
                output1TextBox.Text = "Raad hoger!";
            }
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            pickedNumber = 0;
            amountTries = 0;

            numberTextBox.Clear();
            output1TextBox.Clear();
            output2TextBox.Clear();

            randomNumber = rnd.Next(1, 100);
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}