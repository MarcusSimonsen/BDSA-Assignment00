using Xunit;
using FluentAssertions;
using System;
using System.IO;

namespace Assignment00.Tests;

using System.Reflection;
public class UnitTest1
{
    [Fact]
    public void Echoes_each_word()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        program.EntryPoint?.Invoke(null, new[]{new String[]{"Hello there"}});

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("Hello there\nHello there\nHello there", output);
    }
}