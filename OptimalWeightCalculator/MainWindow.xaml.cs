using System;
using System.Windows;

namespace OptimalWeightCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!WeightCalculator.IsHeightValid(tbHeight.Text, out int height))
                {
                    tbResult.Text = "Ошибка: рост должен быть целым числом от 130 до 220 см.";
                    return;
                }

                if (!WeightCalculator.IsWeightValid(tbWeight.Text, out double weight))
                {
                    tbResult.Text = "Ошибка: вес должен быть числом от 40 до 170 кг.";
                    return;
                }

                bool isMale = rbMale.IsChecked == true;
                double optimal = WeightCalculator.CalculateOptimalWeight(height, isMale);
                string evaluation = WeightCalculator.EvaluateWeight(weight, optimal);

                tbResult.Text = $"Оптимальный вес: {optimal:F1} кг\n" +
                                $"Ваш вес: {weight:F1} кг\n" +
                                $"Оценка: {evaluation}";
            }
            catch (Exception ex)
            {
                tbResult.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}