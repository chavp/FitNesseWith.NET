FitNesseWith.NET
================

TDD/ATDD/BDD/SpecificationByExample

setup & action

1. Downlaod & install JAVA see http://www.oracle.com/technetwork/java/javase/downloads/index.html?ssSourceSiteId=otnjp
2. Download file fitnesse-standalone.jar from http://www.fitnesse.org/FitNesseDownload
3. Download file release.2.2.net.40.zip Slim Plug-In for .NET from https://github.com/jediwhale/fitsharp/downloads
4. Dtart fitnesse-standalone server cmd->java -jar fitnesse-standalone.jar
5. Create unit-test project FizzBuzzTest
6. Add class TimesheetColumnFixture.cs 
7. Extract file release.2.2.net.40.zip and copy to folder fitSharp
8. Goto unit-test project FizzBuzzTest and reference lib fitSharp\fit.dll
9. Code TimesheetColumnFixture.cs see https://github.com/chavp/FitNesseWith.NET/blob/master/FizzBuzzTest/FizzBuzzTest/FizzBuzzColumnFixture.cs
10. Unit-test project FizzBuzzTest set Properties -> Build -> Output path: ..\..\test\FizzBuzzTestBuild\
11. Goto browser enter http://localhost/root
12. Add test Page enter name FizzBuzz and enter wiki script see https://github.com/chavp/FitNesseWith.NET/blob/master/FitNesseRoot/FizzBuzz/content.txt
13. Save test Page & Click Test
14. FIN
