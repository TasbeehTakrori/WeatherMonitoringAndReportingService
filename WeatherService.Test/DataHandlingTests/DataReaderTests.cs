﻿using AutoFixture.Xunit2;
using FluentAssertions;
using WeatherMonitoringAndReportingService.DataHandling;

namespace WeatherService.Test.DataHandlingTests
{
    public class DataReaderTests
    {
        [Theory]
        [AutoData]
        internal void ReadRawData_ShouldReadData(DataReader sut)
        {
            //Arrange
            var fakeInput = "Test input";
            using (var fakeInputReader = new StringReader(fakeInput))
            {
                Console.SetIn(fakeInputReader);

                //Act
                var rawData = sut.ReadRawData();

                //Assert
                rawData.Should().NotBeNullOrWhiteSpace();
            }
        }
    }
}
