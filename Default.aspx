<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="url_shortner.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
     <title>short link</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css" integrity="sha256-h20CPZ0QyXlBuAw7A+KluUYx/3pK+c7lYEpqLTlxjYQ=" crossorigin="anonymous" />
	
	<style>
input[type="url"]:focus,button:focus,.btn:focus,.btn:active{   
  border-color: none;
  box-shadow: none;
  outline: 0 none;
}
.container{
  width:50%;
  margin-top:120px;
}
.capatcha-skip{
	background:#fff;
	padding:20px;
	border-radius:10px;
	border-top: 5px solid #3498DB;
}
	</style>
 </head>
<body>
  <form id="form1" runat="server">
    <div class="container text-center">
     <h1>Hello, world!</h1></br>
	 <div class="input-group">
	  <input type="url" id="url" class="form-control rounded-0" placeholder="http://example.com/example" style="padding:12px" runat="server"/>
	  <span class="input-group-btn" style="width:15%">
		<asp:LinkButton id="Button1" class="btn btn-primary form-control rounded-0" runat="server" OnClick="Button1_Click">
		  <i class="fas fa-cut" id="cut-icon"></i>
		</asp:LinkButton>
	  </span>
	 </div>
	 <div id="data_place" style="margin-top:15px;" runat="server"> </div> 
  </div>
</form>
</body>
</html>
