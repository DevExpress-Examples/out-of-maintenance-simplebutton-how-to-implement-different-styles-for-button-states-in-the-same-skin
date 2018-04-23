Namespace dxSample_CustomSimpleButton
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
            Me.customButton3 = New dxSample_CustomSimpleButton.Custom_Button.CustomButton()
            Me.customButton2 = New dxSample_CustomSimpleButton.Custom_Button.CustomButton()
            Me.customButton1 = New dxSample_CustomSimpleButton.Custom_Button.CustomButton()
            Me.SuspendLayout()
            ' 
            ' customButton3
            ' 
            Me.customButton3.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3
            Me.customButton3.Location = New System.Drawing.Point(455, 109)
            Me.customButton3.Name = "customButton3"
            Me.customButton3.Size = New System.Drawing.Size(101, 36)
            Me.customButton3.TabIndex = 2
            Me.customButton3.Text = "customButton3"
            ' 
            ' customButton2
            ' 
            Me.customButton2.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3
            Me.customButton2.Location = New System.Drawing.Point(253, 109)
            Me.customButton2.Name = "customButton2"
            Me.customButton2.Size = New System.Drawing.Size(101, 36)
            Me.customButton2.TabIndex = 1
            Me.customButton2.Text = "customButton2"
            ' 
            ' customButton1
            ' 
            Me.customButton1.CustomStyle = dxSample_CustomSimpleButton.Custom_Button.CustomStyle.Style3
            Me.customButton1.Location = New System.Drawing.Point(55, 109)
            Me.customButton1.Name = "customButton1"
            Me.customButton1.Size = New System.Drawing.Size(101, 36)
            Me.customButton1.TabIndex = 0
            Me.customButton1.Text = "customButton1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Controls.Add(Me.customButton3)
            Me.Controls.Add(Me.customButton2)
            Me.Controls.Add(Me.customButton1)
            Me.Name = "Form1"
            Me.Text = "Form1"

            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customButton1 As Custom_Button.CustomButton
        Private customButton2 As Custom_Button.CustomButton
        Private customButton3 As Custom_Button.CustomButton



    End Class
End Namespace

