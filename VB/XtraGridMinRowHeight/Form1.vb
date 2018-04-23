Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports MinRowHeightXtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace XtraGridMinRowHeight
    Partial Public Class Form1
        Inherits Form

        Private grid As GridControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function CreateItems() As List(Of InvoiceItem)
            Dim items As New List(Of InvoiceItem)()
            Dim rnd As New Random()
            For i As Integer = 0 To 9
                Dim counter As Integer = i + 1
                items.Add(New InvoiceItem("Item " & counter.ToString(), rnd.Next(300), rnd.Next(20)))
            Next i
            Return items
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.grid = New MinRowHeightGridControl()
            grid.Dock = DockStyle.Fill
            grid.MainView = New MinRowHeightGridView(grid)
            Controls.Add(grid)
            grid.DataSource = CreateItems()
            grid.BringToFront()
        End Sub

        Private Sub btnFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFont.Click
            Dim dialog As New FontDialog()
            dialog.Font = CType(grid.MainView, GridView).Appearance.Row.Font
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                CType(grid.MainView, GridView).Appearance.Row.Font = dialog.Font
            End If
        End Sub

    End Class

    Public Class InvoiceItem

        Private name_Renamed As String

        Private price_Renamed As Decimal

        Private quantity_Renamed As Integer


        Public Sub New(ByVal name As String, ByVal price As Decimal, ByVal quantity As Integer)
            Me.name_Renamed = name
            Me.price_Renamed = price
            Me.quantity_Renamed = quantity
        End Sub
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property
        Public Property Price() As Decimal
            Get
                Return price_Renamed
            End Get
            Set(ByVal value As Decimal)
                price_Renamed = value
            End Set
        End Property
        Public Property Quantity() As Integer
            Get
                Return quantity_Renamed
            End Get
            Set(ByVal value As Integer)
                quantity_Renamed = value
            End Set
        End Property
        Public ReadOnly Property Total() As Decimal
            Get
                Return Price * Quantity
            End Get
        End Property
    End Class

End Namespace