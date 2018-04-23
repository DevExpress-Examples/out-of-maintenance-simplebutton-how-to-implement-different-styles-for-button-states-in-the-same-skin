Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins

Namespace dxSample_CustomSimpleButton
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            InitCustomStyle()
        End Sub
        Private Sub InitCustomStyle()
            customButton1.CustomStyle = Custom_Button.CustomStyle.Style1
            customButton2.CustomStyle = Custom_Button.CustomStyle.Style2
            customButton3.CustomStyle = Custom_Button.CustomStyle.Style3
        End Sub
    End Class
End Namespace
