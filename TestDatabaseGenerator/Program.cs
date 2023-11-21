// See https://aka.ms/new-console-template for more information

using TestDatabaseGenerator.Models;
using TestDatabaseGenerator.Generators;
using Microsoft.EntityFrameworkCore;

var context = new ArmsSpectrumDevelopmentContext();

//PartsMasterGenerator partsMasterGenerator = new PartsMasterGenerator(context);

//partsMasterGenerator.Generate();


AcMasterGenerator acMasterGenerator = new AcMasterGenerator(context);

acMasterGenerator.Generate();