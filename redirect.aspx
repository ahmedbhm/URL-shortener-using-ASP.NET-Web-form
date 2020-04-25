<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="redirect.aspx.cs" Inherits="url_shortner.redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css" integrity="sha256-h20CPZ0QyXlBuAw7A+KluUYx/3pK+c7lYEpqLTlxjYQ=" crossorigin="anonymous" />
	
	<style>
	input[type="url"]:focus,button:focus,.btn:focus,.btn:active{   
      border-color: none;
      box-shadow: none;
      outline: 0 none;
    }
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container text-center">
         <div class="pt-5" runat="server" id="result_area">
		     
		 </div>
    </div>
    </form>
</body>
</html>
