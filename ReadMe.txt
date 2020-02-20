
To setup Database follow the below mentioned instructions

1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
 
 Update-Database Identity -Context ApplicationDbContext

5. On the console execute the following command

Update-Database Movie -Context Movie_Purchase_MVC_DB_Context

6. After migration is successful Run the project 


Note :- User can see the list of customers, movies and Rented movies without login into the system but to add, delete and edit customer, movie or rent movie user need to login into the system. 
