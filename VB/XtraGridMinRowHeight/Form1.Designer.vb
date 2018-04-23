Imports Microsoft.VisualBasic
Imports System
Namespace XtraGridMinRowHeight
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnFont = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnFont
			' 
			Me.btnFont.Dock = System.Windows.Forms.DockStyle.Top
			Me.btnFont.Location = New System.Drawing.Point(0, 0)
			Me.btnFont.Name = "btnFont"
			Me.btnFont.Size = New System.Drawing.Size(284, 23)
			Me.btnFont.TabIndex = 0
			Me.btnFont.Text = "Change Font"
			Me.btnFont.UseVisualStyleBackColor = True
'			Me.btnFont.Click += New System.EventHandler(Me.btnFont_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.btnFont)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnFont As System.Windows.Forms.Button
	End Class
End Namespace

