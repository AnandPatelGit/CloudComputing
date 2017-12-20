<%@ Page Title="" Language="C#" MasterPageFile="~/Food.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="AnandPatel_COMP306Lab1_Cloud.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
            
        }
    </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
   
        <div class="container">
            <table class="auto-style1">
                <tr>
                    <td>
                    <em><h5> <asp:Label Text="Fill the details and choose the item you want to Order" runat="server"/><hr></h5></em>    
        
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:AdRotator ID="AdRotator1" Height="500" Width="800" runat="server" AdvertisementFile="~/XMLFile.xml" />
                <asp:Timer ID="Timer1" runat="server" Interval="5000">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>

                </td>
                </tr>
            </table>

            <table class="auto-style1">  
                
                <tr>  
                    <td><strong>First Name :</strong></td>  
                    <td>  
                        <asp:TextBox ID="textBoxFirstName" runat="server" cssClass="input-field col s6"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td><strong>Last Name :</strong></td>  
                     <td class="auto-style1"> <asp:TextBox ID="textBoxLastName" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;
                         <asp:Button ID="ButtonRememberMe" runat="server" OnClick="ButtonRememberMe_Click" Text="Remember Me" />
                    </td>  
                </tr>  
                <tr>  
                    <td><strong>City</strong></td>  
                    <td>  
                        <asp:TextBox ID="textBoxCity" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td><strong>Postal Code</strong></td>  
                    <td>  
                        <asp:TextBox ID="textBoxPostalCode" runat="server" ></asp:TextBox>  
                    </td> 
                </tr>

                <tr>  
                    <td><strong>Phone Number</strong></td>  
                    <td>  
                        <asp:TextBox ID="textBoxPhoneNumber" runat="server"></asp:TextBox>  
                    </td>  
                </tr>
                <tr>
                    <td><strong>Province</strong></td>
                    <td>
                        <asp:DropDownList ID="dropDownListProvince" runat="server">
                            <asp:ListItem>ONTARIO</asp:ListItem>
                            <asp:ListItem>MANITOBA</asp:ListItem>
                            <asp:ListItem>ALBERTA</asp:ListItem>
                            <asp:ListItem>PRINCE EDWARD ISLAND</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><strong>Food and Drinks</strong></td>
                    <td>
                        <em>
                        <asp:CheckBoxList ID="checkboxListFoodAndDrink" runat="server">
                          <asp:ListItem>Espresso</asp:ListItem>
                            <asp:ListItem>Pepsi</asp:ListItem>
                            <asp:ListItem>Diet Pepsi</asp:ListItem>
                            <asp:ListItem>Sandwiches</asp:ListItem>
                            <asp:ListItem>Panini</asp:ListItem>
                            <asp:ListItem>Poutine</asp:ListItem>
                            <asp:ListItem>Buritto</asp:ListItem>
                        </asp:CheckBoxList>
                        </em>
                    </td>
                    
                </tr>
           
                <!--<tr>
                     <div class="carousel">
                        <a class="carousel-item" href="#one!"><img src="https://storage.googleapis.com/anand_restaurant/espresso.jpg" height="400"></a>
                        <a class="carousel-item" href="#two!"><img src="https://storage.googleapis.com/anand_restaurant/pepsi.jpg" height="400"></a>
                        <a class="carousel-item" href="#three!"><img src="https://storage.googleapis.com/anand_restaurant/dietpepsi.jpg" height="400"></a>
                        <a class="carousel-item" href="#four!"><img src="https://storage.googleapis.com/anand_restaurant/sandwich.jpg" height="400"></a>
                        <a class="carousel-item" href="#five!"><img src="https://storage.googleapis.com/anand_restaurant/panini.jpg" height="400"></a>
                         <a class="carousel-item" href="#six!"><img src="https://storage.googleapis.com/anand_restaurant/poutine.jpg" height="400"></a>
                         <a class="carousel-item" href="#seven!"><img src="https://storage.googleapis.com/anand_restaurant/burrito.jpg" height="400"></a>
                    </div>
                </tr> -->
                <tr>  
                    <td><strong>Pickup or Delivery</strong></td>  
                    <td>  
                        <em>  
                        <asp:RadioButtonList ID="radioButtonListPickup" runat="server">  
                            <asp:ListItem>Pick up</asp:ListItem>  
                            <asp:ListItem>Delivery</asp:ListItem>  
                        </asp:RadioButtonList>  
                        </em>  
                    </td>  
               </tr>
                <tr>
                    <td><strong>Comment</strong></td>
                    <td> 
                     <asp:TextBox ID="textBoxComment" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Order" />  
                    </td>  
                     <td>  
                        <asp:Button ID="Button2" runat="server" Text="Upload Image" OnClick="Button2_Click" />  
                    </td>
                </tr>  
            </table>  
        </div>

</asp:Content>
