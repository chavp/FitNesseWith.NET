FitNesseWith.NET
================

TDD/ATDD/BDD/SpecificationByExample

Setup & Action

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

Reference

1. Fit for Developing Software: Framework for Integrated Tests http://www.amazon.com/Fit-Developing-Software-Framework-Integrated/dp/0321269349/ref=sr_1_1?ie=UTF8&qid=1402557029&sr=8-1&keywords=FitNesse
2. Agile Testing: A Practical Guide for Testers and Agile Teams 
3. http://www.amazon.com/Agile-Testing-Practical-Addison-Wesley-Signature-ebook/dp/B001QL5N4K/ref=sr_1_3?ie=UTF8&qid=1402557061&sr=8-3&keywords=FitNesse
4. Test Driven Development: By Example http://www.amazon.com/Test-Driven-Development-By-Example/dp/0321146530/ref=pd_bxgy_b_text_y
5. ATDD by Example: A Practical Guide to Acceptance Test-Driven Development http://www.amazon.com/ATDD-Example-Test-Driven-Development-Addison-Wesley/dp/0321784154/ref=sr_1_5?ie=UTF8&qid=1402557061&sr=8-5&keywords=FitNesse
6. Test Driven .NET Development with FitNesse http://gojko.net/FitNesse/book/
