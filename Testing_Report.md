# Testing of the Project

Report and status of testing of various components is listed here

## Overview  

* **Login Page:** Tested and working as expected
* **Student Homepage:** All services funtional
* **Apply Leave form (for Staff, Prof, HOD, Dean, Dir):** Fully Functional
* **Office:** Fully Functional
* **Leave approval/decline portal (for Prof, HoD, Dean, DPPC):** Fully functional

```
For details about components and forms, refer to documentation 
```
## Login Page
This is the starting point of the application

### Components status
* All components tested and functional



### Past issues
None

## Student Page

Covers:    All services for student users

### Components status
* All components tested and functional



### Past issues
* Change password option

**Problem:** When Changing password 2 times in a row, can't use the new passowrd in the 2nd attempt    
**Steps to recreate:** Open a student profile > Edit profile > Change Password once > Try to change password once again using the new password set up in previous step  
**Cause:** The old password is fetched when the student homepage form is loaded, it wasn't updated after changing password 
**Fix:** The hash value stored in the variable *password* has been set to update when the password updates  
**Status:** Fixed


* Adding ordinary leaves

**Problem:** If applied for 2 consecutive ordinary leaves totaling to more than 5 days, despite telling the user that it's not allowed a leave application is pushed to database   
Also when this situation occurs, the testing for 'OL' being less than 5 is breached through and even extremly long Ordinary leaves (well over 20 days) are pushed to database   
**Cause:** There seems to be missing cases in the If Else chain used in Sub NAApplyButton_Click   
**Fix:** No fix as of now   
**Status:** Pending -> **FIXED**
**Comments (Siddharth)** OL can't span for more than 5 days in one go, but total can be greater than 5. 
How were you able to save OL with 20 days?
kindly give the steps with exact dates.
thanks   
**Steps To Recreate:** Apply for an ordinary leave > Apply again, the starting date this time should be immediately next to the ending date last time, select the ending date with a 15 days gap and apply


* Mediacal, Academic and Parental Leaves 

**Problem:** For extra long leaves, even if the user declines to apply the application is pushed to DB    
**Steps to recreate:** Open student homepage > Apply > Try to Apply for academic leave of 1 month > When propmted wheather want to continue or not, choose 'No' > The application will still be pushed to DB   
**Cause:**  The boolean variable getting the response always evaluates to true  
**Fix:**  Changing all instances of  
```
Dim ans As Boolean = MessageBox....
```
To
```
Dim ans As DialogResult = Message...
```
And changing all corresponding If-Else conditions with
```
If ans = DialogResult.Yes
```
**Status:** Fixed


* Visual Feedback when applying ordinary leave

**Problem:** When longer than permitted Ordinary Leaves are applied, although there's no application submitted, the user gets to visual response   
**Steps to recreate:** Student Homepage > Apply > Ordinary leave > Dates more than 5 days apart and not adjacent to other leaves   
**Cause:** Missing message box   
**Status:** Being worked on by siddharth  -> **FIXED** 



## Leave Apply Form

This works as:     
1. Complete functionality of Director and Staff
1. One Component of Prof, Dean, HoD



### Components status
* All components tested and functional


### Past issues

* Any date combination works
**Problem:** Leaves show error when needed but are pushed to DB   
**Steps to recreate:** Open leave apply form > Attempt an obviously wrong date combination > Apply   
**Cause:** Missed cases when using Flags to test leave application   
**Fix:** Using "Exit Sub" to stop attempting to apply whenever illegal combination is encountered    
**Status:** Fixed   

* DB is not tested for presence of duplicate leaves   
**Problem:** Same leave can be applied any number of times   
**Steps to recreate:** Open leave apply form > Apply a valid date combination > Apply > Attempt an overlapping date combination > Apply   
**Cause:** TO check in database for overlapping   
**Fix:** Add a database comparision for overlap   
**Status:** Fixed    



## Office Form

Covers:    
Full functionality of Office    

### Components status
* All components tested and functional


### Past issues

* Can't update user password  

**Problem:** Message box with 'Syntax error' pops up whenever a user passowrd is updated  
**Steps to recreate:** Open office form > Open update user form > Attempt to update password  
**Cause:** Password is a reserved keyword of the access database engine, using it as column name can cause unintended results  
**Fix:** Changed column name in query from   
```field name``` to ``` [field name] ```   
**Status:** Fixed

* Forms don't clear up  

**Problem:** The 3 forms to add/delete/update users don't clear up once used. Makes it cumbersome to use them multiple times as every field needs to be manually cleared  
**Steps to recreate:** Open office form > use one of the forms to successfully add/delete/update users > close them and they still have valuse from last time  
**Cause:** No instructions to clear fields  
**Fix:** Add the necessary code after the success messageBox is shown    
**Status:** Fixed

* Connection not closed after deleting user

**Problem:** Attempting any connection to database after making a failed attempt in deleting user gives connection not closed error   
**Steps to recreate:** Open office home > Delete user form > Attempt to delete a user that doesn't exist > close form and try somehting that needs DB connection (Eg. load a username info)  
**Cause:** If a delete user attempt gets a non-existent user as input, it directly breaks out of Sub without closing conections     
**Fix:** Close connections before exiting the Sub     
**Status:** Fixed   

* Updating user, no checks   

**Problem:** Unlike the add user form, there are no checks to see what is being entered where, letters can go to phone and fields can go empty   
**Steps to recreate:** Office home > Update user > Attempt an invalid update > confirm by loading user data on office home form    
**Cause:** No checks on input    
**Fix:** Add checks for all inputs   
**Status:** Fixed    

* Student lastname zero length error   

**Problem:** When attempting to make a new student user, lastname field can't be zero length exception is thrown    
**Steps to recreate:** Office homapage > add user > Student user > Fill each field except Last Name > Apply > error along the lines of "Student.LastName cannot be a zero length string"     
**Cause:** It may be a required value in database     
**Fix:** Editing the forms in database and remove required from lastname field in Students form    
**Status:** Fixed




## Rest Users Form
Covers:    
1. Full functionality of DPPC
1. Part functionality of Prof, HoD and Dean

### Components status
* All components tested and functional


### Past issues
None
