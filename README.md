# Moraba.Converter.Core

  simple and light converter for use in .NET Core projects. 

## Adding Moraba.Converter.Core package to your .NET Core project

  you can add this package from nuget.

## Package Manager
   Install-Package Moraba.Converter.Core -Version 1.0.2
## .NET CLI 
   dotnet add package Moraba.Converter.Core --version 1.0.2
   
## usage

```c#

      try
      {
          string persianNumbers = "-۱۲۳۴۵"; 
          string englishNumber = Moraba.Converter.Numbers.Convert.PersianToEnglishInt32(persianNumbers);
          //output : "-12345"
      }
      catch (Exception ex)
      {
          Console.WriteLine(ex.Message);
      } 

``` 
##
![https://www.nuget.org/packages/Moraba.Converter.Core](https://raw.githubusercontent.com/mojtabamoradi/converter/master/Converter/logo.png)
