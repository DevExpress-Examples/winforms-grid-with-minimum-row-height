Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.Handler
Imports System.Drawing
Imports DevExpress.Utils
Imports System
Imports DevExpress.XtraGrid.Drawing

Namespace MinRowHeightXtraGrid
	Public Class MinRowHeightGridControl
		Inherits GridControl

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class
	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MinRowHeightGridView.MinRowHeightName
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MinRowHeightGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New MinRowHeightGridViewInfo(TryCast(view, MinRowHeightGridView))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New GridHandler(TryCast(view, GridView))
		End Function
	End Class

	Public Class MinRowHeightGridView
		Inherits GridView

		Public Const MinRowHeightName As String = "MinRowHeightGridView"
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub
		Public Overrides ReadOnly Property Editable() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MinRowHeightName
			End Get
		End Property
	End Class
	Public Class MinRowHeightGridViewInfo
		Inherits GridViewInfo

		Public Sub New(ByVal view As MinRowHeightGridView)
			MyBase.New(view)
		End Sub
        Protected Overrides Function CalcMinRowHeight() As Integer
            Return Convert.ToInt32(PaintAppearance.Row.CalcTextSize(GInfo.Cache, "Gq", Integer.MaxValue).Height) + 1
        End Function
    End Class
End Namespace

