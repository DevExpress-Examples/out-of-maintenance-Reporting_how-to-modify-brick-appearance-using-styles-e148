Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace BrickStyles
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			printingSystem1.Begin()

			' Specify the style definitions.
			Dim column_style1 As New BrickStyle(BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top, 2, Color.Gold, Color.Navy, Color.DodgerBlue, New Font("Arial", 6, FontStyle.Bold Or FontStyle.Italic), New BrickStringFormat(StringAlignment.Near, StringAlignment.Near))
			Dim column_style2 As New BrickStyle(BorderSide.Top Or BorderSide.Bottom, 2, Color.Navy, Color.DodgerBlue, Color.Gold, New Font("Arial", 6, FontStyle.Bold Or FontStyle.Italic), New BrickStringFormat(StringAlignment.Center, StringAlignment.Center))
			Dim column_style3 As New BrickStyle(BorderSide.Right Or BorderSide.Bottom Or BorderSide.Top, 2, Color.DodgerBlue, Color.Gold, Color.Navy, New Font("Arial", 6, FontStyle.Bold Or FontStyle.Italic), New BrickStringFormat(StringAlignment.Far, StringAlignment.Far))

			Dim gr As BrickGraphics = printingSystem1.Graph
			gr.Modifier = BrickModifier.Detail
			Dim s As String = "XtraPrinting Library"
			Dim t_brick As New TextBrick()

			' Draw the first column and apply the style.
			For i As Integer = 0 To 2
				t_brick = gr.DrawString(s, New RectangleF(0, 20 * i, 100, 20))
				t_brick.Style = column_style1
			Next i

			' Draw the second column and apply the style.
			For i As Integer = 0 To 2
				t_brick = gr.DrawString(s, New RectangleF(100, 20 * i, 100, 20))
				t_brick.Style = column_style2
			Next i

			' Draw the first column and apply the style.
			For i As Integer = 0 To 2
				t_brick = gr.DrawString(s, New RectangleF(200, 20 * i, 100, 20))
				t_brick.Style = column_style3
			Next i

			printingSystem1.End()
			printingSystem1.PreviewFormEx.Show()
		End Sub

	End Class
End Namespace