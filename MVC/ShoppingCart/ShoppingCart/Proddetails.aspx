<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proddetails.aspx.cs" Inherits="ShoppingCart.Proddetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  <div class="text-center">

          <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal"      
      RepeatColumns="4" Width="100%" HorizontalAlign="Center" OnSelectedIndexChanged="DataList1_SelectedIndexChanged1"   >
 <HeaderTemplate>      
                        <table>      
                            <tr>      
                                <td>      
                                    <h1>Product for you</h1>      
                                </td>      
                            </tr>      
                        </table>      
                    </HeaderTemplate>  

            <ItemStyle CssClass="itemstyle" />      
                    <ItemTemplate>   
                        <table align="center" style="border-spacing:20px;padding:20px;">
                            <tr>
                               <td>
                                    <table border="0" style="border-spacing:20px;padding:20px;" >      
                                        <tr>     
                                            <td style="padding:20px;" >  
                                                  <asp:Label ID="lblProdimage" runat="server" text='      
                                        <%# Eval("ProdImage") %>' visible="false" />      
                                            </td>  
                                    <asp:ImageButton  align="center" ID="prodimg" runat="server" ImageUrl='      
                                        <%# "~/imges/" + Eval("ProdImage") %>' Height="180px" Width="200px" />      
                                            </td>  
                                
                                           <td  style="padding:20px;" >
                                               <table style="border-spacing:20px;">
                                                   <tr>
                                            <td align="center">      
                                                <asp:Label ID="lblProddescription" runat="server" Text='<%# Eval("ProdDescription") %>'>      
                                                </asp:Label>      
                                            </td>  
                                                       </tr>

                                                       <tr>
                                            <td align="center">      
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProdName") %>'>      
                                                </asp:Label>      
                                            </td>  
                                                       </tr>
                                                   <tr>
                                      
                                            <td align="center">  
                                                <asp:Label ID="lblProdid" runat="server" Text='<%# Eval("Prodid") %>' visible="false">

                                                </asp:Label>
                                          Price :     <asp:Label ID="lblProdPrice" runat="server" Text='<%# Eval("ProdPrice") %>'>      
                                                </asp:Label>  Rs.    
                                            </td> 
                                                       </tr>

                                                     <tr>     
                                            <td >      
                                    <asp:Button OnClick="Button1_Click"   ID="ImageButton1" runat="server" Text="Add To Cart" Height="50px" Width="200px" />      
                                            </td>  
                                                            <td >      
                                    <asp:Button OnClick="Button2_Click"   ID="Button2" runat="server" Text="view cart" Height="50px" Width="200px" />      
                                            </td>  
                                
                                
                                        </tr>    
                                                   
                                                 
                                                   </table>
                                               </td>
                                 
                                        </tr>      
                                
                                          
                                    </table>  
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate> 

       </asp:DataList>


    </div>
</asp:Content>


