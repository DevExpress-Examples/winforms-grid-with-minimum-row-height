# Creating custom view that has the minimum row height


<p>The example demonstrates how to create a new grid view with the minimum possible row height. The grid view is non-editable in our example and we assume that the developer may use text columns only.</p>


<h3>Description</h3>

The signature of GridViewInfo's&nbsp;CalcRowCellDrawInfoCore method was changed. Now it accepts six parameters:&nbsp;CalcRowCellDrawInfoCore(GridDataRowInfo ri, GridColumnInfoArgs ci, GridCellInfo cell, GridColumnInfoArgs nextColumn, bool calcEditInfo, GridRow nextRow)

<br/>


