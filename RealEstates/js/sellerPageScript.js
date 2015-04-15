window.onload = initPage;
function initPage() {
    rb1Pressed();
}
function rb1Pressed() {
    document.getElementById('<%=TextBoxFName.ClientID%>').disabled = true;
    document.getElementById('<%=TextBoxLName.ClientID%>').disabled = true;
    document.getElementById('<%=TextBoxP1.ClientID%>').disabled = true;
    document.getElementById('<%=TextBoxP2.ClientID%>').disabled = true;
    document.getElementById('<%=TextBoxP3.ClientID%>').disabled = true;

}
function rb2Pressed() {
    document.getElementById('<%=TextBoxFName.ClientID%>').disabled = false;
    document.getElementById('<%=TextBoxLName.ClientID%>').disabled = false;
    document.getElementById('<%=TextBoxP1.ClientID%>').disabled = false;
    document.getElementById('<%=TextBoxP2.ClientID%>').disabled = false;
    document.getElementById('<%=TextBoxP3.ClientID%>').disabled = false;
}