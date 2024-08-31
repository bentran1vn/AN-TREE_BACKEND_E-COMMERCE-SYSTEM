using System.Reflection;
using FluentAssertions;
using NetArchTest.Rules;
using Xunit;

namespace Antree_Ecommerce_BE.Tests;

public class ArchitectureTest
{
    private const string DomainNamespace = "Antree_Ecommerce_BE.Domain";
    private const string ApplicationNamespace = "Antree_Ecommerce_BE.Application";
    private const string InfrastructureNamespace = "Antree_Ecommerce_BE.Infrastructure";
    private const string PersistenceNamespace = "Antree_Ecommerce_BE.Persistence";
    private const string PresentationNamespace = "Antree_Ecommerce_BE.Presentation";
    private const string ApiNamespace = "Antree_Ecommerce_BE.API";
    
    [Fact]
    public void DomainShouldNotHaveDependencyOnOtherProject()
    {
        // Arrange
        Assembly assembly = Domain.AssemblyReference.Assembly;

        string[] otherProjects =
        [
            ApplicationNamespace,
            InfrastructureNamespace,
            PersistenceNamespace,
            PresentationNamespace,
            ApiNamespace
        ];

        // Act
        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(otherProjects)
            .GetResult();

        // Result
        testResult.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void PersistenceShouldNotHaveDependencyOnOtherProject()
    {
        // Arrange
        Assembly assembly = Domain.AssemblyReference.Assembly;

        string[] otherProjects =
        [
            ApplicationNamespace,
            InfrastructureNamespace,
            PresentationNamespace,
            ApiNamespace
        ];

        // Act
        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(otherProjects)
            .GetResult();

        // Result
        testResult.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void PresentationShouldNotHaveDependencyOnOtherProjects()
    {
        // Arrange
        var assembly = Presentation.AssemblyReference.Assembly;

        var otherProjects = new[]
        {
            InfrastructureNamespace,
            ApiNamespace
        };

        // Act
        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(otherProjects)
            .GetResult();

        // Assert
        testResult.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ApplicationShouldNotHaveDependencyOnOtherProjects()
    {
        // Arrange
        var assembly = Application.AssemblyReference.Assembly;

        var otherProjects = new[]
        {
            InfrastructureNamespace,
            //PersistenceNamespace, // Due to Implement sort multi columns by apply RawQuery with EntityFramework
            PresentationNamespace,
            ApiNamespace
        };

        // Act
        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(otherProjects)
            .GetResult();

        // Assert
        testResult.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void InfrastructureShouldNotHaveDependencyOnOtherProjects()
    {
        // Arrange
        var assembly = Infrastructure.AssemblyReference.Assembly;

        var otherProjects = new[]
        {
            PresentationNamespace,
            ApiNamespace
        };

        // Act
        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(otherProjects)
            .GetResult();

        // Assert
        testResult.IsSuccessful.Should().BeTrue();
    }

}