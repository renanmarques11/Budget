# Budget
Budget is a desktop application for budgeting and tracking. 
The objective was to apply the 4 basic operations used in relational databases (CRUD) and the MVVM standard. 
This project was developed with .Net Framework, WPF, and SQLite.

The project, as previously mentioned, was developed using the MVVM standard. The organization was as follows:

![MVVM](https://user-images.githubusercontent.com/75442450/162443445-1bce7de3-4ea4-4474-9b00-f8f32ec770ae.JPG)

This is the main screen of the program, where we can navigate to the others.
Here we already have some budget and registered items for a better presentation of the functionalities.
Below the title we have two totalizers, "Projection" and "Execution", which add up the totals of the budgets and the items linked to each of them.
Here we notice that, with the exception of the "New Budget" button, all others are inactive until a budget is selected.

The "Delete Budget" option allows you to delete a budget and all its registered items in just one click.

![image](https://user-images.githubusercontent.com/75442450/162441089-46c66a6e-b0dc-4389-afd6-b0edf98bce0f.png)

The "New Budget" button allows a new budget to be registered, informing whether it is an expense or income, as well as its respective value stipulated for that year.

![Insert Budget](https://user-images.githubusercontent.com/75442450/162443372-d816c8a4-df59-4338-9b8a-cba4b891256c.JPG)

In "Update Budget and Insert Item" we can change the previously registered budget, as well as include or modify the items that compose it.

![Update Budget](https://user-images.githubusercontent.com/75442450/162443398-ec569402-72b1-41c2-82d8-7f89a93d05ad.JPG)

Finally, the visualization of a specific budget can be done using the "View Budget" option, which will also allow the visualization of all linked items.

![View Budget](https://user-images.githubusercontent.com/75442450/162443420-f5665ffd-c91b-4f09-9905-c11640564355.JPG)












