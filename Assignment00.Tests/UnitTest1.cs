using Xunit;
using FluentAssertions;
using System;
using System.IO;
using System.Reflection;

namespace Assignment00.Tests;

using System.Reflection;
public class UnitTest1
{
    [Fact]ssssssss
    public void Main_when_run_prints_hello_world()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Assignment00));
        program.EntryPoint?.Invoke(null, new[]{new String[]{"Hello there"}});

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("Hello, World!", output);
    }
}