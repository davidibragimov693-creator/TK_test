using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OptimalWeightCalculator;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateOptimalWeight_Male180cm_Returns90Point4()
        {
            // Arrange
            int height = 180;
            bool isMale = true;

            // Act
            double result = WeightCalculator.CalculateOptimalWeight(height, isMale);

            // Assert
            Assert.AreEqual(90.4, result, 0.1);
        }

        [TestMethod]
        public void CalculateOptimalWeight_Female165cm_Returns71Point5()
        {
            // Arrange
            int height = 165;
            bool isMale = false;

            // Act
            double result = WeightCalculator.CalculateOptimalWeight(height, isMale);

            // Assert
            Assert.AreEqual(71.5, result, 0.1);
        }
        [TestMethod]
        public void CalculateOptimalWeight_Male130cm_Returns33Point9()
        {
            // Arrange
            int height = 130;
            bool isMale = true;

            // Act
            double result = WeightCalculator.CalculateOptimalWeight(height, isMale);

            // Assert
            Assert.AreEqual(33.9, result, 0.1);
        }
        [TestMethod]
        public void CalculateOptimalWeight_Female220cm_Returns132()
        {
            // Arrange
            int height = 220;
            bool isMale = false;

            // Act
            double result = WeightCalculator.CalculateOptimalWeight(height, isMale);

            // Assert
            Assert.AreEqual(132.0, result, 0.1);
        }
        [TestMethod]




        // ========== ТЕСТЫ ОЦЕНКИ ВЕСА ==========

        public void EvaluateWeight_85kgVs90Point4_ReturnsBelowNormal()
        {
            // Arrange
            double actualWeight = 85;
            double optimalWeight = 90.4;

            // Act
            string result = WeightCalculator.EvaluateWeight(actualWeight, optimalWeight);

            // Assert
            Assert.AreEqual("ниже нормы", result);
        }
        [TestMethod]
        public void EvaluateWeight_90kgVs90Point4_ReturnsNormal()
        {
            // Arrange
            double actualWeight = 90;
            double optimalWeight = 90.4;

            // Act
            string result = WeightCalculator.EvaluateWeight(actualWeight, optimalWeight);

            // Assert
            Assert.AreEqual("норма", result);
        }
        [TestMethod]
        public void EvaluateWeight_93kgVs90Point4_ReturnsNormal()
        {
            // Arrange
            double actualWeight = 93;
            double optimalWeight = 90.4;

            // Act
            string result = WeightCalculator.EvaluateWeight(actualWeight, optimalWeight);

            // Assert
            Assert.AreEqual("норма", result);
        }
        [TestMethod]
        public void EvaluateWeight_94kgVs90Point4_ReturnsAboveNormal()
        {
            // Arrange
            double actualWeight = 94;
            double optimalWeight = 90.4;

            // Act
            string result = WeightCalculator.EvaluateWeight(actualWeight, optimalWeight);

            // Assert
            Assert.AreEqual("выше нормы", result);
        }


        [TestMethod]

        // ========== ТЕСТЫ ВАЛИДАЦИИ РОСТА ==========

        public void IsHeightValid_180_ReturnsTrue()
        {
            // Arrange
            string input = "180";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(180, value);
        }
        [TestMethod]
        public void IsHeightValid_130_ReturnsTrue()
        {
            // Arrange
            string input = "130";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(130, value);
        }
        [TestMethod]
        public void IsHeightValid_220_ReturnsTrue()
        {
            // Arrange
            string input = "220";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(220, value);
        }
        [TestMethod]
        public void IsHeightValid_129_ReturnsFalse()
        {
            // Arrange
            string input = "129";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void IsHeightValid_221_ReturnsFalse()
        {
            // Arrange
            string input = "221";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void IsHeightValid_Abc_ReturnsFalse()
        {
            // Arrange
            string input = "abc";

            // Act
            bool isValid = WeightCalculator.IsHeightValid(input, out int value);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        // ========== ТЕСТЫ ВАЛИДАЦИИ ВЕСА ==========

        public void IsWeightValid_70_ReturnsTrue()
        {
            // Arrange
            string input = "70";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(70, value, 0.01);
        }
        [TestMethod]
        public void IsWeightValid_40_ReturnsTrue()
        {
            // Arrange
            string input = "40";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(40, value, 0.01);
        }
        [TestMethod]
        public void IsWeightValid_170_ReturnsTrue()
        {
            // Arrange
            string input = "170";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(170, value, 0.01);
        }
        [TestMethod]
        public void IsWeightValid_39Point9_ReturnsFalse()
        {
            // Arrange
            string input = "39.9";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void IsWeightValid_170Point1_ReturnsFalse()
        {
            // Arrange
            string input = "170.1";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]

        public void IsWeightValid_12q_ReturnsFalse()
        {
            // Arrange
            string input = "12q";

            // Act
            bool isValid = WeightCalculator.IsWeightValid(input, out double value);

            // Assert
            Assert.IsFalse(isValid);
        }
    }
}
