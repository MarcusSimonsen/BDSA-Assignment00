using Xunit;
using FluentAssertions;
using System;
using System.IO;
using System.Reflection;

namespace Assignment00.Tests;

using System.Reflection;
public class UnitTest1
{
    [Fact]
    public void Main_when_run_asks_for_year()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        program.EntryPoint?.Invoke(null, new[]{Array.Empty<String>()});

        //Assert
        var output = writer.GetStringBuilder().ToString();
        Assert.Equal("Please enter a year: ", output);
    }

    [Fact]
    public void IsLeapYear_true_when_divisible_by_four()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        var result4 = LeapYear.IsLeapYear(4);
        var result8 = LeapYear.IsLeapYear(8);
        var result16 = LeapYear.IsLeapYear(16);

        //Assert
        Assert.True(result4);
        Assert.True(result8);
        Assert.True(result16);
    }

    [Fact]
    public void IsLeapYear_false_when_not_divisible_by_four()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        var result3 = LeapYear.IsLeapYear(3);
        var result7 = LeapYear.IsLeapYear(7);
        var result101 = LeapYear.IsLeapYear(101);

        //Assert
        Assert.False(result3);
        Assert.False(result7);
        Assert.False(result101);
    }

    [Fact]
    public void IsLeapYear_false_when_divisble_by_exactly_100()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        var result100 = LeapYear.IsLeapYear(100);
        var result300 = LeapYear.IsLeapYear(300);
        var result1000 = LeapYear.IsLeapYear(1000);

        //Assert
        Assert.False(result100);
        Assert.False(result300);
        Assert.False(result1000);
    }

    [Fact]
    public void IsLeapYear_true_when_divisible_by_exactly_400()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        var result400 = LeapYear.IsLeapYear(400);
        var result800 = LeapYear.IsLeapYear(800);
        var result1600 = LeapYear.IsLeapYear(1600);

        //Assert
        Assert.True(result400);
        Assert.True(result800);
        Assert.True(result1600);
    }
}