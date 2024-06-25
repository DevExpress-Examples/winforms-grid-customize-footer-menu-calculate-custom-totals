<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E496)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to add a custom summary item to the grid's footer menu


<p>Sometimes it's necessary to specify a way of calculating summaries that is different from the default one. Assume you don't want to take into account cells with no data when calculating summaries. It's possible to accomplish this task using two events: use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomSummaryCalculatetopic"><u>GridView.CustomSummaryCalculate</u></a> event to provide a custom summary and the  <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PopupMenuShowing"><u>GridView.PopupMenuShowing</u></a><u> </u>event to add a corresponding item to the grid's footer menu.<br />

See also:<br />
<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument701"><u>Custom Aggregate Functions</u></a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-footer-menu-calculate-custom-totals&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-footer-menu-calculate-custom-totals&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
