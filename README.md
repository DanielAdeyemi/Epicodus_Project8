## <div align="center">Vendor and Order Tracker</div>
#### <div align="center">📚 *Epicodus Independent Project # 8  (Week 2 of C#)  3/5/2021* </div> 
***<p align="right">By Daniel Adeyemi***</p>   
<p align="center">

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>    
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.

<div style="text-align:center"><img src="https://bloximages.chicago2.vip.townnews.com/pantagraph.com/content/tncms/assets/v3/editorial/a/49/a491b6a3-1123-5035-9001-679ed7efedf8/602ad6fae2e52.image.jpg?resize=500%2C751" alt="Bakery image" width="300"/></div>

___
## 🚩 *Description*:    
### *Time to follow your orders!*
##### *An MVC app to track the vendors that purchase baked goods and order belonging to those vendors. User will be able to create vendors and different orders inside specific vendor as well as see details of order and navigate between different pages. This project demonstrates knowledge of using Razor, MVC and other concepts to successfully build web application.*


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Epicodus_Project8.git).
* * At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

<img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>

* Unzip the file, navigate to the `Bakery/Models` directory to check code or to the `Bakery.Tests/ModelTests` directory to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Epicodus_Project8.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet).*
### 📋 Specs:
![check-code-coverage](https://img.shields.io/badge/code--coverage-100%25-brightgreen)
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :-------------: | :------------: | :-------------: |
|  |  | ***Constractors*** |  |  |
| 01 | Create a constractor for order w/properties| "Bread" | Title: Bread | ✅ |
| 02 | Create a constractor for vendor | "AMC" | Name: AMC |✅ |
|  |  | ***Order Model*** |  |  |
| 03 | Return order's ID | order | 1 | ✅ |
| 04 | Return list of orders | order1, order2 | List {order1, order2} | ✅ |
| 05 | Find an order by Id | find(id = 2) | order2 | ✅ |
|  |  | ***Vendor Model*** |  |  |
| 06 | Return vendor's ID | vendor | 1 | ✅ |
| 07 | Return list of Vendors | vendor1, vendor2 | List{vendor1, vendor2} | ✅  |
| 08 | Find Vendor by Id | find(id = 2) | vendor2 | ✅ |
| 09 | Associate order with Vendor | order1, vendor1 | vendor1(order1) | ✅  |


</details>

#### 🏁 Running Tests:
* To run MS tests you will need to navigate to the `Bakery.Tests` folder *(cd Bakery.Tests)* in the command line and then run `dotnet restore`.
* You should now see **'obj'** folders in both the `Bakery.Tests` folder and `Bakery` folder.
* At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the Bakery.Tests folder).

####  🖥️ View website:
*GitHub page is not available for this project. To view functionality you need to run `dotnet run` from **Bakery** folder. After that you will see `http://localhost:5000`, click on that link and it will open web appliction in your default browser. In order to exit from local host use **Ctrl+C** command.*

## 🛠️ *Technologies used:*
* C# 9
* .NET Core v5.0
* ASP.NET MVC
* Razor View Egine
* RESTful Routing, CRUD & HTTP
* CSHTML
* Bootstrap v.4.6.x
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
This project was used to practice building web applications with ASP.NET MVC and Razor. Application doesn't use any database, so all data will be deleted as soon as app is closed. 

## 🌟 *Improvement opportunities:*
* add more style to the pages
* use more routes to navigate between data within order/ vendor


## 📬 Contact Information
#### For any questions *[email author](mailto:adeyemidany+github@gmail.com?subject=[GitHub])*



## 📘 *License and copyright:*

> ***© Daniel Adeyemi, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*