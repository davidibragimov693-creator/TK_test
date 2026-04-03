using System;

namespace OptimalWeightCalculator
{
    public class WeightCalculator
    {
        public static double CalculateOptimalWeight(int heightCm, bool isMale)
        {
            if (heightCm < 130 || heightCm > 220)
                throw new ArgumentOutOfRangeException(nameof(heightCm), "Рост должен быть в диапазоне 130-220 см");

            double baseWeight = heightCm - 100;
            if (isMale)
                return baseWeight * 1.13;
            else
                return baseWeight * 1.10;
        }

        public static string EvaluateWeight(double actualWeight, double optimalWeight)
        {
            if (actualWeight < 40 || actualWeight > 170)
                throw new ArgumentOutOfRangeException(nameof(actualWeight), "Вес должен быть в диапазоне 40-170 кг");

            double diff = actualWeight - optimalWeight;
            if (Math.Abs(diff) <= 3)
                return "норма";
            else if (diff < -3)
                return "ниже нормы";
            else
                return "выше нормы";
        }

        public static bool IsHeightValid(string input, out int height)
        {
            height = 0;
            if (!int.TryParse(input, out height))
                return false;
            return height >= 130 && height <= 220;
        }

        public static bool IsWeightValid(string input, out double weight)
        {
            weight = 0;
            if (!double.TryParse(input, out weight))
                return false;
            return weight >= 40 && weight <= 170;
        }
    }
}