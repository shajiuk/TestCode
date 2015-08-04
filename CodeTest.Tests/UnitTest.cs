using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private double _firstNumber = 0.0;
        private double _growthRate = 0.0;
        private string _completeSeries = string.Empty;

        [TestInitialize]
        public void SetUp()
        {
            _firstNumber = Series.GetFirstNumber(1);
            _growthRate = Series.GetGrowthRate(5062.5, _firstNumber);
            _completeSeries = Series.CompleteSeries(_firstNumber, _growthRate, 5);

        }


        [TestMethod]
        public void can_get_first_number()
        {
            Assert.IsNotNull(_firstNumber);
            Assert.AreEqual(1.62, _firstNumber);
          
        }

        [TestMethod]
        public void can_get_growth_rate()
        {
            Assert.IsNotNull(_firstNumber);
            Assert.IsNotNull(_growthRate);
            Assert.AreEqual(2.5, _growthRate);

        }

        [TestMethod]
        public void is_first_item_in_series_firstnumber()
        {

            Assert.IsNotNull(_firstNumber);
            Assert.IsNotNull(_growthRate);
            Assert.IsNotNull(_completeSeries);
            Assert.AreEqual(1.5, Series.SeriesToOrder[0]);

        }

        [TestMethod]
        public void has_the_correct_number_of_items_in_series()
        {
            Assert.IsNotNull(_firstNumber);
            Assert.IsNotNull(_growthRate);
            Assert.IsNotNull(_completeSeries);
            Assert.AreEqual(5, Series.SeriesToOrder.Count);

        }

        [TestMethod]
        public void is_ordered_correctly()
        {
            var lastVal = Series.SeriesToOrder[0];
            var numberItemsChecked = 1;
            foreach (var item in Series.SeriesToOrder)
            {
                if (item > lastVal)
                {
                    lastVal = item;
                    numberItemsChecked++;
                }
            }

            Assert.AreEqual(Series.SeriesToOrder.Count, numberItemsChecked);
        }

        [TestMethod]
        public void is_first_special_number_the_third_item()
        {
            Series.SpecialNumbers(1000, 160);
            Assert.AreEqual(Series.Number1, Series.SeriesToOrder[2]);
        }

        [TestMethod]
        public void is_the_correct_second_special_number()
        {
            Series.SpecialNumbers(1000, 160);
            Assert.AreEqual(Series.Number2, 6.5);

            Series.SpecialNumbers(1000, 100);
            Assert.AreEqual(Series.Number2, 10.75);
        }

        [TestMethod]
        public void is_calculating_approx_number_correctly()
        {
            var approx = 25 / 7;
            
            Assert.AreEqual(Series.ApproximateNumber(approx), 4);

        }
    }
}
