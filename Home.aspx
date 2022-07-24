<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <link href="StyleSheet-home.css" rel="stylesheet" />
        <%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">--%>
    <h2 style="direction:rtl; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">ברוכים הבאים ל MAMBA PARK</h2>
    <br />
    <div>
        
        <button type="button" onclick="displayPreviousImage()">Previous</button>
        
    </div>
      &nbsp<br /><script type = "text/javascript" style=" margin-left:auto; margin-right:auto">
             
                     function displayNextImage() {
                         x = (x === images.length - 1) ? 0 : x + 1;
                         document.getElementById("img").src = images[x];
                     }

                     function displayPreviousImage() {
                         x = (x <= 0) ? images.length - 1 : x - 1;
                         document.getElementById("img").src = images[x];
                     }

                     function startTimer() {
                         if (!counter) {
                             setInterval(displayNextImage, 3000);
                             counter = true;
                         }
                     }

         var images = [], x = -1;
         var counter = false;
         images[0] = "Images/picture_1.jpg";
         images[1] = "Images/picture_2.jpg";
         images[2] = "Images/pic3.jpg";
         images[3] = "Images/pic4.jpg";
         images[4] = "Images/wildfirepic5.jpg";
         images[5] = "Images/Lightningpic6.jpeg";
         images[6] = "Images/steeldragonpic8.jpg";
         //images[7]=
         //images[8]=
     </script>
      
   <div>
       <img id="img" src="Images/picture_1.jpg" onload="startTimer()" class="resize">
       <button type="button" onclick="displayPreviousImage()">Previous</button>
       <button type="button" onclick="displayNextImage()">Next</button>
   </div> 



</asp:Content>


