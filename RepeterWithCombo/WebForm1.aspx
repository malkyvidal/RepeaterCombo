<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RepeterWithCombo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlCon" runat="server">
                <asp:ListItem Text="Seleccione..." Value="0"></asp:ListItem>
                <asp:ListItem Text="ConvocUN" Value="1">

                </asp:ListItem>
                <asp:ListItem Text="ConvocDos" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlProg" runat="server">

                <asp:ListItem Text="Seleccione..." Value="0"></asp:ListItem>
                <asp:ListItem Text="ProgUIN" Value="1"></asp:ListItem>
                <asp:ListItem Text="ProgDos" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlUNi" runat="server">

                <asp:ListItem Text="Seleccione..." Value="0"></asp:ListItem>
                <asp:ListItem Text="UniUNo" Value="1"></asp:ListItem>
                <asp:ListItem Text="UniDs" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <label runat="server" id="plazaVal"></label>
            <asp:CustomValidator ID="cst" runat="server" ForeColor="Red" ErrorMessage=""></asp:CustomValidator>
            <div class="row">
                <div class="col-md-8">
                      <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_ItemDataBound">


                <HeaderTemplate>
                    <table class="table">
                    <tr>
                        <th>Programa</th>
                        <th>Uni</th>
                        <th>Opcion</th>
                        <th>Accion</th>
                    </tr>
                </HeaderTemplate>

                
                   
                     <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="prograna" runat="server" Text=""></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="uni" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlop" runat="server"></asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button ID="btnElim" runat="server" Text="Eliminar" />
                            </td>
                        </tr>
                        
                        
                        
                        
                 

                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                

              
               
            </asp:Repeater>
                </div>

            </div>
          
        </div>
        <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" runat="server" Text="Guardar" />
    </form>
</body>
</html>
