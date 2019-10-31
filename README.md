# Moraba.Converter.Core

  simple and light converter for use in .NET Core projects. 

## Adding Moraba.Converter.Core package to your .NET Core project

  you can add this package from nuget.

## Package Manager
   Install-Package Moraba.Converter.Core -Version 1.0.1
## .NET CLI 
   dotnet add package Moraba.Converter.Core --version 1.0.1
   
## usage

```c#

      try
      {
          string persianNumbers = "۱۲۳۴۵"; 
          string englishNumber = Moraba.Converter.Numbers.Convert.PersianToEnglish(persianNumbers);
          //output : "12345"
      }
      catch (Exception ex)
      {
          Console.WriteLine(ex.Message);
      } 

``` 
