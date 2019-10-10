using AzurePipelinesToGitHubActionsConverter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AzurePipelinesToGitHubActionsConverter.Tests
{
    [TestClass]
    public class GlobalTest
    {
        [TestMethod]
        public void TestGetGlobalHeader()
        {
            //Arrange
            string expectedString = "# converted to GitHub Actions by https://github.com/samsmithnz/AzurePipelinesToGitHubActionsConverter on " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:sstt");

            //Act
            string output = Global.GetHeaderComment();

            //Assert
            Assert.AreEqual(output, expectedString);
        }

    }
}


//# ASP.NET Core
//# Build and test ASP.NET Core projects targeting .NET Core.
//# Add steps that run tests, create a NuGet package, deploy, and more:
//# https://docs.microsoft.com/azure/devops/pipelines/languages/dotnet-core

//trigger:
//- master

//pool:
//  vmImage: 'ubuntu-latest'

//variables:
//  buildConfiguration: 'Release'

//steps:
//- script: dotnet build --configuration $(buildConfiguration)
//  displayName: 'dotnet build $(buildConfiguration)'
