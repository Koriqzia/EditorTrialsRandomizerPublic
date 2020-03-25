using EditorTrialsRandomiser.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace EditorTrialsRandomiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void EffectToggle(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            ((ButtonContext)button.DataContext).isChecked = !((ButtonContext)button.DataContext).isChecked;
            button.Background = ((ButtonContext)button.DataContext).isChecked ? new SolidColorBrush(Color.FromArgb(255, 41, 0, 92)) : new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        List<string> VanillaEffects;

        private string GenerateEffects()
        {
            List<string> allSelectedEffects = new List<string> { };
            allSelectedEffects.AddRange(VanillaEffects);
            int effectCount = 5;

            if(VanillaEffects == null)
            {
                return "Please select an editing software first";
            }

            if (((ButtonContext)(((Button)otherEffectsButton).DataContext)).isChecked)
            {
                allSelectedEffects.AddRange(((ButtonContext)(((Button)otherEffectsButton).DataContext)).effects);
            }

            //Loop through all the controls, and if selected, join their lists to all the possible effects.
            foreach (Control control in EffectsPanel.Children)
            {
                var dataContext = (ButtonContext)control.DataContext;
                if (dataContext.isChecked)
                {
                    allSelectedEffects.AddRange(dataContext.effects);
                }
            }

            //Make Sure there are enough effects present in the list
            if(allSelectedEffects.Count < effectCount)
            {
                return "Not enought selected effects to generate list :(";
            }

            //Generate Random Effects
            string effectOutput = "";
            Random random = new Random(DateTime.Now.Millisecond);
            int count = allSelectedEffects.Count;

            for (int i = 0; i < effectCount; i++)
            {
                //Generate random index
                int index = random.Next(0, count);

                //Get effect
                effectOutput += allSelectedEffects[index] + Environment.NewLine;

                //Remove effect from list to avoid duplicate
                allSelectedEffects.RemoveAt(index);
                count--;
            }

            return effectOutput;
        }

        private void GenerateEffectsListButton_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text = GenerateEffects();
        }

        private void EditingProgramButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == AfterEffectsButton)
            {
                AfterEffectsButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                SonyVegasButton.BorderBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                VanillaEffects = ((ButtonContext)AfterEffectsButton.DataContext).effects;
            }
            else
            {
                SonyVegasButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                AfterEffectsButton.BorderBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                VanillaEffects = ((ButtonContext)SonyVegasButton.DataContext).effects;
            }
        }

        private void SaveEffectsListButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.Title = "Save Effects List";
            dialog.Filter = "Text File(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(dialog.FileName.Length > 0)
                {
                    File.WriteAllText(dialog.FileName, OutputLabel.Text);
                    File.WriteAllText(dialog.FileName.Replace(".txt", ".et"), Crypto.Encrypt(OutputLabel.Text, "qAl4mEdSSI", "Zt2jN2KXyz"));
                }
            }
        }
    }
}
