Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing

Namespace dxSample_CustomSimpleButton.Custom_Button
    Public Class CustomSkinEditorButtonPainter
        Inherits SkinEditorButtonPainter

        Public Sub New(ByVal provider As DevExpress.Skins.ISkinProvider)
            MyBase.New(provider)
        End Sub
        Public Sub New(ByVal provider As DevExpress.Skins.ISkinProvider, ByVal OwnerButton As Object)
            MyBase.New(provider)
            Button = TryCast(OwnerButton, CustomButton)
        End Sub
        Private Button As CustomButton
        Private Function GetCustomStyle() As CustomStyle
            Dim style As CustomStyle
            If Button IsNot Nothing Then
                style = Button.CustomStyle
            Else
                style = CustomStyle.Style1
            End If
            Return style
        End Function
        Protected Overrides Function GetSkinElement(ByVal e As EditorButtonObjectInfoArgs, ByVal kind As DevExpress.XtraEditors.Controls.ButtonPredefines) As SkinElement
            Return MyBase.GetSkinElement(e, kind)
        End Function
        Protected Overrides Function CalcImageIndexCore(ByVal state As DevExpress.Utils.Drawing.ObjectState) As Integer
            Dim customStyle = GetCustomStyle()
            Dim startImageIndex = 0
            Select Case customStyle
                Case dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style1
                    startImageIndex = 0
                Case dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style2
                    startImageIndex = 6
                Case dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3
                    startImageIndex = 12
            End Select
            Dim tempState = state And ((Not ObjectState.Selected))
            If tempState = ObjectState.Disabled Then
                Return startImageIndex + 3
            End If
            If (tempState And ObjectState.Pressed) <> 0 Then
                Return startImageIndex + 2
            End If
            If (tempState And ObjectState.Hot) <> 0 Then
                Return startImageIndex + 1
            End If
            If (state And ObjectState.Selected) <> 0 Then
                If info.Element Is Nothing OrElse info.Element.Image Is Nothing OrElse info.Element.Image.ImageCount < 5 Then
                    Return startImageIndex + 0
                End If
                Return startImageIndex + 4
            End If
            Return startImageIndex + 0
        End Function
    End Class
End Namespace
