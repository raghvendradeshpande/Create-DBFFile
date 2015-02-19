<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charts.aspx.cs" Inherits="ASPNetDemo.Charts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
    <link href="Scripts/jquery.jqplot.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.jqplot.min.js" type="text/javascript"></script>
    <link href="Scripts/select2.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/select2.js" type="text/javascript"></script>
    
<script src="Scripts/jqplot.barRenderer.min.js" type="text/javascript"></script>
<script src="Scripts/jqplot.canvasAxisLabelRenderer.min.js" type="text/javascript"></script>
<script src="Scripts/jqplot.categoryAxisRenderer.min.js" type="text/javascript"></script>
<script src="Scripts/jqplot.donutRenderer.min.js" type="text/javascript"></script>
<script src="Scripts/jqplot.pieRenderer.min.js" type="text/javascript"></script>
<script src="Scripts/jqplot.pointLabels.min.js" type="text/javascript"></script>
    
</head>
<body>
    <form id="form1" runat="server">   
    <div><span>Please select Maharashtra</span></div>    
    <select id="states" style="width:250px;" multiple="multiple" class="abc">         
    </select>
    <div id="chart3" style="width:400px"></div>
 <br />
    <div id="chart2" style="width:400px"> </div>     
    </form>
    <script src="Scripts/Custom/CountryChart.js" type="text/javascript"></script>
</body>
</html>
