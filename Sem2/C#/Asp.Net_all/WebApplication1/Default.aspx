<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
.custom-tooltip {
    position: absolute;
    background: #8e44ad;
    color: white;
    padding: 12px 16px;
    border-radius: 10px;
    width: 300px;
    z-index: 1000;
    font-family: sans-serif;
}

.tooltip-arrow {
    width: 0;
    height: 0;
    border-left: 10px solid transparent;
    border-right: 10px solid transparent;
    border-top: 10px solid #8e44ad;
    position: absolute;
    bottom: -10px;
    left: 30px;
}

.tooltip-content {
    position: relative;
}

.close-tooltip {
    position: absolute;
    top: 0;
    right: 6px;
    font-size: 20px;
    cursor: pointer;
}
.plus-btn {
    font-size: 24px;
    width: 50px;
    height: 50px;
    border-radius: 50%;
    background-color: #8e44ad;
    color: white;
    border: none;
}
</style>

    <main>
        <asp:Label ID="lblCookieExpiry" runat="server" CssClass="text-info"></asp:Label>

        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
                A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Get more libraries</h2>
                <p>
                    NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>
    <div id="tooltip-container" class="custom-tooltip" style="display:none;">
    <div class="tooltip-arrow"></div>
    <div class="tooltip-content">
        You can add text, photos, and graphics to your design!
        <span class="close-tooltip" onclick="hideTooltip()">×</span>
    </div>
</div>

<!-- Example anchor button -->
<button id="addButton" class="plus-btn">+</button>

    <script>
        function showTooltip() {
            const btn = document.getElementById("addButton");
            const tooltip = document.getElementById("tooltip-container");
            const rect = btn.getBoundingClientRect();

            tooltip.style.top = (window.scrollY + rect.top - 70) + "px";
            tooltip.style.left = (window.scrollX + rect.left - 20) + "px";
            tooltip.style.display = "block";
        }

        function hideTooltip() {
            document.getElementById("tooltip-container").style.display = "none";
        }
    </script>

</asp:Content>
