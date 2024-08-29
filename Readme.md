<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624178/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E524)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Create a custom View with the lowest row height

The example creates a custom grid control (`MinRowHeightGridControl`) with the lowest row height possible. The custom grid is read-only and we assume that only text columns can be used.

![WinForms Data Grid - Create a custom View with the minimum row height](https://raw.githubusercontent.com/DevExpress-Examples/creating-custom-view-that-has-the-minimum-row-height-e524/19.1.3%2B/media/winforms-grid-custom-row-height.png)

```csharp
public class MinRowHeightGridViewInfo : GridViewInfo {
    public MinRowHeightGridViewInfo(MinRowHeightGridView view) : base(view) { }
    protected override int CalcMinRowHeight() {
        return Convert.ToInt32(PaintAppearance.Row.CalcTextSize(GInfo.Cache, "Gq", int.MaxValue).Height) + 1;
    }
}
```


## Files to Review

* [Form1.cs](./CS/XtraGridMinRowHeight/Form1.cs) (VB: [Form1.vb](./VB/XtraGridMinRowHeight/Form1.vb))
* [MinRowHeightGridView.cs](./CS/XtraGridMinRowHeight/MinRowHeightGridView.cs) (VB: [MinRowHeightGridView.vb](./VB/XtraGridMinRowHeight/MinRowHeightGridView.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-with-minimum-row-height&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-with-minimum-row-height&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
