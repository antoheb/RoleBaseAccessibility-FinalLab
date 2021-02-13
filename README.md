# RoleBaseAccessibility-FinalLab

#First test case
-----------------------------------
User 1 not connected
-----------------------------------

1. Have only access to the public docs page
2. Have no access to any other pages



#Second test case
-----------------------------------
User 1 connected with the role Admin
-----------------------------------

1. Have access to all the pages included the admin only link
2. Can access any pages


#Third test case
---------------------------------------------
User 2 connected with the roles Admin and User
---------------------------------------------

1. Have access to all the pages included the admin only link
2. Can access any pages


#Fourth test case
---------------------------------------------
User 3 connected with only the role User
---------------------------------------------

1. Do not have access to the admin only link
2. Do not have access to the systems docs page
3. Have access to all the other document pages (public, private and confidential)


#Fifth test case
---------------------------------------------
User 4 connected with only the role UserLevel2
---------------------------------------------

1. Do not have access to the admin only link
2. Do not have access to the systems docs page
3. Have access to all the other document pages (public, private and confidential)


#Sixth test case
---------------------------------------------
User 5 connected with only the role UserLevel3
---------------------------------------------

1. Do not have access to the admin only link
2. Do not have access to the confidential document page
3. Have access to all the other document pages included the system docs (public, private, system)
