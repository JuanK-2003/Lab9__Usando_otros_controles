<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_of_inheritance._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Control de alumnos</h1>
        <div>
            <div>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Elegir" OnCheckedChanged="RadioButton1_CheckedChanged1" Text="PROFESOR" AutoPostBack="true" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Elegir" OnCheckedChanged="RadioButton2_CheckedChanged1" Text="ALUMNO"  AutoPostBack="true"/>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <div style="height: 358px">
                    <asp:TextBox ID="TextName" runat="server" Width="225px"></asp:TextBox>
                    <asp:TextBox ID="TextLastName" runat="server" Width="225px"></asp:TextBox>
                    <asp:TextBox ID="TextAddress" runat="server" Width="225px"></asp:TextBox>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <div class="col-xs-6" style="background-color:lemonchiffon">
                        <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                    <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
                    &nbsp;&nbsp;
                    <br />
                        <asp:Label ID="Label5" runat="server" Text="La edad es: " BackColor="#CCFF66" BorderColor="#FF5050" BorderWidth="1px" ForeColor="#990000" Height="35px" Width="300px"></asp:Label>
                        <br />
                        <br />
                        <div>
                            <div class="col-xs-6" style="background-color:lightcyan">
                                <strong> Datos del Alumno </strong> <br />
                            Carnet

                                <asp:TextBox ID="TextCarnet" runat="server" Height="20px"></asp:TextBox>
                                <br />
                                <br />
                                Curso
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Programación III</asp:ListItem>
                            <asp:ListItem>Matemática III</asp:ListItem>
                            <asp:ListItem>Dibujo CAD</asp:ListItem>
                            <asp:ListItem>Electrónica Digital</asp:ListItem>
                            <asp:ListItem>Electrónica II</asp:ListItem>
                            <asp:ListItem>Álgebra Lineal</asp:ListItem>
                            <asp:ListItem>Física II</asp:ListItem>
                        </asp:DropDownList>
                                <br />
                            <br />
                            Nota <asp:TextBox ID="TextNota" runat="server" Height="20px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="ButtonNota" runat="server" OnClick="ButtonNota_Click" Text="Agregar Nota" />
                                <br />
                                <br />
                                <div>
                                    <asp:Button ID="ButtonAlumno" runat="server" Text="Agregar Alumno" OnClick="ButtonAlumno_Click" BackColor="#FF5050" BorderColor="#00CC99" />
                                    <br />
                                    <br />
                                </div>
                        </div>
                            <div class="col-xs-6" style="background-color:palegoldenrod">
                                <strong> Datos del Profesor </strong>
                                <br />
                                Título del docente

                                <asp:TextBox ID="TextTitulo" runat="server" Height="20px"></asp:TextBox>
                                <br />
                                <br />
                                <div>
                                    <asp:Button ID="ButtonDocente" runat="server" Text="Agregar Docente" OnClick="ButtonDocente_Click" BackColor="#FF5050" BorderColor="#00CC66" />
                                    <br />
                                </div>                                                                                          
                            </div>
                                                                                          <br />  
                    </div>
                                                                                      <br />  
                        </div>
                                                                                      <br />  
                </div> 
                                                                              <br />  
            </div>
                                                                          <br />  
        </div>
                                                                      <br /> 
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
                                                                      <br />  
    </div> 
                                                                  <br />  
</asp:Content>  