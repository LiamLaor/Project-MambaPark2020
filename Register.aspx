<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<link href="StyleSheet.css" rel="stylesheet" />
	<script src="JavaScript.js" type="text/javascript"></script>

      <div class="container">
		<div class="row">
			<div class="panel panel-primary">
				<div class="panel-body">
					
					<form id="form1" method="post" runat="server" action="#" role="form" onkeyup="return Check()" onsubmit="return IsValid()"  >
						<div class="form-group">
							<h2>Create account</h2>
						</div>
						<div class="form-group">
							<label class="control-label" for="signupName">Your name</label>
							<input id="signupName" name="signupName_" type="text" maxlength="50" class="form-control" value="<%=username%>">
						</div>
						<div class="form-group">
							<label class="control-label" for="signupEmail">Email</label>
							<input id="signupEmail" name="signupEmail" type="email" maxlength="50" class="form-control">
						</div>
                        <div class="form-group">
                            <label class="control-label" for="signupAge">your age</label>
							<input id="signupAge" name="signupAge" class="form-control" onkeyup="isValidAge()">

                        </div>
						
						<div class="form-group">
							<label class="control-label" for="signupPassword">Password</label>
							<input id="password_1" name="Password_1" type="password" maxlength="25" class="form-control" placeholder="at least 6 characters" onkeyup="IsMatchingPass()">
						</div>
						<div class="form-group">
							<label class="control-label" for="signupPasswordagain">Password again</label>
							<input id="password_2" name="Password_2" type="password" maxlength="25" class="form-control" onkeyup="IsMatchingPass()">
						</div>
						<div class="form-group">
							<button id="signupSubmit" type="submit" class="btn btn-info btn-block" onclick="return IsValid()">Create your account</button>
						</div>
						<p class="form-group">if something went wrong please <a href="contact_us.aspx">Contact us</a> r <a href="#">Privacy Policy</a>.</p>
						<hr>
						<p>Already have an account? <a href="Login.aspx">Sign in</a></p>
					</form>
				</div>
			</div>
		</div>
	</div>
     <h1></h1>
	<script type="text/javascript">
		

	</script>
</asp:Content>

