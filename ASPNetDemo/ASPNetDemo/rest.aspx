<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rest.aspx.cs" Inherits="ASPNetDemo.rest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>

    <script src="Scripts/jquery.dataTables.js" type="text/javascript"></script>
     <script src="Scripts/dataTables.bootstrap.js" type="text/javascript"></script>
     <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <link href="Scripts/dataTables.bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.dataTables.columnFilter.js" type="text/javascript"></script>
    <link href="Scripts/bootstrap.min.css" rel="stylesheet" type="text/css" />         
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" class="abcd" />

        <table id="appraiserTable" class="table table-bordered table-hover table-condensed VMAppraiserfixwidth">
                            <thead>
                            <tr>                            
                            <th>Company</th>
                            <th>First Name</th>                          
                            </tr>
                           	 <tr class="filters">
                                    <th><input type="text" class="text_filter search_init"/></th>
                                    <th><input type="text" class="text_filter search_init" /></th>                                
                                </tr></thead>
                           <tbody>    
                                                                        
                           </tbody>
                     
                        </table>
        <input id="txtID" type="text" />

        <input id="getByID" type="button" value="GET BY ID" /> <br />

        <input id="txtFirstName" type="text" />
        <input id="txtcompany" type="text" />  
        <input id="txtBonus" type="text" />
        <input id="txtSalary" type="text" />        
        
        <br />
        <input id="btnUpdate" type="button" value="Update Employee" /> &nbsp; 
        <input id="btnCreate" type="button" value="Create" /></div> </form>
    <script language="javascript" type="text/javascript">

        jQuery.getJSON("http://localhost:62053/RestServiceImpl.svc/getAllEmployee", function (data) {           

            table = jQuery('#appraiserTable').DataTable({
                "bProcessing": true,
                "aaData": data.getAllEmployeeResult,
                "iDisplayLength": 5,
                bSortCellsTop: true,
                "sDom": '<"top-row"T>rt<"F"p><"per-page"l>',
                "oLanguage": {
                    "sLengthMenu": "Per page: _MENU_"
                },
                "aoColumns": [{ "mData": "Company" }, { "mData": "Firstname"}],
                "aoColumnDefs": [{
                    //"aTargets": [2],
                    "orderable": false
                    //"aTargets": [0]

                }], order: [],

                "bFilter": true

            }).columnFilter({
//                sPlaceHolder: "head:after",
//                bUseColVis: true,
//                aoColumns: [
//   									{ "type": "text" },
//   									{ "type": "text" }
//   				    	]
            });
        });


        $(".abcd").click(function () {
            alert("abcd");
            $.ajax({
                url: "http://localhost:62053/RestServiceImpl.svc/json/10",
                datatype: "json",
                success: function (data) {                 
                    alert(data.getJSONResult);
                }
            });
            return false;
        });

        $("#getByID").click(function () {            
            $.ajax({
                url: "http://localhost:62053/RestServiceImpl.svc/employee/" + $("#txtID").val(),
                datatype: "json",
                success: function (data) {                                            
                   $("#txtcompany").val(data.getEmployeeByIDResult[0].Company);
                    $("#txtFirstName").val(data.getEmployeeByIDResult[0].Firstname);                                      
                }
            });
            return false;
        });

        //{"emp":[{"Company":"rrr","Firstname":"ttttttt"}]}
       
      
         $("#btnUpdate").click(function () { 
         var emp =  { 'emp' : [ { "Firstname": $("#txtFirstName").val(), "Company": $("#txtcompany").val() } ] };           
         emp = JSON.stringify(emp);                   
            $.ajax({
            url: "http://localhost:62053/RestServiceImpl.svc/employee/updateEmployee/" + $("#txtID").val(),
                type: "PUT",                
                data:  emp,
               contentType: "application/json",
                datatype: "json",
                success: function (data) {    
                if(data.updateEmployeeResult >=1)
                {
                     alert("updated successfully");
                }
                },                                               
                error: function (xhr, ajaxOptions, thrownError) {
   console.log(ajaxOptions);
  }
            });
            return false;
        });



        $("#btnCreate").click(function () {
            var emp = { 'emp': [{ "Firstname": $("#txtFirstName").val(), "Company": $("#txtcompany").val(),
                "Bonus": $("#txtBonus").val(), "Salary": $("#txtSalary").val()
            }]
            };
            emp = JSON.stringify(emp);
            alert(emp);
            $.ajax({
                url: "http://localhost:62053//RestServiceImpl.svc/employee/insertEmployee",
                type: "POST",
                data: emp,
                contentType: "application/json",
                datatype: "jsonp",
                success: function (data) {
                    alert(data.InsertEmployeeResult);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    console.log(xhr);
                }
            });
            return false;
        });
        


    </script>
   
</body>
</html>
