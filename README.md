# DuplicatedJsonProperties

Sample project showing how to use handle duplicated properties in JSON with Newtonsoft package.

Description:
https://angryduckdev.wordpress.com/2019/03/16/how-to-handle-duplicated-properties-in-json/

This is a RESTful JSON API created as a homework Assignment #2 for
https://pirple.thinkific.com/courses/the-nodejs-master-class

//About app , features, external APIs.

Routes:
# USERS

|Method|Required header|Required payload|Optional payload|
|------|---------------|----------------|----------------|
|`GET`   |token id|||
|`PUT`   |token id|||
|`POST`  |token id|||
|`DELETE`|token id|||

# TOKENS
|Method|Required header|Required payload|Optional payload|
|------|---------------|----------------|----------------|
|`GET`   |token id|||
|`PUT`   |token id|||
|`POST`  |token id|||
|`DELETE`|token id|||

# MENU

|Method|Required header|Required payload|Optional payload|
|------|---------------|----------------|----------------|
|`GET`   |token id|||

# ORDERS
|Method|Required header|Required payload|Optional payload|
|------|---------------|----------------|----------------|
|`GET`   |token id|||
|`PUT`   |token id|||
|`POST`  |token id|||
|`DELETE`|token id|||

# SHOPPING_CART
|Method|Required header|Required payload|Optional payload|
|------|---------------|----------------|----------------|
|`GET`   |token id|||
|`PUT`   |token id|||
|`DELETE`|token id|||

How to use?
Basic scenarios:
1. Create a user.
2. Log in.
3. View menu.
4. Order a pizza.
5. Pay for the order.
6. Check email for a receipt.
7. Log out.

All scenarios by route
Users
1. Create a user (an account).
2. Get user's data.
3. Update user's data.
4. Delete a user (an accont).

Tokens
1. Create a token (log into an account).
2. Get token's data (expiration date and time).
3. Extend token's expiration date.
4. Delete a token (log out).

Menu
1. Get the menu.

Shopping cart
1. Create an order (select items from menu).
2. List existing orders (items chosen but not yet purchased).
3. Delete an order.

Orders
1. Pay for an order.
2. Create an order and pay for it in 1 request.
