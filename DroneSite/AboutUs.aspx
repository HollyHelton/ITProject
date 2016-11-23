<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="DroneSite.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 328px;
            height: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="maindiv">
        <h2>About us</h2>
        <div id ="text1" style="float:left;">
            <p>We are a group of people willing to help visually impaired athletes to compete on the same level as ordinary athletes. 
                We provide them with an amazing technology of guide drones that can improve athlete performance by almost 30%!
                We are located in Dundee, but shipping is available all around the UK. We try to keep the prices low and the quality high.

                We decided to develop this website for one of our university project and have been working on it since then.
                Our team consists of 5 people:
            </p>
                <ul>
                    <li>Aleksejs Loginovs</li>
                    <li>Martin Learmont</li>
                    <li>Holly Helton</li>
                    <li>Dwayne Valdelievre</li>
                </ul>

        </div>
        <div style="float:right;" id ="picture">
            <img alt="our happy team picture" class="auto-style2" src="file:///C:/Users/aleksejsloginovs/Desktop/ITProj/ITProject/DroneSite/images/team_pic.jpg" /></div>
        <p>Our office address:</p>
        <p>
            University of Dundee<br />
            Queen Mother Building<br />
            Balfour Street<br />
            Dundee<br />
            DD1 4HN<br />
        </p>
    </div>
    </form>
    <div id = "map"><iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2204.5292046160444!2d-2.9849409340419344!3d56.45864363074805!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48865cb881e12ef7%3A0x246a41df95bf439d!2sQueen+Mother+Building%2C+Dundee+DD1+4HN!5e0!3m2!1sen!2suk!4v1479900412876" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe></div>
</body>
</html>
