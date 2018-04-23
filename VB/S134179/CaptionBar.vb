Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing

Namespace S134179
	Public Class CaptionBar
		Inherits GroupControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreatePainter() As ObjectPainter
			Select Case LookAndFeel.ActiveStyle
				Case ActiveLookAndFeelStyle.Office2003
					Return New CaptionBarObjectPainter(Me)
				Case ActiveLookAndFeelStyle.WindowsXP
					Return New WindowsXPCaptionBarObjectPainter(Me)
				Case ActiveLookAndFeelStyle.Skin
					Return New SkinCaptionBarObjectPainter(Me, LookAndFeel)
			End Select
			Return New FlatCaptionBarObjectPainter(Me)
		End Function
	End Class

	Public Class SkinCaptionBarObjectPainter
		Inherits SkinGroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
			MyBase.New(owner, provider)
		End Sub

		Protected Overrides Function CalcCaptionContentHeight(ByVal info As GroupObjectInfoArgs) As Integer
			Return info.Bounds.Height
		End Function

		Protected Overrides Sub CalcCaptionNew(ByVal info As GroupObjectInfoArgs)
			info.CaptionBounds = info.Bounds
			CalcCaptionElements(info, info.Bounds)
		End Sub
	End Class

	Public Class CaptionBarObjectPainter
		Inherits GroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CalcCaptionContentHeight(ByVal info As GroupObjectInfoArgs) As Integer
			Return info.Bounds.Height
		End Function

		Protected Overrides Sub CalcCaptionNew(ByVal info As GroupObjectInfoArgs)
			info.CaptionBounds = info.Bounds
			CalcCaptionElements(info, info.Bounds)
		End Sub
	End Class

	Public Class WindowsXPCaptionBarObjectPainter
		Inherits WindowsXPGroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CalcCaptionContentHeight(ByVal info As GroupObjectInfoArgs) As Integer
			Return info.Bounds.Height
		End Function

		Protected Overrides Sub CalcCaptionNew(ByVal info As GroupObjectInfoArgs)
			info.CaptionBounds = info.Bounds
			CalcCaptionElements(info, info.Bounds)
		End Sub
	End Class

	Public Class FlatCaptionBarObjectPainter
		Inherits FlatGroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CalcCaptionContentHeight(ByVal info As GroupObjectInfoArgs) As Integer
			Return info.Bounds.Height
		End Function

		Protected Overrides Sub CalcCaptionNew(ByVal info As GroupObjectInfoArgs)
			info.CaptionBounds = info.Bounds
			CalcCaptionElements(info, info.Bounds)
		End Sub
	End Class
End Namespace
