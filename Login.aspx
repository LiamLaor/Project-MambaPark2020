<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
     <link href="Login.css" rel="stylesheet"  />
    <form  runat="server" method="post">
<h3 style="text-align:center">Login</h3>
  <div class="container">
    <label for="username"><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="username" id="username" required>

<br />
    <label for="password"><b>Password</b></label>
    &nbsp<input type="password" placeholder="Enter Password" name="password" id="password" required>
<br />
   
       


    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<button type="submit">Submit</button>
    
  </div>

  
</form>
      
    
      
   
       <h1><% =msg %></h1>

</asp:Content>

