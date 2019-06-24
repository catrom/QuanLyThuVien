<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDocGia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnThemDocGia = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnTimDocGia = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'btnThemDocGia
        '
        Me.btnThemDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnThemDocGia.color = System.Drawing.Color.LightGray
        Me.btnThemDocGia.colorActive = System.Drawing.Color.SeaGreen
        Me.btnThemDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemDocGia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemDocGia.ForeColor = System.Drawing.Color.Black
        Me.btnThemDocGia.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Add_User_Male_64
        Me.btnThemDocGia.ImagePosition = 17
        Me.btnThemDocGia.ImageZoom = 50
        Me.btnThemDocGia.LabelPosition = 34
        Me.btnThemDocGia.LabelText = "Lập thẻ đôc giả"
        Me.btnThemDocGia.Location = New System.Drawing.Point(268, 91)
        Me.btnThemDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThemDocGia.Name = "btnThemDocGia"
        Me.btnThemDocGia.Size = New System.Drawing.Size(132, 117)
        Me.btnThemDocGia.TabIndex = 5
        '
        'btnTimDocGia
        '
        Me.btnTimDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnTimDocGia.color = System.Drawing.Color.LightGray
        Me.btnTimDocGia.colorActive = System.Drawing.Color.DeepSkyBlue
        Me.btnTimDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimDocGia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimDocGia.ForeColor = System.Drawing.Color.Black
        Me.btnTimDocGia.Image = Global.QLTVGUI.My.Resources.Resources.icons8_find_user_male_48
        Me.btnTimDocGia.ImagePosition = 17
        Me.btnTimDocGia.ImageZoom = 50
        Me.btnTimDocGia.LabelPosition = 34
        Me.btnTimDocGia.LabelText = "Tìm đôc giả"
        Me.btnTimDocGia.Location = New System.Drawing.Point(268, 283)
        Me.btnTimDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimDocGia.Name = "btnTimDocGia"
        Me.btnTimDocGia.Size = New System.Drawing.Size(132, 117)
        Me.btnTimDocGia.TabIndex = 6
        '
        'ucDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTimDocGia)
        Me.Controls.Add(Me.btnThemDocGia)
        Me.Name = "ucDocGia"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnThemDocGia As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnTimDocGia As Bunifu.Framework.UI.BunifuTileButton
End Class
