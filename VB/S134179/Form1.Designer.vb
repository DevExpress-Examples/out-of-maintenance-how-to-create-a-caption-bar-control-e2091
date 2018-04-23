Imports Microsoft.VisualBasic
Imports System
Namespace S134179
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.captionBar1 = New S134179.CaptionBar()
			CType(Me.captionBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' captionBar1
			' 
			Me.captionBar1.AppearanceCaption.Font = New System.Drawing.Font("Comic Sans MS", 32F)
			Me.captionBar1.AppearanceCaption.Options.UseFont = True
			Me.captionBar1.AppearanceCaption.Options.UseTextOptions = True
			Me.captionBar1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.captionBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.captionBar1.Location = New System.Drawing.Point(0, 0)
			Me.captionBar1.Name = "captionBar1"
			Me.captionBar1.Size = New System.Drawing.Size(292, 67)
			Me.captionBar1.TabIndex = 1
			Me.captionBar1.Text = "Dx Sample"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.captionBar1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.captionBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private captionBar1 As CaptionBar

	End Class
End Namespace

