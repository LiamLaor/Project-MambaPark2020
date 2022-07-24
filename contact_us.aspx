<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact_us.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>הכנס פרטי איש קשר</h3>
    <table border="1">
        <tr>
            <td>
                name:<input type="text" id="name" name="name" />
            </td>
                </tr>
            <tr>
            <td>
                number:<input type="text" id="number" name="number" />

            </td>
        </tr>
        <tr>
            <td>
                  <input type="submit" value="submit" id="submit" />
            </td>
          

        </tr>
       
    </table>
       
    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3379.6221242538795!2d34.81406968546649!3d32.10649698117963!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x151d497c014f97eb%3A0x255c4900e64a4dd7!2z15zXldeg15Qg16TXkNeo16c!5e0!3m2!1siw!2sil!4v1591160582968!5m2!1siw!2sil" width="600" height="450" ></iframe>
    
</asp:Content>

