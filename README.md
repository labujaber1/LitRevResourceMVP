
# LitRevResourceMVP
Record resources for assignments using MVP design C# winform .Netv5

## Why?
The inspiration for this desktop application was found when, as a computer science student, a literature review was
required as part of the final project. Completing a practice review soon realised the importance of organising 
resources and identifing their relevence regardless of whether they were used or not. Argueing a point or comparing 
different views using these resources requires some form of organisation which failed when using just a word document.
The practice attempt was subsequently a bit of a mess.

## Description
The application has three forms to record a module, assignment, and resources. It is designed as a referal tool and
therefore currently does not include any output to a file. A relational database, SQL express, was used in the 
developement and so contains a dataset diagram for reference. 

![image 5](/LitRevResourceMVP/blob/master/LitRevResource5.jpg?raw=True "Module page")

The user can create a module in the module form where existing modules will be displayed in a list. On completion
it is then closed by the user and the assignment form opened. The module(s) will be displayed in a list which when
clicked will display assignments if they exist or a blank table. A new assignment is then created for the module
highlighted and the user closes the form when finished. The resources form is then opened which displays all assignments
in a table which the user clicks and a table opens below containing resources already created or blank. CRUD events
are available for each form.

![image 3](/LitRevResourceMVP/blob/master/LitRevResource3.jpg?raw=True "Assignment page")

Resources are created for an assignment which is linked to a module as shown in the model classes and dataset diagram.
For each resource, which it is assumed will be gathered from the internet, an active web link will be displayed, if one
is pasted in on creation. There are two rich text boxes to add notes about the resource and is intended to be used
in the write up of the review. Naturally ctl-c can be used to copy/paste as no right click function is included.

![image 1](/LitRevResourceMVP/blob/master/LitRevResource1.jpg?raw=True "Resource page")

The resources include a category which is to be used to group resources that are linked to a specific area of the 
review. The categories are displayed in a list for referal when adding/editing, which is taken from the database using
a distinct sql query. They will therefore always be different for each assignment and can be changed by editing 
resources.

![image 4](/LitRevResourceMVP/blob/master/LitRevResource4.jpg?raw=True "Add new resource")

In the assignment main page a search function is included to search for a specific id number or group selection of resources
by category. By category is to help write a literature review for example when comparing different points of view on the
same subject. Its usefullness is dependent on how the user categorises the resources.

## Database
A SQL script has also been included in the app.data folder to create the current database with some other bits that may be 
of use. 

A connection string creator is also included accessed from the main nav bar (left) and includes CRUD functions. Whilst the
text refers to the app.config file on publication this really points to the .dll.config file when published. The connection
name has been set to read only so cannot be edited. If it is incorrect a new connection string will need to be created and 
the old deleted. If the string requires any additional settings such as timeout then this can be edited in and saved after 
its creation. The table is created directly from the app.config file so nothing is stored elsewhere. The user takes 
responsibilty for the correct connection string entered as it is assumed they have some knowledge in this area. 

![image 2](/LitRevResourceMVP/blob/master/LitRevResource2.jpg?raw=True "Create connection string")

An example connection string is included and will naturally not work until the database is created using a SQL script provided. 


# Further developement:
Add unit tests.
Add ability to use different databases such as ode, mysql, etc.
Add ability to choose between embedded or external database.
Either complete or delete connection wizard that searches for servers and databases. 
Include a class to create embedded script?
