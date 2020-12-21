<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Admin_Productos.aspx.cs" Inherits="TP_Muebleria_asp.Admin_Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <br /><br /><br />    <br /><br /><br />

    <div class="container">
        <%--<div class="row">--%>

            <div class="center-block" style="float:left;">


                <div class ="col-12" style="text-align:center">
                        <asp:Label ID="aclaracion_lbl" runat="server"></asp:Label>
                        </div>
                       


                <asp:GridView ID="GridView1" Style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; margin-left: 222px;" class="table" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" PageSize="5" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="16px" CellPadding="4" ForeColor="#333333" GridLines="None" Height="118px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Producto">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Cod_Producto_PRO") %>' ReadOnly="true"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Cod_Producto_PRO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Categoria">
                            <EditItemTemplate>
                                <%--<asp:DropDownList ID="DropDownList1" runat="server" > </asp:DropDownList>--%>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Nombre_Categoria") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nombre_Categoria") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Imagen">
                            <EditItemTemplate>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image ID="Image2" runat="server" Height="56px" ImageUrl='<%# Bind("Foto_Producto") %>' Width="84px" />
                                <%--<asp:Label ID="Label3" runat="server" Text='<%# Bind("Foto_Producto") %>'></asp:Label>--%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="validar_numero" AutoPostBack="true" Text='<%# Bind("Nombre_Producto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Nombre_Producto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Color">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="validar_numero" AutoPostBack="true" Text='<%# Bind("Color") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo Madera">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="validar_numero" AutoPostBack="true" Text='<%# Bind("Tipo_Madera") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Tipo_Madera") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" type="number" Text='<%# Bind("Precio_Unitario") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Precio_Unitario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Alto">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" type="number" runat="server" Text='<%# Bind("Alto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("Alto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ancho">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" type="number" runat="server" Text='<%# Bind("Ancho") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("Ancho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Largo">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox10" type="number" runat="server" Text='<%# Bind("Largo") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# Bind("Largo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <EditItemTemplate>

                                        <asp:DropDownList ID="DropDownEstado" runat="server" > 
                                            <asp:ListItem Value="True">True</asp:ListItem>
                                            <asp:ListItem Value="False">False</asp:ListItem>
                                        </asp:DropDownList>

                                <%--<asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("Estado") %>'></asp:TextBox>--%>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# Bind("Estado") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />

                </asp:GridView>
            </div>
            
        <%--</div>--%>
    </div>






<br /><br /><br />    <br /><br /><br />
</asp:Content>
