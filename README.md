# LitRevResourceMVP
Record resources for assignments using MVP design C# winform .Net
The inspiration for this desktop application was found when, as a computer science student, a literature review was
required as part of the final project. Completing a practice review soon realised the importance of organising 
resources and identifing their relevence regardless of whether they were used or not. Argueing a point or comparing 
different views using these resources requires some form of organisation which failed when using just a word document.
The practice attempt was subsequently a bit of a mess.

The application has three forms to record a module, assignment, and resources. It is designed as a referal tool and
therefore currently does not include any output to a file. A relational database, SQL express, was used in the 
developement and so contains a dataset diagram for reference. 

The user can create a module in the module form where existing modules will be displayed in a list. On completion
it is then closed by the user and the assignment form opened. The module(s) will be displayed in a list which when
clicked will display assignments if they exist or a blank table. A new assignment is then created for the module
highlighted and the user closes the form when finished. The resources form is then opened which displays assignments
in a table which the user clicks and a table opens below containing resources already created or blank. CRUD events
are available for each form.

Resources are created for an assignment which is linked to a module as shown in the model classes and dataset diagram.
For each resource which it is assumed will be gathered from the internet, an active web link will be displayed, if one
is pasted in on creation. There are two rich text boxes to add notes about the resource and is intended to be used
in the write up of the review. Naturally ctl-c can be used as no right click function is included.

The resources include a category which is to be used to group resources which are linked to a specific area of the 
review. The categories are displayed in a list for referal when adding/editing, which is taken from the database using
a distinct sql query. They will therefore always be different for each assignment and can be changed by editing 
resources.

In the assignment main page a search function is included to search for a specific id number or a selection of resources
by category. 

Further developemnt:
Add function to change/add connectionstring for each user. Or dbconn setup.
Add unit tests.
Add graphs/tables when testing complete and used in real world. Not sure what would be useful.

