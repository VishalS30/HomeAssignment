# HomeAssignment

- If we want to add a new provider we can simply add new class library and implement IProductImport interface. The adapter will responsible to fetch the data from csv file.
- Introduced a property Additional Data . This is very important and useful. If suppose some another provider is sending  other social media details (FB or LinkedIn).
   we dont need to change Response model everytime. we can simple pass the data in Additional Data.This method is very important when we do the things in                  implementation  branch(specifict to a paticular client).
- There is no challenge to use different-2 Db . We can register the multiple connection string in app setting. we just need to install corrsponding package (MongoDb,     Sql , CosmosDb etc). We can create a DbContext factory which will resolve the DbContext as per adapter. To resolving contet willl be responsibility of Respository     class.

  - How to run your code / tests
  Steps to Run
 1. Add Feeds folder in C:\Temp
2. Open Project and restore packages.
3. Build the solution.
4. Run the Api
5. Add /swagger in the Api url i.e(https://localhost:7056/swagger).
6. On Swagger interface click on post and then Try it out.
7. Choose provider name as Capterra Or SoftwareAdvice.
8. It will pull the records of the capterra.yaml or softwareadvice.json 

  - Where to find your code

 https://github.com/VishalS30/HomeAssignment/tree/master
  - Was it your first time writing a unit test, using a particular framework, etc?   
   No , I have the experience to write unit test case
  - What would you have done differently if you had had more time.   
   If i had more time i will complete all the test case. Add logging etc.
  - Etc.











