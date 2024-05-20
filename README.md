# Warehouse management – C# - WinForms & SQL Server

A warehouse management project with user types that each have different permissions in the software,
In order to give the possibility to manage a central warehouse that receives goods and transfers them to the branches of its stores,
A regular user who has permission to perform the operations of the daily functioning of the warehouse.
A user with administrator privileges can add users to employees and branches and anything that only management is supposed to do.

# Click on the image to see the video about the project:
[![Watch the video](https://i.ytimg.com/vi/OAqAjuL1FuE/hqdefault.jpg?sqp=-oaymwEbCKgBEF5IVfKriqkDDggBFQAAiEIYAXABwAEG\u0026rs=AOn4CLDMs7lWxAVLEGpTGAFsjJ3RqOMSEQ)](https://www.youtube.com/watch?v=OAqAjuL1FuE)

Actions can be performed by user type
* Admin - all permissions are open
* User - only permissions related to partner operation of the warehouse

@ All information is saved in the database 
### In the login window Can be made:
* Connection with normal user types / system administrators
* Password reset is done by receiving an email to the address reserved for the same user name with a new temporary password.

### After logging in Can be made:
* Normal user:
  - Password reset when we are connected
  - Ordering products from suppliers that work with the warehouse
  - Viewing the existing stock in the warehouse
  - Viewing orders that need to arrive at the warehouse
  - Export data to an Excel file
  - Sending products that are in stock to the branches
* Admin user:
  - A management button will open
  - Adding a supplier with products he is allowed to supply
  - Adding products to an existing supplier
  - Deletion of products from an existing supplier
  - Deletion of an existing provider
  - A branch was added
  - Creating a new user

## Technologies:
* WinForms
* Sql Server
