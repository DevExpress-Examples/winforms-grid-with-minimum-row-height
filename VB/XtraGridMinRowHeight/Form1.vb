Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports MinRowHeightXtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace XtraGridMinRowHeight

    Public Partial Class Form1
        Inherits Form

        Private grid As GridControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function CreateItems() As List(Of InvoiceItem)
            Dim items As List(Of InvoiceItem) = New List(Of InvoiceItem)()
            Dim rnd As Random = New Random()
            For i As Integer = 0 To 10 - 1
                Dim counter As Integer = i + 1
                items.Add(New InvoiceItem("Item " & counter.ToString(), rnd.Next(300), rnd.Next(20)))
            Next

            Return items
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            grid = New MinRowHeightGridControl()
            grid.Dock = DockStyle.Fill
            grid.MainView = New MinRowHeightGridView(grid)
            Controls.Add(grid)
            grid.DataSource = CreateItems()
            grid.BringToFront()
        End Sub

        Private Sub btnFont_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As FontDialog = New FontDialog()
            dialog.Font = CType(grid.MainView, GridView).Appearance.Row.Font
            If dialog.ShowDialog() = DialogResult.OK Then
                CType(grid.MainView, GridView).Appearance.Row.Font = dialog.Font
            End If
        End Sub
    End Class

    Public Class InvoiceItem

        Private nameField As String

        Private priceField As Decimal

        Private quantityField As Integer

        Public Sub New(ByVal name As String, ByVal price As Decimal, ByVal quantity As Integer)
            nameField = name
            priceField = price
            quantityField = quantity
        End Sub

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                nameField = value
            End Set
        End Property

        Public Property Price As Decimal
            Get
                Return priceField
            End Get

            Set(ByVal value As Decimal)
                priceField = value
            End Set
        End Property

        Public Property Quantity As Integer
            Get
                Return quantityField
            End Get

            Set(ByVal value As Integer)
                quantityField = value
            End Set
        End Property

        Public ReadOnly Property Total As Decimal
            Get
                Return Price * Quantity
            End Get
        End Property
    End Class
End Namespace
