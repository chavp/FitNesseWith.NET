FitNesseWith.NET
================

TDD/ATDD/BDD/SpecificationByExample

setup & action

1. downlaod & install JAVA see http://www.oracle.com/technetwork/java/javase/downloads/index.html?ssSourceSiteId=otnjp
2. download file fitnesse-standalone.jar from http://www.fitnesse.org/FitNesseDownload
3. download file release.2.2.net.40.zip Slim Plug-In for .NET from https://github.com/jediwhale/fitsharp/downloads
4. start fitnesse-standalone server cmd->java -jar fitnesse-standalone.jar
5. create unit-test project FizzBuzzTest
6. add class TimesheetColumnFixture.cs 
7. extract file release.2.2.net.40.zip and copy to folder fitSharp
8. goto unit-test project FizzBuzzTest and reference lib fitSharp\fit.dll
9. coding TimesheetColumnFixture.cs see https://github.com/chavp/FitNesseWith.NET/blob/master/FizzBuzzTest/FizzBuzzTest/FizzBuzzColumnFixture.cs
10. unit-test project FizzBuzzTest set Properties -> Build -> Output path: ..\..\test\FizzBuzzTestBuild\
11. goto browser enter http://localhost/root
12. Add test Page enter name FizzBuzz and enter wiki script see https://github.com/chavp/FitNesseWith.NET/blob/master/FitNesseRoot/FizzBuzz/content.txt
13. Save test Page and click Test
14. FIN
