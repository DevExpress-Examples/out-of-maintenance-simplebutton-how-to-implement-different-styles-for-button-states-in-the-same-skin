Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.ViewInfo

Namespace dxSample_CustomSimpleButton.Custom_Button
    Public Class CustomSimpleButtonViewInfo
        Inherits SimpleButtonViewInfo

        Public Sub New(ByVal owner As DevExpress.XtraEditors.SimpleButton)
            MyBase.New(owner)
        End Sub
        Protected Overrides Function GetButtonPainter() As DevExpress.XtraEditors.Drawing.EditorButtonPainter
            Return New CustomSkinEditorButtonPainter(LookAndFeel.ActiveLookAndFeel, Owner)
        End Function
    End Class
End Namespace
