Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

Namespace dxSample_CustomSimpleButton.Custom_Button
    <ToolboxItem(True)> _
    Friend Class CustomButton
        Inherits SimpleButton

        Protected Overrides Function CreateViewInfo() As DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo
            Return New CustomSimpleButtonViewInfo(Me)
        End Function
        Private _CustomStyle As CustomStyle = CustomStyle.Style1
        Public Sub New()
            AssignCustomImage()
        End Sub
        Public Sub AssignCustomImage()
            Dim skin = GetCurrentSkin()
            Dim img = GetImage()
            If img IsNot Nothing Then
                SetElementImage(skin, img)
            End If
        End Sub
        Public Property CustomStyle() As CustomStyle
            Get
                Return _CustomStyle
            End Get
            Set(ByVal value As CustomStyle)
                _CustomStyle = value
            End Set
        End Property
        Private Function GetImage() As Image
            Return My.Resources.NewButton
        End Function
        Public Sub SetElementImage(ByVal currentSkin As Skin, ByVal image As Image)
            Dim element = currentSkin(CommonSkins.SkinButton)
            element.SetActualImage(image, False)
            element.Image.ImageCount = 18
        End Sub
        Private Function GetCurrentSkin() As Skin
            Return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel)
        End Function
    End Class
End Namespace
