<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to add a custom summary item to the grid's footer menu


<p>Sometimes it's necessary to specify a way of calculating summaries that is different from the default one. Assume you don't want to take into account cells with no data when calculating summaries. It's possible to accomplish this task using two events: use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomSummaryCalculatetopic"><u>GridView.CustomSummaryCalculate</u></a> event to provide a custom summary and the  <a href="http://documentation.devexpress.dev/#WindowsForms/DevExpressXtraGridViewsGridGridView_PopupMenuShowingtopic"><u>GridView.PopupMenuShowing</u></a><u> </u>event to add a corresponding item to the grid's footer menu.<br />
See also:<br />
<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument701"><u>Custom Aggregate Functions</u></a></p>

<br/>


